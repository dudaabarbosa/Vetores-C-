
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
                Console.WriteLine(
                    "1- Cadastro do cliente\n " +
                    "2- Prioridade\n " +
                    "3- Consultar fila\n " +
                    "4- Atender cliente\n q- Sair");


                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        novoCliente.Cadastrar();
                        novoCliente.Fila();
                        break;

                    case "2":
                        novoCliente.Cadastrar();
                        novoCliente.FilaPrioridade();
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
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        break;
                     
                }
            }
        }


    }
}
