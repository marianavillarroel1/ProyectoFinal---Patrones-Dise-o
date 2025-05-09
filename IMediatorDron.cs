using ProyectoFinalConsole.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalConsole.Mediator
{
    internal interface IMediatorDron
    {
        void ReasignarRuta(IDron dron);
        void ConfirmarPatrullaje(IDron dron);
        void ReubicarVigilancia(IDron dron);
    }
}
