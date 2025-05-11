using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalConsole.Bridge
{
    public class FormatoTextoPlano : IFormatoSalida
    {
        public void PresentarEstadistica(string resultado)
        {
            Console.WriteLine("=== Estadística en Texto Plano ===");
            Console.WriteLine(resultado);
        }
    }
}
