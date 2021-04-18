using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpException_ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero para dividir");
            string ingresoDividendo = Console.ReadLine();
            int dividendo = int.Parse(ingresoDividendo);
            Dividir(dividendo);
            Console.Read();
        }

        public static void Dividir(int dividendo)
        {
            try
            {
                int resultado = dividendo / 0;
                Console.WriteLine(resultado);
            }
            catch (Exception)
            {
                Console.WriteLine("No se puede dividir por cero");
            }
            finally
            {
                Console.WriteLine("Se termino la excepcion");
            }
        }
    }
}
