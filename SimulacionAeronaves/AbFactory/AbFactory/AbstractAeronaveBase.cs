using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbFactory
{
    internal abstract class AbstractAeronaveBase
    {
        public string Fabricante {  get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public string CostoVuelo { get; set; }
        public int VuelosRealizados { get; private set; }

        public virtual void Volar()
        {
            VuelosRealizados++;
            Console.WriteLine($"{GetType().Name} esta volando. -- Su total de vuelos es: {VuelosRealizados}");
        }
    }
}
