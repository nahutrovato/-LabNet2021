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
            int numero = 10;
            Console.Write(numero.DividirPorCero());
            Console.ReadLine();
            Console.WriteLine(Division());
            Console.ReadLine();
            
            Logic capturandoExcepciones = new Logic();
            try
            {
                Console.WriteLine(capturandoExcepciones.Dividir(10));

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("No se puede dividir por cero");
            }
            finally
            {
                Console.WriteLine("Se termino la ejecucion del ejercicio 3");
            }
            Console.ReadLine();
        }


        public static string Division()
        {
            Console.WriteLine("Ingrese un numero");
            string ingresoNumeroUno = Console.ReadLine();
            int num1 = int.Parse(ingresoNumeroUno);
            Console.WriteLine("Ingrese un numero");
            string ingresoNumeroDos = Console.ReadLine();
            int num2 = int.Parse(ingresoNumeroDos);


            try
            {
                int resultado = num1 / num2;
                return $"El resultado es:{resultado}";
            }
            catch (DivideByZeroException)
            {
                return $"Solo Chuck Norris divide por cero!";
            }
            catch (FormatException)
            {
                return $"Seguro Ingreso una letra o no ingreso nada!";
            }
            finally
            {
                Console.WriteLine("Se termino la ejecucion del ejercicio 2");
            }
            
        }
    }
}
