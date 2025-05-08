using System;
namespace SimulacionAeronaves.Composite
{
    public class RutaSimple : ComponentRuta
    {
        private string destino;
        private double precio;

        public RutaSimple(string destino, double precio)
        {
            this.destino = destino;
            this.precio = precio;
        }

        public override string GetDestino()
        {
            Console.WriteLine($"Destino de ruta simple: {destino}");
            return destino;
        }

        public override double GetPrecio()
        {
            Console.WriteLine($"Precio de ruta simple a {destino}: {precio}");
            return precio;
        }
    }
}