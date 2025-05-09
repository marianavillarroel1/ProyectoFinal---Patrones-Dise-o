using ProyectoFinalConsole.Observer;
using ProyectoFinalConsole.Visitor;
using System;

namespace ProyectoFinalConsole.AbstractFactory
{
    internal class ConcreteAvionPrivadoCivil : IAvionPrivado
    {
        public ConcreteAvionPrivadoCivil()
            : base("Cessna", "Citation XLS", "CIV-P001", 1000.0)
        {
        }

        public override void InterpretarAlerta(string codigoAlerta)
        {
            switch (codigoAlerta)
            {
                case "A1":
                    Console.WriteLine("AVIÓN PRIVADO CIVIL: Desvía ruta por mal clima.");
                    //Pedir mas info
                    break;
                case "C2":
                    Console.WriteLine("AVIÓN PRIVADO CIVIL: Informa cruce no autorizado a torre.");
                    break;
                default:
                    Console.WriteLine("AVIÓN PRIVADO CIVIL: Procede con precaución.");
                    break;
            }
        }

        public override void aceptarVisitor(IEstadisticaVisitor visitor)
        {
            //visitor.visitarAvionPrivadoCivil(this);
        }
    }
}
