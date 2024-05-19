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
        public Cliente cli_prioridade;
        protected Cliente[] vetor;
        protected int capacidade = 10;
        protected int prioridade = 0;
        protected int fila = 0;

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
                vetor[fila] = pessoa;
                fila++;
            }
            else
            {
                Console.WriteLine("A fila está cheia");
            }
        }

        public void MostrarDadosPessoa()
        {
            Console.WriteLine("Nome: " + pessoa.nome);
            Console.WriteLine("Data de nascimento: " + pessoa.dataDeNascimento);
            Console.WriteLine("Email: " + pessoa.email);
            Console.WriteLine("Telefone: " + pessoa.telefone);
            Console.WriteLine("Endereço: " + pessoa.endereço);
        }

        public void MostrarDadosPrioridade()
        {
            Console.WriteLine("Nome: " + cli_prioridade.nome);
            Console.WriteLine("Data de nascimento: " + cli_prioridade.dataDeNascimento);
            Console.WriteLine("Email: " + cli_prioridade.email);
            Console.WriteLine("Telefone: " + cli_prioridade.telefone);
            Console.WriteLine("Endereço: " + cli_prioridade.endereço);
        }

        public void MostrarDados()
        {
            Console.WriteLine("Nome: " + this.nome);
        }

        public void Prioridade()
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
            if (fila > 0)
            {
                Console.WriteLine("\nClientes na fila:\n");

                for (int i = 0; i < prioridade; i++)
                {
                    Console.WriteLine("Cliente " + (i + 1));

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
            else
            {
                Console.WriteLine("Fila Vazia");
            }
        }


        public void Atender()
        {
            if (fila > 0)
            {
                Cliente pessoaAtendida = vetor[0];

                for (int i = 1; i < fila; i++)
                {
                    vetor[i - 1] = vetor[i];
                }

                vetor[fila - 1] = null;
                fila--;
                Console.WriteLine("Cliente:" + pessoaAtendida.nome + " atendido.");
            }
            else
            {
                Console.WriteLine("Não há clientes na fila.");
            }
        }
    }
}

          


