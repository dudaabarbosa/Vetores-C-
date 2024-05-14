using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetores
{
    public class cliente
    {
        protected int id;
        protected string nome;
        protected string dataDeNascimento;
        protected string email;
        protected string telefone;
        protected string endereço;

        public void cadastrar()
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

        public void mostrarDados()
        {
            Console.WriteLine("Nome: " +nome);
            Console.WriteLine("Data de nascimento: " +dataDeNascimento);
            Console.WriteLine("Email: " +email);
            Console.WriteLine("Telefone: " +telefone);
            Console.WriteLine("Endereço: " +endereço);
        }
    }


}
