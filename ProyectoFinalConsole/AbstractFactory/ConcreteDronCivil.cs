using ProyectoFinalConsole.Mediator;
using ProyectoFinalConsole.Observer;
using ProyectoFinalConsole.Visitor;
using System;

namespace ProyectoFinalConsole.AbstractFactory
{
    internal class ConcreteDronCivil : IDron
    {
        private string nombre;

        public ConcreteDronCivil(string nombre)
            : base("DJI", "Phantom 4", nombre, 500.0)
        {
            this.nombre = nombre;
        }

        public override string GetNombre()
        {
            return nombre;
        }

        public override void InterpretarAlerta(string codigoAlerta)
        {
            switch (codigoAlerta)
            {
                case "A1":
                    Console.WriteLine($"DRON CIVIL ({nombre}): Se eleva para evitar área con mal clima.");
                    break;
                case "C2":
                    Console.WriteLine($"DRON CIVIL ({nombre}): Advierte cruce no autorizado a torre.");
                    break;
                default:
                    Console.WriteLine($"DRON CIVIL ({nombre}): Continúa patrullaje.");
                    break;
            }
        }

        public override void SolicitarConfirmacionPatrullaje()
        {
            Console.WriteLine($"DRON CIVIL ({nombre}): Solicita confirmación de patrullaje");
            mediator?.ConfirmarPatrullaje(this);
        }

        public override void SolicitarReasignacionRuta()
        {
            Console.WriteLine($"DRON CIVIL ({nombre}): Solicita reasignación de ruta");
            mediator?.ReasignarRuta(this);
        }

        public override void SolicitarReubicacionVigilancia()
        {
            Console.WriteLine($"DRON CIVIL ({nombre}): Solicita reubicación de vigilancia");
            mediator?.ReubicarVigilancia(this);
        }

        public override void aceptarVisitor(IEstadisticaVisitor visitor)
        {
            //visitor.visitarDronCivil(this);
        }
    }
}
