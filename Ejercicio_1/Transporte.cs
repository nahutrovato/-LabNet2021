using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    public abstract class Transporte
    {
        public int numeroVehiculo;
        public int cantidadPasajeros;
        public Transporte( int numeroVehiculo, int cantidadPasajeros)
        {
            this.numeroVehiculo = numeroVehiculo;
            this.cantidadPasajeros = cantidadPasajeros;
        }

      

        public abstract string MostrarCantidadPasajeros();
        public abstract string Avanzar();

        public abstract string Detenerse();
    }
}
