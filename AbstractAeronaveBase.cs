using ProyectoFinalConsole.Composite;
using ProyectoFinalConsole.Visitor;
using System;

namespace ProyectoFinalConsole.Observer
{
    internal abstract class AbstractAeronaveBase
    {
        public string Fabricante { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public double CostoVuelo { get; set; }
        public int VuelosRealizados { get; set; } = 0;

        protected ComponentRuta RutaAsignada { get; set; }

        public AbstractAeronaveBase(string fabricante, string modelo, string placa, double costoVuelo)
        {
            Fabricante = fabricante;
            Modelo = modelo;
            Placa = placa;
            CostoVuelo = costoVuelo;
        }


        public void volar()
        {
            VuelosRealizados++;

            string[] maniobras = { "Sobrevuelo", "Espera", "Aproximación de aterrizaje" };
            Random rnd = new Random();
            string maniobra = maniobras[rnd.Next(maniobras.Length)];

            Console.WriteLine($"✈️ {Modelo} realiza maniobra: {maniobra}. Total de vuelos: {VuelosRealizados}");
        }

        public void actualizar(string codigoAlerta)
        {
            Console.WriteLine($"{Modelo} recibió la alerta: {codigoAlerta}");
            InterpretarAlerta(codigoAlerta);
        }

        public abstract void InterpretarAlerta(string codigoAlerta);

        public abstract void aceptarVisitor(IEstadisticaVisitor visitor);

        public void asignarRuta(ComponentRuta ruta)
        {
            RutaAsignada = ruta;
            Console.WriteLine($"{Modelo} fue asignado a la ruta: {ruta.ObtenerDescripcion()}");
        }
    }
}
