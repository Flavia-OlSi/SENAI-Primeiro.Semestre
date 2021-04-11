using System;
using System.IO;
using Aula_56.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Aula_56.Controllers
{

    [Route("Jogador")]
    public class JogadorController : Controller
    {

        //Instanciamos Jogador dentro da classe e chamamos uma ViewBag como apoio e retorno para listar os jogadores disponíveis
        
        Jogador jogadorModel = new Jogador();
        Equipe equipeModel = new Equipe();

        public IActionResult Index()
        {
            ViewBag.Equipes = equipeModel.ReadAll();
            ViewBag.Jogadores = jogadorModel.ReadAll();
            return View();
        }


        //Criamos o método Cadastrar(), passando como argumento um IFormCollection
        [Route("Cadastrar")]
        public IActionResult Cadastrar(IFormCollection form)
        {
            Jogador novoJogador     = new Jogador();
            novoJogador.IdJogador   = Int32.Parse(form["IdJogador"]);
            novoJogador.Nome        = form["Nome"];
            novoJogador.Email       = form["Email"];
            novoJogador.Senha       = form["Senha"];

            jogadorModel.Create(novoJogador);            
            ViewBag.Jogadores = jogadorModel.ReadAll();

            return LocalRedirect("~/Jogador");
        }
    }
}