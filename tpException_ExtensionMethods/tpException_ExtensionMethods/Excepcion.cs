using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpException_ExtensionMethods
{
    class Excepcion
    {
        public string Mensaje { get; set; }
        public Excepcion(string Mensaje)
        {
            this.Mensaje = Mensaje;
        }
        public string MensajePersonalizado(string Mensaje)
        {
            this.Mensaje = Mensaje;
            return $"{Mensaje}";
        }
        
    }
    
}
