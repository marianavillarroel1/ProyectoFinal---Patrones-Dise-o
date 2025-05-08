using System;

namespace SimulacionAeronaves.Mediator
{
    public class ConcreteDronCivil : IDron
    {
        private IMediatorDron mediator;
        private string nombre;

        public ConcreteDronCivil(string nombre)
        {
            this.nombre = nombre;
        }

        public void Volar()
        {
            Console.WriteLine($"[DronCivil '{nombre}'] Está volando.");
        }

        public void AsignarMediator(IMediatorDron mediator)
        {
            this.mediator = mediator;
        }

        public void SolicitarReasignacionRuta()
        {
            Console.WriteLine($"[DronCivil '{nombre}'] Solicita reasignación de ruta.");
            mediator.ReasignarRuta(this);
        }

        public void SolicitarConfirmacionPatrullaje()
        {
            Console.WriteLine($"[DronCivil '{nombre}'] Solicita confirmación de patrullaje.");
            mediator.ConfirmarPatrullaje(this);
        }

        public void SolicitarReubicacionVigilancia()
        {
            Console.WriteLine($"[DronCivil '{nombre}'] Solicita reubicación de vigilancia.");
            mediator.ReubicarVigilancia(this);
        }

        public string GetNombre()
        {
            return nombre;
        }
    }
}
