using ProyectoFinalConsole.Observer;
using System;

namespace ProyectoFinalConsole.AbstractFactory
{
    internal abstract class IHelicoptero : AbstractAeronaveBase
    {
        public IHelicoptero(string fabricante, string modelo, string placa, double costoVuelo)
            : base(fabricante, modelo, placa, costoVuelo)
        {
        }

        public override void InterpretarAlerta(string codigoAlerta)
        {
            Console.WriteLine($"🚁 HELICÓPTERO ({Modelo}): Alerta recibida - {codigoAlerta}");
        }
    }
}
