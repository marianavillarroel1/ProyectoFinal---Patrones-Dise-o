using System;

namespace SimulacionAeronaves.Mediator
{
    public class ConcreteDronMilitar : IDron
    {
        private IMediatorDron mediator;
        private string nombre;

        public ConcreteDronMilitar(string nombre)
        {
            this.nombre = nombre;
        }

        public void Volar()
        {
            Console.WriteLine($"[DronMilitar '{nombre}'] Está volando.");
        }

        public void AsignarMediator(IMediatorDron mediator)
        {
            this.mediator = mediator;
        }

        public void SolicitarReasignacionRuta()
        {
            Console.WriteLine($"[DronMilitar '{nombre}'] Solicita reasignación de ruta.");
            mediator.ReasignarRuta(this);
        }

        public void SolicitarConfirmacionPatrullaje()
        {
            Console.WriteLine($"[DronMilitar '{nombre}'] Solicita confirmación de patrullaje.");
            mediator.ConfirmarPatrullaje(this);
        }

        public void SolicitarReubicacionVigilancia()
        {
            Console.WriteLine($"[DronMilitar '{nombre}'] Solicita reubicación de vigilancia.");
            mediator.ReubicarVigilancia(this);
        }

        public string GetNombre()
        {
            return nombre;
        }
    }
}
