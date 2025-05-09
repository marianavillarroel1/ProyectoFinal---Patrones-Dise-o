using ProyectoFinalConsole.Observer;
using ProyectoFinalConsole.Visitor;
using System;

namespace ProyectoFinalConsole.AbstractFactory
{
    internal class ConcreteHelicopteroMilitar : IHelicoptero
    {
        public ConcreteHelicopteroMilitar()
            : base("Sikorsky", "UH-60 Black Hawk", "MIL-H001", 1500.0)
        {
        }

        public override void InterpretarAlerta(string codigoAlerta)
        {
            switch (codigoAlerta)
            {
                case "M5":
                    Console.WriteLine("HELICÓPTERO MILITAR: Evacúa heridos en misión táctica.");
                    break;
                case "C2":
                    Console.WriteLine("HELICÓPTERO MILITAR: Cambia zona de patrullaje.");
                    break;
                default:
                    Console.WriteLine("HELICÓPTERO MILITAR: Mantiene operaciones.");
                    break;
            }
        }

        public override void aceptarVisitor(IEstadisticaVisitor visitor)
        {
            //visitor.visitarHelicopteroMilitar(this);
        }
    }
}
