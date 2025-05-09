using ProyectoFinalConsole.Mediator;
using ProyectoFinalConsole.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalConsole.AbstractFactory
{
    internal abstract class IDron : AbstractAeronaveBase
    {
        protected IMediatorDron mediator;

        public void asignarMediator(IMediatorDron mediator)
        {
            this.mediator = mediator;
        }
        public abstract void SolicitarReasignacionRuta();
        public abstract void SolicitarConfirmacionPatrullaje();
        public abstract void SolicitarReubicacionVigilancia();
        public abstract string GetNombre();
    }
}
