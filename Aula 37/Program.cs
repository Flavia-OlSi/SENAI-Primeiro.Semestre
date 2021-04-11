using System;

namespace Aula_37
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] nomes = new string[10];
            float[,] notas = new float[10, 4];
            float[] mediaGeral = new float[10];
            int a = 0;
            int r = 0;
            int escolha = 0;
            float mediaGeralAlunos = 0;

            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine($"Digite o nome do {i + 1}º aluno: ");
                nomes[i] = Console.ReadLine();
                for (var x = 0; x < 4; x++)
                {
                    Console.WriteLine($"Digite a {x + 1}ª nota do aluno: ");
                    notas[i, x] = float.Parse(Console.ReadLine());
                }
                Console.Clear();
            }

            do
            {
                Console.WriteLine("MENU \n1 - Média dos aluno \n2 - Quantidade de alunos aprovados \n3 - Quantidade de alunos reprovados \n4 - Média geral dos alunos \n5 - Sair");
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        for (var i = 0; i < 10; i++)
                        {
                            float mediaAluno = (notas[i, 0] + notas[i, 1] + notas[i, 2] + notas[i, 3]) / 4;
                            if (mediaAluno >= 7)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"O(A) aluno(a) {nomes[i]} obteve a média de nota igual a {mediaAluno}, sendo assim ele(a) está APROVADO(A)");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"O(A) aluno(a) {nomes[i]} obteve a média de nota igual a {mediaAluno}, sendo assim ele(a) está REPROVADO(A)");
                            }
                        }
                        Console.ResetColor();
                        break;

                    case 2:
                        for (var i = 0; i < 10; i++)
                        {
                            float mediaAluno = (notas[i, 0] + notas[i, 1] + notas[i, 2] + notas[i, 3]) / 4;
                            if (mediaAluno >= 7)
                            {
                                a = a + 1;
                            }
                            else
                            {
                                a = a + 0;
                            }
                        }
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Foram aprovados {a} alunos");
                        Console.ResetColor();
                        break;

                    case 3:
                        for (var i = 0; i < 10; i++)
                        {
                            float mediaAluno = (notas[i, 0] + notas[i, 1] + notas[i, 2] + notas[i, 3]) / 4;
                            if (mediaAluno < 7)
                            {
                                r = r + 1;
                            }
                            else
                            {
                                r = r + 0;
                            }
                        }
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Foram reprovados {r} alunos");
                        Console.ResetColor();
                        break;

                    case 4:
                        for (var i = 0; i < 10; i++)
                        {
                            float mediaAluno = (notas[i, 0] + notas[i, 1] + notas[i, 2] + notas[i, 3]) / 4;
                            mediaGeral[i] = mediaAluno;
                        }
                        mediaGeralAlunos = (mediaGeral[0] + mediaGeral[1] + mediaGeral[2] + mediaGeral[3] + mediaGeral[4] + mediaGeral[5] + mediaGeral[6] + mediaGeral[7] + mediaGeral[8] + mediaGeral[9]) / 10;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"A média geral dos alunos é {mediaGeralAlunos}");
                        Console.ResetColor();
                        break;

                    case 5:
                        Console.WriteLine("Menu fechado");
                        break;

                    default:
                        Console.WriteLine("Opção invalida");
                        break;
                }
            } while (escolha != 5);
        }
    }

}

