using ProyectoFinalConsole.Observer;
using ProyectoFinalConsole.Visitor;
using System;

namespace ProyectoFinalConsole.AbstractFactory
{
    internal class ConcreteAvionCivil : IAvion
    {
        public ConcreteAvionCivil()
            : base("Airbus", "A320", "CIV-A001", 1200.0)
        {
        }

        public override void InterpretarAlerta(string codigoAlerta)
        {
            switch (codigoAlerta)
            {
                case "A1":
                    Console.WriteLine("AVIÓN CIVIL: Aplaza despegue por condiciones meteorológicas.");
                    break;
                case "B3":
                    Console.WriteLine("AVIÓN CIVIL: En espera por cierre de pista.");
                    break;
                case "M5":
                    Console.WriteLine("AVIÓN CIVIL: Transporta pasajero en emergencia médica.");
                    break;
                default:
                    Console.WriteLine("AVIÓN CIVIL: Sin acción requerida para la alerta.");
                    break;
            }
        }

        public override void aceptarVisitor(IEstadisticaVisitor visitor)
        {
            //visitor.visitarAvionCivil(this);
        }
    }
}
