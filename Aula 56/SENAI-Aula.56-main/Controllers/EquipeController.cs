using System;
using System.IO;
using Aula_56.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Aula_56.Controllers
{

    //A Route serve para "interligar" o código a página
    //http://localhost:5000/Equipe - *Lembrando que local host porque estamos rodando na propria maquina, não num dominio
    [Route("Equipe")]
    //Herdamos essa classe controller para mapear o esse arquivo de controller e para ele entender que o arquivo Index vai carregar uma pagina quando chamar esse endereço
    public class EquipeController : Controller
    {

        Equipe equipeModel = new Equipe();
        
         //http://localhost:5000/Equipe/Listar
        [Route("Listar")]
        public IActionResult Index()
        {

            //Listamos todas as equipes e enviamos para a View, através da ViewBag
            ViewBag.Equipes = equipeModel.ReadAll();
            return View();
        }

         //http://localhost:5000/Equipe/Cadastrar
        [Route("Cadastrar")]
        public IActionResult Cadastrar(IFormCollection form)
        {
            Equipe novaEquipe   = new Equipe();
            novaEquipe.IdEquipe = Int32.Parse(form["IdEquipe"]);
            novaEquipe.Nome     = form["Nome"];
            
            
            //Upload Início

            //Verificamos se o usuário selecionou um arquivo
            if(form.Files.Count > 0)
            {
                //Recebemos o arquivo que o usuário enviou e armazemos na variável file
                var file    = form.Files[0];
                var folder  = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Equipes");

                //Verificamos se o diretorio (pasta) já existe, caso não, criamos
                if(!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                //Directory.GetCurrentDirectory -> localhost:5001
                //folder -> Equipes
                //file.FileName -> imagem.jpg
                var path    = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/", folder, file.FileName);
                using(var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

                novaEquipe.Imagem   = file.FileName;
            }
            else
            {
                novaEquipe.Imagem   = "padrao.png";
            }

            //Upload Final

            //Chamamos os método Create para salvar a novaEquipe no CSV
            equipeModel.Create(novaEquipe);
            //Atualiza a lista de equipes na View
            ViewBag.Equipe  = equipeModel.ReadAll();

            //Rederecinamento para atualização de página para mesma pasta que estamos
            return LocalRedirect("~/Equipe/Listar");
        }

         //http://localhost:5000/Equipe/1
        [Route("{id}")]
        public IActionResult Excluir(int id)
        {
            equipeModel.Delete(id);
            ViewBag.Equipes = equipeModel.ReadAll();
            return LocalRedirect("~/Equipe/Listar");
        }
    }
}