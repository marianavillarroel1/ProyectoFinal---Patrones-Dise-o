using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalConsole.Bridge
{
    public class RefinedPresentacionEstadistica : AbstractionPresentadorEstadistica
    {
        public override void MostrarEstadistica(string resultado)
        {
            Console.WriteLine("Preparando presentación de estadística...");
            formato.PresentarEstadistica(resultado);
        }
    }
}
