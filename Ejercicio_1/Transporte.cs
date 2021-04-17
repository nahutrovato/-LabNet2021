using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    public abstract class Transporte
    {
        public int NumeroVehiculo { get; set; }
        public int CantidadPasajeros { get; set; }
       
        public Transporte( int numeroVehiculo, int cantidadPasajeros)
        {
            this.NumeroVehiculo = numeroVehiculo;
            this.CantidadPasajeros = cantidadPasajeros;
        }

      

        public abstract string MostrarCantidadPasajeros();
        public abstract string Avanzar();

        public abstract string Detenerse();
    }
}
