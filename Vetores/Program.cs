
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetores
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Cliente novoCliente = new Cliente();

            string opcao;

            while (true)
            {
                Console.WriteLine("\nEscola uma opção abaixo:");
                Console.WriteLine(
                    "\n 1- Cadastro do cliente\n " +
                    "2- Prioridade\n " +
                    "3- Consultar fila\n " +
                    "4- Atender cliente\n q- Sair\n");


                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        novoCliente.Cadastrar();
                        Console.WriteLine("\nConfirme os dados abaixo:\n");
                        novoCliente.MostrarDados();
                        Console.WriteLine("\n Os dados estão corretos S/N\n");
                        string resposta = Console.ReadLine();

                        if (resposta.ToUpper() == "S")
                        {
                            novoCliente.Fila();
                            Console.WriteLine("\nCadastro feito com sucesso!!\n Cliente adicionado a fila de espera\n");
                        }
                        else
                        {
                            Console.WriteLine("\nFaça o cadastro novamente\n");
                            novoCliente.Cadastrar();
                            novoCliente.MostrarDados();
                            Console.WriteLine("\n Os dados estão corretos S/N\n");
                            Console.ReadLine();
                            novoCliente.Fila();
                            Console.WriteLine("\nCadastro feito com sucesso!!\n Cliente adicionado a fila de espera\n");
                        }
                        break;

                    case "2":
                        novoCliente.Cadastrar();
                        Console.WriteLine("\nConfirme os dados abaixo:\n");
                        novoCliente.MostrarDados();
                        Console.WriteLine("\n Os dados estão corretos S/N\n");
                        resposta = Console.ReadLine();

                        if (resposta.ToUpper() == "S")
                        {
                            novoCliente.FilaPrioridade();
                            Console.WriteLine("\nCadastro feito com sucesso!!\n Cliente adicionado a fila de espera\n");
                        }
                        else
                        {
                            Console.WriteLine("\nFaça o cadastro novamente\n");
                            novoCliente.Cadastrar();
                            Console.WriteLine("\n Os dados estão corretos S/N\n");
                            novoCliente.MostrarDados();
                            Console.ReadLine();
                            novoCliente.FilaPrioridade();
                            Console.WriteLine("\nCadastro feito com sucesso!!\n Cliente adicionado a fila de espera\n");
                        }
                        break;

                    case "3":
                        novoCliente.ConsultarFila();
                        break;

                    case "4":
                        novoCliente.Atender();
                        break;

                    case "q":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("\nOpção inválida! Tente novamente.");
                        break;
                     
                }
            }
        }


    }
}
