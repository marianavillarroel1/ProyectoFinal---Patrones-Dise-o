using ProyectoFinalConsole.Observer;
using System;

namespace ProyectoFinalConsole.AbstractFactory
{
    internal abstract class IAvion : AbstractAeronaveBase
    {
        public IAvion(string fabricante, string modelo, string placa, double costoVuelo)
            : base(fabricante, modelo, placa, costoVuelo)
        {
        }

        public override void InterpretarAlerta(string codigoAlerta)
        {
            Console.WriteLine($"AVION ({Modelo}): Alerta recibida - {codigoAlerta}");
        }
    }
}
