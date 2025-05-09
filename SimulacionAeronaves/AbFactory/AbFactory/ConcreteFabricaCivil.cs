using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbFactory
{
    internal class ConcreteFabricaCivil : AbstractAeronaveFactory
    {
        public IAvion CrearAvion()
        {
            return new ConcreteAvionCivil();
        }

        public IAvionPrivado CrearAvionPrivado()
        {
            return new ConcreteAvionPrivadoCivil();
        }

        public IHelicoptero CrearHelicoptero()
        {
            return new ConcreteHelicopteroCivil();
        }

        public IDron CrearDron()
        {
            return new ConcreteDronCivil();
        }
    }
}
