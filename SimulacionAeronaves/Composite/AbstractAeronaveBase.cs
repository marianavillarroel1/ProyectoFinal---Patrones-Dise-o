using System;
namespace SimulacionAeronaves.Composite
{

    public abstract class AbstractAeronaveBase
    {
        public string Fabricante { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public double CostoVuelo { get; set; }
        public int VuelosRealizados { get; set; }

        protected ComponentRuta rutaAsignada;

        public void AsignarRuta(ComponentRuta ruta)
        {
            rutaAsignada = ruta;
            Console.WriteLine("Ruta asignada a la aeronave.");
        }

        public void Volar()
        {
            if (rutaAsignada == null)
            {
                Console.WriteLine("No hay ruta asignada. No se puede volar.");
                return;
            }

            Console.WriteLine($"Volando hacia {rutaAsignada.GetDestino()} con un costo de {rutaAsignada.GetPrecio()}.");
            VuelosRealizados++;
        }
    }
}
