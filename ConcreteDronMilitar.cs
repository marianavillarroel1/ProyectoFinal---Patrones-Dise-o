using ProyectoFinalConsole.Mediator;
using ProyectoFinalConsole.Observer;
using ProyectoFinalConsole.Visitor;
using System;

namespace ProyectoFinalConsole.AbstractFactory
{
    internal class ConcreteDronMilitar : IDron
    {
        private string nombre;

        public ConcreteDronMilitar(string nombre)
            : base("General Atomics", "MQ-9 Reaper", nombre, 800.0)
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
                    Console.WriteLine($"DRON MILITAR ({nombre}): Se mantiene en vuelo estacionario por tormenta.");
                    break;
                case "M5":
                    Console.WriteLine($"DRON MILITAR ({nombre}): Realiza reconocimiento de emergencia.");
                    break;
                default:
                    Console.WriteLine($"DRON MILITAR ({nombre}): Continúa vigilancia.");
                    break;
            }
        }

        public override void SolicitarConfirmacionPatrullaje()
        {
            Console.WriteLine($"DRON MILITAR ({nombre}): Solicita confirmación de patrullaje");
            mediator?.ConfirmarPatrullaje(this);
        }

        public override void SolicitarReasignacionRuta()
        {
            Console.WriteLine($"DRON MILITAR ({nombre}): Solicita reasignación de ruta");
            mediator?.ReasignarRuta(this);
        }

        public override void SolicitarReubicacionVigilancia()
        {
            Console.WriteLine($"DRON MILITAR ({nombre}): Solicita reubicación de vigilancia");
            mediator?.ReubicarVigilancia(this);
        }

        public override void aceptarVisitor(IEstadisticaVisitor visitor)
        {
            //visitor.visitarDronMilitar(this);
        }
    }
}
