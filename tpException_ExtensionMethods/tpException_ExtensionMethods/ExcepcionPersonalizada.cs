using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpException_ExtensionMethods
{
    class ExcepcionPersonalizada: Excepcion
    {
        public ExcepcionPersonalizada(string Mensaje) : base(Mensaje) { }
            public void Excepciones()
        {

        }

        public string MensajePersonalizado()
        {
            return $"{Mensaje}";
        }
    }
}
