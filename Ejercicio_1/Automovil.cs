using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    public class Automovil : Transporte
    {
        public Automovil(int cantidadPasajeros, int numeroVehiculo) : base(cantidadPasajeros, numeroVehiculo) { }
        
        public override string Avanzar()
        {
            return $"El auto {NumeroVehiculo} con {CantidadPasajeros} pasajeros va en la calle a 20km/h";
        }

        public override string Detenerse()
        {
            return $"El auto {NumeroVehiculo} se detuvo, los {CantidadPasajeros} pasajeros se bajaron del auto ";
        }

        public override string MostrarCantidadPasajeros()
        {
            return $"El auto {NumeroVehiculo} tiene {CantidadPasajeros} pasajeros";
        }
    }
}
