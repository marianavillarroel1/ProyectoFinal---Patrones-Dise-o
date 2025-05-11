using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinalConsole.Observer;
using ProyectoFinalConsole.Visitor;

namespace ProyectoFinalConsole.Bridge
{
    public class GestorEstadisticas
    {
        private IEstadisticaVisitor visitor;
        private AbstractionPresentadorEstadistica presentador;

        public void SeleccionarEstadistica(IEstadisticaVisitor visitor)
        {
            this.visitor = visitor;
            Console.WriteLine("Estadística seleccionada.");
        }

        public void SeleccionarFormato(AbstractionPresentadorEstadistica presentador)
        {
            this.presentador = presentador;
            Console.WriteLine("Formato de salida seleccionado.");
        }

        public void ProcesarEstadisticas(List<AbstractAeronaveBase> aeronaves)
        {
            Console.WriteLine("Procesando estadísticas...");
            foreach (var aeronave in aeronaves)
            {
                aeronave.Aceptar(visitor);
            }

            string resultado = visitor.ObtenerResultado();
            presentador.MostrarEstadistica(resultado);
        }
    }
}
