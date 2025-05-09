using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbFactory
{
    internal interface AbstractAeronaveFactory
    {
        IAvion CrearAvion();
        IAvionPrivado CrearAvionPrivado();
        IHelicoptero CrearHelicoptero();
        IDron CrearDron();
    }
}
