using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbFactory
{
    internal interface IDron
    {
        void Volar();
        void AsignarMediator(IMediatorDron mediator);
        void SolicitarReasignacionRuta();
        void SolicitarConfirmacionPatrullaje();
        void SolicitarReubicacionVigilancia();
        string GetNombre();
    }
}
