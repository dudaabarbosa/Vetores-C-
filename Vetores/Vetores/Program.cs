
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetores
{
    public class Program
    {
        // protected int tamanhoDaFila = 9;
        
        static void Main(string[] args)
        {


            
            Console.WriteLine("Cadastro do cliente");

            Cliente novoCliente = new Cliente();
            novoCliente.cadastrar();
            Console.WriteLine("Confirme os dados abaixo:");
            
            novoCliente.mostrarDados();


            Console.WriteLine("Fila de espera:");
            novoCliente.fila();
          
               


            //int[] vetor = new int[9];
            //for (int i = 0; i < 9; i++)
            //{
            //  vetor[i] = novoCliente.
            //}

        }

        //public void filaClientes()
        //{
          //  Console.WriteLine("Clientes:");
            //for (int i = 0; i < tamanhoDaFila; i++)
           // {
              //  Console.WriteLine(i);

            //}

        }

    }
