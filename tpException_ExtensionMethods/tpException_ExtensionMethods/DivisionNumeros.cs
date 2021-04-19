using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpException_ExtensionMethods
{
    class DivisionNumeros
    {
        public string Division()
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
        }
    }
}
