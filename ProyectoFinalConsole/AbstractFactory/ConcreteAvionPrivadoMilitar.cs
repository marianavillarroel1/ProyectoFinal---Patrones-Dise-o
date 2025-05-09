using ProyectoFinalConsole.Observer;
using ProyectoFinalConsole.Visitor;
using System;

namespace ProyectoFinalConsole.AbstractFactory
{
    internal class ConcreteAvionPrivadoMilitar : IAvionPrivado
    {
        public ConcreteAvionPrivadoMilitar()
            : base("Gulfstream", "G500 Tactical", "MIL-P001", 2000.0)
        {
        }

        public override void InterpretarAlerta(string codigoAlerta)
        {
            switch (codigoAlerta)
            {
                case "A1":
                    Console.WriteLine("AVIÓN PRIVADO MILITAR: Cambia altitud por mal clima.");
                    break;
                case "C2":
                    Console.WriteLine("AVIÓN PRIVADO MILITAR: Aplica protocolo defensivo.");
                    break;
                default:
                    Console.WriteLine("AVIÓN PRIVADO MILITAR: Mantiene comunicación táctica.");
                    break;
            }
        }

        public override void aceptarVisitor(IEstadisticaVisitor visitor)
        {
            //visitor.visitarAvionPrivadoMilitar(this);
        }
    }
}
