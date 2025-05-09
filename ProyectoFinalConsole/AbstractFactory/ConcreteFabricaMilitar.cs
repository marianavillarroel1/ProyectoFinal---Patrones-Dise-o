using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalConsole.AbstractFactory
{
    internal class ConcreteFabricaMilitar : AbstractAeronaveFactory
    {
        public IAvion CrearAvion()
        {
            return new ConcreteAvionMilitar();
        }

        public IAvionPrivado CrearAvionPrivado()
        {
            return new ConcreteAvionPrivadoMilitar();
        }

        public IHelicoptero CrearHelicoptero()
        {
            return new ConcreteHelicopteroMilitar();
        }

        public IDron CrearDron(string nombre)
        {
            return new ConcreteDronMilitar(nombre);
        }
    }
}
