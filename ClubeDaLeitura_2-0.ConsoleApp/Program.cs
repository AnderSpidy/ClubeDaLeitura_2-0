using System;

namespace ClubeDaLeitura_2_0.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            int caixasiniciais = menu.quantidadeDeCaixas();

            Amigo[] amigos = new Amigo[100];
            Emprestimo[] emprestimos = new Emprestimo[100];
            Caixa[] caixasCadastrar = new Caixa[caixasiniciais];

            string opcao = "";
            while (opcao != "s")
            {

                Console.Clear();
                Console.WriteLine("Clube da Leitura!");
                Console.WriteLine("Digite 1 para cadastrar uma nova caixa");
                Console.WriteLine("Digite 2 para cadastrar uma revista");
                Console.WriteLine("Digite 3 para cadastrar um novo amigo");
                Console.WriteLine("Digite 4 para fazer um emprestimo a um amigo");
                Console.WriteLine("Digite 5 para visualizar caixas");
                Console.WriteLine("Digite 6 para visualizar amigos");
                Console.WriteLine("Digite 7 para visualizar os emprestimos");

                Console.WriteLine("Digite s para sair");
                opcao = Console.ReadLine();

                switch (opcao)
                {

                    case "1":
                        menu.CadastrarCaixa(caixasCadastrar);
                        break;

                    case "2":
                        menu.RevistaCadastrar(caixasCadastrar);
                        break;

                    case "3":
                        menu.AmigoCadastrar(amigos);
                        break;

                    case "4":
                        menu.Emprestar(emprestimos, amigos, caixasCadastrar);
                        break;

                    case "5":
                        menu.VisualizarCaixas(caixasCadastrar);
                        break;

                    case "6":
                        menu.VisualizarAmigos(amigos);
                        break;

                    case "7":
                        menu.VisualizarEmprestimo(emprestimos);
                        break;

                    case "s":
                        Console.WriteLine("FECHAR CLUBE DA LEITURA\nATÉ A PROXIMA!!!");
                        break;

                    default:
                        Console.WriteLine("OPÇÃO INVALIDA.\n DIGITE UMA DAS OPÇÕES SUGERIDAS NO MENU!!!");
                        break;

                }
            }

            Console.ReadLine();

        }


    }
}

