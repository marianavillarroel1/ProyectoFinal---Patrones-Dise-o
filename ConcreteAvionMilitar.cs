using ProyectoFinalConsole.Observer;
using ProyectoFinalConsole.Visitor;
using System;

namespace ProyectoFinalConsole.AbstractFactory
{
    internal class ConcreteAvionMilitar : IAvion
    {
        public ConcreteAvionMilitar()
            : base("Lockheed Martin", "F-22 Raptor", "MIL-A001", 3200.0)
        {
        }

        public override void InterpretarAlerta(string codigoAlerta)
        {
            switch (codigoAlerta)
            {
                case "C2":
                    Console.WriteLine("AVIÓN MILITAR: Intercepta aeronave desconocida.");
                    break;
                case "B3":
                    Console.WriteLine("AVIÓN MILITAR: Redirige a base alterna.");
                    break;
                default:
                    Console.WriteLine("AVIÓN MILITAR: Monitorea situación.");
                    break;
            }
        }

        public override void aceptarVisitor(IEstadisticaVisitor visitor)
        {
            //visitor.visitarAvionMilitar(this);
        }
    }
}
