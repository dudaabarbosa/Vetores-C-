using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetores
{
    public class Cliente
    {
        int f;
        int i;
        protected int[] vetor;
        protected int fim;
        protected int capacidade;
        protected int tamanho;
        protected int fila;
        protected int id;
        protected string nome;
        protected string dataDeNascimento;
        protected string email;
        protected string telefone;
        protected string endereço;

        public void Cadastrar()
        {
            if (fila < 10)
            {
                Console.WriteLine("Digite o nome do cliente:");
                this.nome = Console.ReadLine();
                Console.WriteLine("Digite a data de nascimento:");
                this.dataDeNascimento = Console.ReadLine();
                Console.WriteLine("Digite o email:");
                this.email = Console.ReadLine();
                Console.WriteLine("Digite o telefone:");
                this.telefone = (Console.ReadLine());
                Console.WriteLine("Digite o endereço:");
                this.endereço = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("A fila está cheia");
            }
        }

        public void MostrarDados()
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Data de nascimento: " + dataDeNascimento);
            Console.WriteLine("Email: " + email);
            Console.WriteLine("Telefone: " + telefone);
            Console.WriteLine("Endereço: " + endereço);
        }

        public void Fila()
        {
           
        }

        public void FilaPrioridade()
        {

        }

        public void ConsultarFila()
        {
            if (tamanho == 0)
            {
                Console.WriteLine("Fila vazia.");
            }
            else
            {
                Console.WriteLine("Fila:");

                while (fim == f)
                {
                    Console.WriteLine(vetor[i]);
                    i = (i + 1) % capacidade;
                }
                Console.WriteLine(vetor[f]);
            }
        }

        public void Atender()
        {

            Console.WriteLine();
        }

     
    }

}

