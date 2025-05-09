using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalConsole.AbstractFactory
{
    internal interface AbstractAeronaveFactory
    {
        IAvion CrearAvion();
        IAvionPrivado CrearAvionPrivado();
        IHelicoptero CrearHelicoptero();
        IDron CrearDron();
    }
}
