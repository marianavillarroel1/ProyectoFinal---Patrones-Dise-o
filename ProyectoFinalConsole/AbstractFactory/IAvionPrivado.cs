using ProyectoFinalConsole.Observer;
using System;

namespace ProyectoFinalConsole.AbstractFactory
{
    internal abstract class IAvionPrivado : AbstractAeronaveBase
    {
        public IAvionPrivado(string fabricante, string modelo, string placa, double costoVuelo)
            : base(fabricante, modelo, placa, costoVuelo)
        {
        }

        public override void InterpretarAlerta(string codigoAlerta)
        {
            Console.WriteLine($"AVION PRIVADO ({Modelo}): Alerta recibida - {codigoAlerta}");
        }
    }
}
