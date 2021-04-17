using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Transporte> vehiculos = new List<Transporte>
            
            {
                 new Automovil(1,2),
                new Automovil(2,1),
                new Automovil(3,3),
                new Automovil(4,4),
                new Automovil(5,1),
                new Avion(1,150),
                new Avion(2,180),
                new Avion(3,202),
                new Avion(4,209),
                new Avion(5,113)
            };
             

            foreach (var item in vehiculos)
            {
                Console.WriteLine(item.MostrarCantidadPasajeros());
            }
            Console.ReadLine();
        }
    }
}
