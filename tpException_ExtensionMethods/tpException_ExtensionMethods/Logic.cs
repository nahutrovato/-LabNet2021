using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpException_ExtensionMethods
{
    class Logic
    {
       public string Dividir(int numero)
        {
            int resultado = numero / 0;
            return $"El resultado es: {resultado}";
        }
    }
}
