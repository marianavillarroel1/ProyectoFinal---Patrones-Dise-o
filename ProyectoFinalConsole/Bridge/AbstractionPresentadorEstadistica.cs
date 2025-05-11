using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalConsole.Bridge
{
    public abstract class AbstractionPresentadorEstadistica
    {
        protected IFormatoSalida formato;

        public void SetFormato(IFormatoSalida formato)
        {
            this.formato = formato;
        }

        public abstract void MostrarEstadistica(string resultado);
    }
}