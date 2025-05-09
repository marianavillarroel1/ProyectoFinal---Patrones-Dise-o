using ProyectoFinalConsole.Observer;
using ProyectoFinalConsole.Visitor;
using System;

namespace ProyectoFinalConsole.AbstractFactory
{
    internal class ConcreteHelicopteroCivil : IHelicoptero
    {
        public ConcreteHelicopteroCivil()
            : base("Bell", "429 GlobalRanger", "CIV-H001", 950.0)
        {
        }

        public override void InterpretarAlerta(string codigoAlerta)
        {
            switch (codigoAlerta)
            {
                case "M5":
                    Console.WriteLine("HELICÓPTERO CIVIL: Activado como transporte médico de emergencia.");
                    break;
                case "B3":
                    Console.WriteLine("HELICÓPTERO CIVIL: Busca zona de aterrizaje alterna.");
                    break;
                default:
                    Console.WriteLine("HELICÓPTERO CIVIL: Mantiene patrón de vuelo.");
                    break;
            }
        }

        public override void aceptarVisitor(IEstadisticaVisitor visitor)
        {
            //visitor.visitarHelicopteroCivil(this);
        }
    }
}
