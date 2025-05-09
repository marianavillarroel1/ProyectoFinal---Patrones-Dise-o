using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalConsole.AbstractFactory
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

        public IDron CrearDron(string nombre)
        {
            return new ConcreteDronCivil(nombre);
        }

        public IHelicoptero CrearHelicoptero()
        {
            return new ConcreteHelicopteroCivil();
        }

    }
}
