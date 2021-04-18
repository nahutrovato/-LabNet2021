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
          
            Console.WriteLine("Ejercicio numero 1: Se intentara dividir el dividendo ingresado por 0:");
            DividiendoPorCero();
            Console.WriteLine("Ejercicio numero 2: Se intentara dividir el dividendo por el divisor ingresado");
            FnDividir();
            Console.Read();
        }

        public static void DividiendoPorCero()
        {
            Console.WriteLine("Ingrese un numero para dividir");
            string ingresoDividendo = Console.ReadLine();
            int dividendoIngresado = int.Parse(ingresoDividendo);
            try
            {
                int resultadoEjercicio1 = dividendoIngresado / 0;
                Console.WriteLine(resultadoEjercicio1);
            }
            catch (Exception)
            {
                Console.WriteLine("No se puede dividir por cero");
            }
            finally
            {
                Console.WriteLine("Se termino la excepcion del ejercicio 1");
            }
        }
        
        public static void FnDividir()
        {
           try
            {
                Console.WriteLine("Ingrese un numero para dividir");
                string ingresoDividendo = Console.ReadLine();
                int dividendoIngresado = int.Parse(ingresoDividendo);
                Console.WriteLine("Ingrese un numero divisor");
                string ingresoDivisor = Console.ReadLine();
                int divisorIngresado = int.Parse(ingresoDivisor);
                int resultadoEjercicio2 = dividendoIngresado / divisorIngresado;
                Console.WriteLine($"El resultado de {dividendoIngresado} dividido {divisorIngresado} es: {resultadoEjercicio2}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error en el ingreso de formato, ingreso una letra");   
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("No se puede dividir por cero");
            }
            finally
            {
                Console.WriteLine("Se termino la excepcion del ejercicio 2");
            }
        }
    }
}
