using ProyectoFinalConsole.Composite;
using ProyectoFinalConsole.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalConsole.Observer
{
    internal abstract class AbstractAeronaveBase
    {
        public string Fabricante { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public double CostoVuelo { get; set; }
        public int VuelosRealizados { get; private set; } = 0;

        public void volar()
        {
            VuelosRealizados++;

            // Selección aleatoria de maniobra
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

        public void aceptarVisitor(IEstadisticaVisitor visitor)
        {
            // Se implementará en las clases concretas
        }

        public void asignarRuta(ComponentRuta ruta)
        {
            // Implementación opcional según diagrama
        }
    }
}
