using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    public class Avion : Transporte
    {
        public Avion(int cantidadPasajeros, int numeroVehiculo) : base(cantidadPasajeros, numeroVehiculo) { }
        public override string Avanzar()
        {
            return $"El avion {numeroVehiculo} con {cantidadPasajeros} pasajeros comienza a despegar por la pista";
        }

        public override string Detenerse()
        {
            return $"El avion {numeroVehiculo} con {cantidadPasajeros} pasajeros ha aterrizado en la pista";
        }

        public override string MostrarCantidadPasajeros()
        {
            return $"El avion {numeroVehiculo} tiene {cantidadPasajeros} pasajeros";
        }
    }
}
