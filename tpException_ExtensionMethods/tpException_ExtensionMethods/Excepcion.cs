using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpException_ExtensionMethods
{
    public class ExcepcionPersonalizada : Exception
    {
        public ExcepcionPersonalizada(string mensaje) : base (mensaje)
        {
            Console.WriteLine(mensaje);
        }
    }
    
}
