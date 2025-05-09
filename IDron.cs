using ProyectoFinalConsole.Mediator;
using ProyectoFinalConsole.Observer;
using System;

namespace ProyectoFinalConsole.AbstractFactory
{
    internal abstract class IDron : AbstractAeronaveBase
    {
        protected IMediatorDron? mediator;

        public IDron(string fabricante, string modelo, string placa, double costoVuelo)
            : base(fabricante, modelo, placa, costoVuelo)
        {
        }

        public void asignarMediator(IMediatorDron mediator)
        {
            this.mediator = mediator;
        }

        public abstract void SolicitarReasignacionRuta();
        public abstract void SolicitarConfirmacionPatrullaje();
        public abstract void SolicitarReubicacionVigilancia();
        public abstract string GetNombre();

        public override void InterpretarAlerta(string codigoAlerta)
        {
            Console.WriteLine($"DRON ({Modelo}): Alerta recibida - {codigoAlerta}");
        }
    }
}
