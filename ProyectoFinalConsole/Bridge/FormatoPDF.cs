using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalConsole.Bridge
{
    public class FormatoPDF : IFormatoSalida
    {
        public void PresentarEstadistica(string resultado)
        {
            Console.WriteLine("=== Simulación de salida PDF ===");
            Console.WriteLine("[PDF] -> " + resultado);
        }
    }
}