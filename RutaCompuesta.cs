using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalConsole.Composite
{
    public class RutaCompuesta : ComponentRuta
    {
        private List<ComponentRuta> tramos = new List<ComponentRuta>();

        public void AgregarTramo(ComponentRuta ruta)
        {
            tramos.Add(ruta);
            Console.WriteLine("Tramo agregado a ruta compuesta.");
        }

        public void EliminarTramo(ComponentRuta ruta)
        {
            tramos.Remove(ruta);
            Console.WriteLine("Tramo eliminado de ruta compuesta.");
        }

        public override string GetDestino()
        {
            if (tramos.Count == 0)
            {
                Console.WriteLine("Ruta compuesta sin tramos.");
                return "Sin destino";
            }

            string destinoFinal = tramos[tramos.Count - 1].GetDestino();
            Console.WriteLine($"Destino final de ruta compuesta: {destinoFinal}");
            return destinoFinal;
        }

        public override double GetPrecio()
        {
            double total = CalcularPrecioTotal();
            Console.WriteLine($"Precio total de ruta compuesta: {total}");
            return total;
        }

        public double CalcularPrecioTotal()
        {
            double suma = 0;
            foreach (var tramo in tramos)
            {
                suma += tramo.GetPrecio();
            }
            return suma;
        }

        public override string ObtenerDescripcion()
        {
            string descripcion = "Ruta compuesta:\n";

            foreach (var tramo in tramos)
            {
                descripcion += " - " + tramo.ObtenerDescripcion() + "\n";
            }

            descripcion += "Precio total: " + CalcularPrecioTotal();
            return descripcion;
        }


    }
}
