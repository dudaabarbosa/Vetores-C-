
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
            Console.WriteLine("Cadastro do Cliente");
            cliente um = new cliente();
            um.cadastrar();
            Console.WriteLine("Confirme os dados abaixo:");
            um.mostrarDados();
        }


    }
}
