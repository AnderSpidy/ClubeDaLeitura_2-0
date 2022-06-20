using System;

namespace ClubeDaLeitura_2_0.ConsoleApp
{
    internal class Program
    {
        static Notificador notificador = new Notificador();
        static Menu menuPrincipal = new Menu();
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
                opcao = OpçãoDeMenu("Principal","Clube da Leitura!2.0\nMENU PRINCIPAL:\n");


                switch (opcao)
                {
                    
                    case "1":
                        string opcaoMenuCaixa = OpçãoDeMenu("Gerenciamento", "GERENCIAMENTO DE CAIXA:");
                        if(opcaoMenuCaixa == "1")
                        menu.CadastrarCaixa(caixasCadastrar);
                        if (opcaoMenuCaixa == "2")
                            menu.VisualizarCaixas(caixasCadastrar);
                        break;

                    case "2":
                        string opcaoMenuRevista = OpçãoDeMenu("Gerenciamento", "GERENCIAMENTO DE REVISTA:");
                        if (opcaoMenuRevista == "1")
                            menu.RevistaCadastrar(caixasCadastrar);
                        if (opcaoMenuRevista == "2")
                            menu.VisualizarCaixas(caixasCadastrar);
                        break;

                    case "3":
                        string opcaoMenuAmigos = OpçãoDeMenu("Gerenciamento", "GERENCIAMENTO DE AMIGO:");
                        if (opcaoMenuAmigos == "1")
                            menu.AmigoCadastrar(amigos);
                        if (opcaoMenuAmigos == "2")
                            menu.VisualizarAmigos(amigos);
                        break;

                    case "4":
                        string opcaoMenuEmprestimo = OpçãoDeMenu("Gerenciamento", "GERENCIAMENTO DE EMPRESTIMO:");
                        if (opcaoMenuEmprestimo == "1")
                            menu.Emprestar(emprestimos, amigos, caixasCadastrar);
                        if (opcaoMenuEmprestimo == "2")
                            menu.VisualizarEmprestimo(emprestimos);
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

        private  static string OpçãoDeMenu(string menu, string titulo )
        {
            if (menu == "Principal") { 
            Console.WriteLine(titulo);
            Console.WriteLine("Digite 1 para gerenciar uma nova caixa");
            Console.WriteLine("Digite 2 para gerenciar uma revista");
            Console.WriteLine("Digite 3 para gerenciar um novo amigo");
            Console.WriteLine("Digite 4 para fazer um emprestimo a um amigo");
            Console.WriteLine("Digite s para sair");
                string opcao = Console.ReadLine();
                return opcao;
        }
            if(menu == "Gerenciamento")
            {
                Console.WriteLine(titulo);
                Console.WriteLine("Digite 1 para inserir:");
                Console.WriteLine("Digite 2 para editar:");
                Console.WriteLine("Digite 3 para excluir:");
                Console.WriteLine("Digite s para sair:");
                string opcao = Console.ReadLine();
                return opcao;
            }

            return "volta";
        }
    }
}

