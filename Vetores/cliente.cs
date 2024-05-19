using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetores
{
    public class Cliente
    {
       
            Cliente pessoa;
            protected Cliente[] vetor;
            protected int capacidade = 10;
            protected int inicio = 0;
            protected int prioridade = 0;
            protected int fila = 0;
            public Cliente cli_prioridade;

            protected string nome;
            protected string dataDeNascimento;
            protected string email;
            protected string telefone;
            protected string endereço;

            public Cliente()
            {
                vetor = new Cliente[capacidade];
            }

            public void Cadastrar()
            {
                if (fila < capacidade)
                {
                    pessoa = new Cliente();
                    Console.WriteLine("Digite o nome do cliente:");
                    pessoa.nome = Console.ReadLine();
                    Console.WriteLine("Digite a data de nascimento:");
                    pessoa.dataDeNascimento = Console.ReadLine();
                    Console.WriteLine("Digite o email:");
                    pessoa.email = Console.ReadLine();
                    Console.WriteLine("Digite o telefone:");
                    pessoa.telefone = Console.ReadLine();
                    Console.WriteLine("Digite o endereço:");
                    pessoa.endereço = Console.ReadLine();
                    vetor[inicio] = pessoa;
                    inicio++;
                    fila++;
                }
                else
                {
                    Console.WriteLine("A fila está cheia");
                }
            }

            public void MostrarDados()
            {
                Console.WriteLine("Nome: " + this.nome);
                Console.WriteLine("Data de nascimento: " + this.dataDeNascimento);
                Console.WriteLine("Email: " + this.email);
                Console.WriteLine("Telefone: " + this.telefone);
                Console.WriteLine("Endereço: " + this.endereço);
            }

            public void FilaPrioridade()
            {
                if (fila < capacidade)
                {
                    cli_prioridade = new Cliente();
                    Console.WriteLine("Digite o nome do cliente prioritário:");
                    cli_prioridade.nome = Console.ReadLine();
                    Console.WriteLine("Digite a data de nascimento:");
                    cli_prioridade.dataDeNascimento = Console.ReadLine();
                    Console.WriteLine("Digite o email:");
                    cli_prioridade.email = Console.ReadLine();
                    Console.WriteLine("Digite o telefone:");
                    cli_prioridade.telefone = Console.ReadLine();
                    Console.WriteLine("Digite o endereço:");
                    cli_prioridade.endereço = Console.ReadLine();

                    for (int s = fila - 1; s >= prioridade; s--)
                    {
                        vetor[s + 1] = vetor[s];
                    }

                    vetor[prioridade] = cli_prioridade;
                    fila++;
                    prioridade++;
                }
                else
                {
                    Console.WriteLine("A fila está cheia");
                }
            }

            public void ConsultarFila()
            {
                Console.WriteLine("Clientes na fila:");

                for (int i = 0; i < prioridade; i++)
                {
                    Console.WriteLine("Cliente Prioritário " + (i + 1));
                    if (vetor[i] != null)
                    {
                        vetor[i].MostrarDados();
                    }
                    Console.WriteLine();
                }

                for (int i = prioridade; i < fila; i++)
                {
                    Console.WriteLine("Cliente " + (i + 1));
                    if (vetor[i] != null)
                    {
                        vetor[i].MostrarDados();
                    }
                    Console.WriteLine();
                }
            }


            public void Atender()
            {
            if (fila > 0)
            {
                Cliente clienteAtendido = vetor[0];
                for (int i = 0; i < fila - 1; i++)
                {
                    vetor[i] = vetor[i + 1];
                }
                fila--;
                Console.WriteLine("ok");
            }
            else
            {
                Console.WriteLine("o");
            }
        }
    }
}


