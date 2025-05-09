using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalConsole.Observer
{
    internal class TorreDeControlSubject
    {
        private List<AbstractAeronaveBase> observadores = new List<AbstractAeronaveBase>();

        public void suscribir(AbstractAeronaveBase observer)
        {
            if (!observadores.Contains(observer))
            {
                observadores.Add(observer);
                Console.WriteLine($"{observer.Modelo} se ha suscrito a la Torre de Control.");
            }
        }


        public void darDeBaja(AbstractAeronaveBase observer)
        {
            if (observadores.Remove(observer))
            {
                Console.WriteLine($"{observer.Modelo} se ha dado de baja de la Torre de Control.");
            }
        }


        public void emitirAlerta(string codigo)
        {
            Console.WriteLine($"\n Torre de Control emite ALERTA: {codigo}");
            foreach (var observador in observadores)
            {
                observador.actualizar(codigo);
            }
        }
    }
}
