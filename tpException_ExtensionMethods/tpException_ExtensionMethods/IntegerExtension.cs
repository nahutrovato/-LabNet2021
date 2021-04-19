using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpException_ExtensionMethods
{
    public static class IntegerExtension
    {
        public static string DividirPorCero(this int numero)
        {
            try
            {
                int resultado = numero / 0;
                return $"El resultado es: {resultado}";
            }
            catch (Exception)
            {
                return $"No se puede dividir por cero";
            }
        }
    }
}
