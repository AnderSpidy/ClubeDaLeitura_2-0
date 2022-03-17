using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura_2_0.ConsoleApp
{
    internal class Menu
    {
        public int quantidadeDeCaixas()
        {

            Console.WriteLine("Digite a quantidade de caixas que possui:");
            int numerodeCaixas = Convert.ToInt32(Console.ReadLine());
            return numerodeCaixas;
        }
        public void VisualizarCaixas(Caixa[] caixas)
        {
          for (int i = 0; i < caixas.Length; i++)
            {
                if (caixas[i] != null)
                {
                    Console.WriteLine("{0,-10} | {1,-20} | {2,-20}", "Numero", "Cor", "Etiqueta");
                    Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("{0,-10} | {1,-20} | {2,-20}", caixas[i].numero, caixas[i].cor, caixas[i].etiqueta);
                    Console.WriteLine("{0,-10} | {1,-20} | {2,-20} | {3,-20}", "ID", "Tipo", "Edicao", "Ano");
                    Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");

                    for (int j = 0; j < caixas[i].revistas.Length; j++)
                    {
                        if (caixas[i].revistas[j] != null)
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("{0,-10} | {1,-20} | {2,-20} | {3,-20}", j, caixas[i].revistas[j].tipo, caixas[i].revistas[j].edicao, caixas[i].revistas[j].ano);
                        }
                        else
                        {
                            Console.ResetColor();
                            Console.WriteLine("\n\n");
                            break;
                        }
                    }
                    continue;
                }
                else
                {
                    Console.WriteLine();
                    break;
                }
            }
            Console.ReadLine();
        }
        public void VisualizarAmigos(Amigo[] amigosCadastrados)
        {
            Console.WriteLine("{0,-20} | {1,-20} | {2,-20} | {3,-20}", "Nome", "Responsavel", "Telefone", "Endereço");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
            for (int i = 0; i < amigosCadastrados.Length; i++)
            {
             if (amigosCadastrados[i] != null)
                {
                    Console.WriteLine("{0,-20} | {1,-20} | {2,-20} | {3,-20}", amigosCadastrados[i].nome, amigosCadastrados[i].nomeResponsavel, amigosCadastrados[i].telefone, amigosCadastrados[i].endereco);
                    continue;
                }
                else
                {
                    Console.WriteLine();
                    break;
                }
            }
            Console.ReadLine();
        }

        public void VisualizarEmprestimo(Emprestimo[] emprestimos)
        {
            Console.WriteLine("{0,-20} | {1,-20} | {2,-20} | {3,-20}", "Amigo", "Revista", "Data emprestimo", "Tempo emprestado");
            for (int i = 0; i < emprestimos.Length; i++)
            {
                if (emprestimos[i] != null)
                {
                    Console.WriteLine("{0,-20} | {1,-20} | {2,-20} | {3,-20}", emprestimos[i].amigoEmprestou.nome, emprestimos[i].revistaEmprestada.tipo, emprestimos[i].dataEmprestimo, emprestimos[i].dataDevolucao);
                    continue;
                }
                else
                {
                    Console.WriteLine();
                    break;
                }
            }
            Console.ReadLine();
        }
        public void CadastrarCaixa(Caixa[] caixas)
        {
            Caixa novaCaixa = new Caixa();
            Console.WriteLine("Cadastro da nova caixa:");
            Console.WriteLine("Digite a cor da caixa:");
            novaCaixa.cor = Console.ReadLine();
            Console.WriteLine("Digite a etiqueta da caixa:");
            novaCaixa.etiqueta = Console.ReadLine();
            Console.WriteLine("Digite o numero da Caixa:");
            novaCaixa.numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de revistas podem conter nesta caixa");
            int quantidadeRevistas = Convert.ToInt32(Console.ReadLine());
            novaCaixa.revistas = new Revista[quantidadeRevistas];

            for (int i = 0; i < caixas.Length; i++)
            {
                if (caixas[i] == null)
                {
                    caixas[i] = novaCaixa;
                    break;
                }
            }
            Console.Clear();
        }
        public void RevistaCadastrar(Caixa[] caixasCadastrar)
        {
            Revista novaRevista = new Revista();
            Console.WriteLine("Cadastro da nova revista:");
            Console.WriteLine("Digite o tipo da revista:");
            novaRevista.tipo = Console.ReadLine();
            Console.WriteLine("Digite o numero da edição:");
            novaRevista.edicao = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o ano da revista:");
            novaRevista.ano = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o digito de qual caixa a revista esta guardada:");
            for (int i = 0; i < caixasCadastrar.Length; i++)
            {
                if (caixasCadastrar[i] != null)
                {
                    Console.WriteLine(i + " -> " + caixasCadastrar[i].cor + " " + caixasCadastrar[i].etiqueta);
                    continue;
                }
                else
                {
                    Console.WriteLine();
                    break;
                }
            }
            int caixaselcionada = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < caixasCadastrar.Length; i++)
            {
                if (caixaselcionada == i)
                {
                    novaRevista.caixaGuardada = caixasCadastrar[i];
                    for (int j = 0; j < caixasCadastrar.Length; j++)
                    {
                        if (caixasCadastrar[i].revistas[j] == null)
                        {
                            caixasCadastrar[i].revistas[j] = novaRevista;
                            break;
                        }

                    }
                }
            }
        }

        public void AmigoCadastrar(Amigo[] amigos)
        {
            Amigo novoAmigo = new Amigo();
            Console.WriteLine("Cadastro de um novo Amigo:");
            Console.WriteLine("Digite o nome do Amigo:");
            novoAmigo.nome = Console.ReadLine();
            Console.WriteLine("Digite o nome do responsavel:");
            novoAmigo.nomeResponsavel = Console.ReadLine();
            Console.WriteLine("Digite o telefonae para contato:");
            novoAmigo.telefone = Console.ReadLine();
            Console.WriteLine("Digite o endereço do amigo:");
            novoAmigo.endereco = Console.ReadLine();

            for (int i = 0; i < amigos.Length; i++)
            {
                if (amigos[i] == null)
                {
                    amigos[i] = novoAmigo;
                    break;
                }
            }

        }
        public void Emprestar(Emprestimo[] emprestimos, Amigo[] amigos, Caixa[] caixas)
        {
            Emprestimo novoEmprestimo = new Emprestimo();
            Console.WriteLine("Emprestar revista:");

            for (int i = 0; i < amigos.Length; i++)
            {
                if (amigos[i] != null)
                {
                    Console.WriteLine(i + " - " + amigos[i].nome);
                }
                else
                    break;
            }
            while (true)
            {
                Console.WriteLine("Digite o id do amigo que ira fazer emprestar:");
                string opcaoAmigos = Console.ReadLine();
                if (emprestimos[Convert.ToInt32(opcaoAmigos)] != null)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Este amigo já está com uma revista emprestada");
                    Console.ResetColor();
                    continue;
                }


                for (int i = 0; i < amigos.Length; i++)
                {
                    if (Convert.ToInt32(opcaoAmigos) == i)
                    {

                        novoEmprestimo.amigoEmprestou = amigos[i];
                        break;
                    }
                }
                break;
            }
            Console.Clear();
            Console.WriteLine("{0,-10} | {1,-20} | {2,-20}", "Numero", "Cor", "Etiqueta");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
            for (int i = 0; i < caixas.Length; i++)
            {
                if (caixas[i] != null)
                {
                    Console.WriteLine("{0,-10} | {1,-20} | {2,-20}", caixas[i].numero, caixas[i].cor, caixas[i].etiqueta);
                    continue;
                }
                else
                {
                    Console.WriteLine();
                    break;
                }
            }
            Console.WriteLine("Digite o numero da caixa:");
            int opcaonumeroCaixa = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0,-10} | {1,-20} | {2,-20} | {3,-20}", "ID", "Tipo", "Edicao", "Ano");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
            
            for (int i = 0; i < caixas[i].revistas.Length; i++)
            {
                if (caixas[i].numero == opcaonumeroCaixa)
                {
                    for (int j = 0; j < caixas[i].revistas.Length; j++)
                    {
                        if(caixas[i].revistas[j] != null)
                        {
                            Console.WriteLine("{0,-10} | {1,-20} | {2,-20} | {3,-20}", j, caixas[i].revistas[j].tipo, caixas[i].revistas[j].edicao, caixas[i].revistas[j].ano);
                            continue;
                        }
                        else
                        {
                            Console.WriteLine();
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine();
                    break;
                }
            }

            for (int i = 0; i < caixas.Length; i++)
            {
                if (opcaonumeroCaixa == caixas[i].numero)
                {
                    Console.WriteLine("Digite o ID da revista que deseja emprestar:");
                    int opcaoRevista = Convert.ToInt32(Console.ReadLine());
                    novoEmprestimo.revistaEmprestada = caixas[i].revistas[opcaoRevista];
                    break;
                }
            }
            Console.Clear();

            Console.WriteLine("Digite a data do emprestimo:");
            novoEmprestimo.dataEmprestimo = Convert.ToDateTime(Console.ReadLine());
            DateTime dataAtual = DateTime.Now;
            TimeSpan periodoTempo = dataAtual - novoEmprestimo.dataEmprestimo;
            novoEmprestimo.dataDevolucao = periodoTempo.Days;
            //colocar o novoemprestimo na array de emprestimos
            for (int i = 0; i < emprestimos.Length; i++)
            {
                if (emprestimos != null)
                {
                    emprestimos[i] = novoEmprestimo;
                    break;
                }
            }
        }
    }
}
