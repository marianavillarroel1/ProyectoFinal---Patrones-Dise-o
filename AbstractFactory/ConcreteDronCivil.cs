using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalConsole.AbstractFactory
{
    internal class ConcreteDronCivil : IDron
    {
        public override string GetNombre()
        {
            return "";
        }

        public override void InterpretarAlerta(string codigoAlerta)
        {
            //Logica
        }

        public override void SolicitarConfirmacionPatrullaje()
        {
            //Logica
        }

        public override void SolicitarReasignacionRuta()
        {
            //Logica;
        }

        public override void SolicitarReubicacionVigilancia()
        {
            //Logica
        }
    }
}
