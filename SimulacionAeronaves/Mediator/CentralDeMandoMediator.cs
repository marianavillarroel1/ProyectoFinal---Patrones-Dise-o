using System;
using System.Collections.Generic;


namespace SimulacionAeronaves.Mediator
{
    public class CentralDeMandoMediator : IMediatorDron
    {
        private List<IDron> listaDrones = new List<IDron>();

        public void RegistrarDron(IDron dron)
        {
            listaDrones.Add(dron);
            dron.AsignarMediator(this);
            Console.WriteLine($"[CentralDeMando] Dron '{dron.GetNombre()}' registrado.");
        }

        public void ReasignarRuta(IDron dron)
        {
            Console.WriteLine($"[CentralDeMando] Reasignando ruta para el dron '{dron.GetNombre()}'.");
        }

        public void ConfirmarPatrullaje(IDron dron)
        {
            Console.WriteLine($"[CentralDeMando] Confirmando patrullaje del dron '{dron.GetNombre()}'.");
        }

        public void ReubicarVigilancia(IDron dron)
        {
            Console.WriteLine($"[CentralDeMando] Reubicando vigilancia del dron '{dron.GetNombre()}'.");
        }
    }
}
