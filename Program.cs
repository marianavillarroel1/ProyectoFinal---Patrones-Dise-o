using ProyectoFinalConsole.AbstractFactory;
using ProyectoFinalConsole.Composite;
using ProyectoFinalConsole.Mediator;
using ProyectoFinalConsole.Observer;
using ProyectoFinalConsole.Proxy;
using System;
using System.Collections.Generic;

namespace ProyectoFinalConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando sistema...");

            // Proxy

            ISistema sistema = new Proxy.Proxy();
            Console.Write("Usuario: ");
            string usuario = Console.ReadLine();
            Console.Write("Contraseña: ");
            string contrasena = Console.ReadLine();

            if (!sistema.acceder(usuario, contrasena))
            {
                Console.WriteLine("El programa se cerrará.");
                return;
            }

            Console.WriteLine("\n -----Simulacion-----");

            // Abstract Factory

            AbstractAeronaveFactory fabrica = new ConcreteFabricaCivil();
            List<AbstractAeronaveBase> aeronaves = new List<AbstractAeronaveBase>();

            var avion = fabrica.CrearAvion();
            var avionPrivado = fabrica.CrearAvionPrivado();
            var helicoptero = fabrica.CrearHelicoptero();
            var dron1 = fabrica.CrearDron("Dron1");
            var dron2 = fabrica.CrearDron("Dron2");
            var dron3 = fabrica.CrearDron("Dron3");

            aeronaves.Add(avion);
            aeronaves.Add(avionPrivado);
            aeronaves.Add(helicoptero);
            aeronaves.Add(dron1);
            aeronaves.Add(dron2);
            aeronaves.Add(dron3);

            // Observer

            Console.WriteLine("\nSuscribiendo aeronaves a la torre de control...");
            var torre = new TorreDeControlSubject();
            foreach (var aeronave in aeronaves)
                torre.suscribir(aeronave);

            // Mediator

            Console.WriteLine("\n Registrando drones en la central de mando...");
            var central = new CentralDeMandoMediator();
            central.RegistrarDron((IDron)dron1);
            central.RegistrarDron((IDron)dron2);
            central.RegistrarDron((IDron)dron3);

            // Composite

            Console.WriteLine("\n Asignando rutas...");
            var ruta1 = new RutaSimple("Santa Cruz", 300);
            var ruta2 = new RutaSimple("Cochabamba", 200);
            var rutaCompuesta = new RutaCompuesta();
            rutaCompuesta.AgregarTramo(ruta1);
            rutaCompuesta.AgregarTramo(ruta2);

            avion.asignarRuta(rutaCompuesta);
            avionPrivado.asignarRuta(ruta1);
            helicoptero.asignarRuta(ruta2);

            // Simulación de vuelos
            Console.WriteLine("\n Simulando vuelos...");
            foreach (var aeronave in aeronaves)
                aeronave.volar();

            // Emisión de alerta
            Console.WriteLine("\nEmisión de alerta desde la torre...");
            torre.emitirAlerta("M5");

            // Mediador
            Console.WriteLine("\nDrones...");
            ((IDron)dron1).SolicitarConfirmacionPatrullaje();
            ((IDron)dron2).SolicitarReasignacionRuta();
            ((IDron)dron3).SolicitarReubicacionVigilancia();

            Console.WriteLine("\nSimulación completada.");
        }
    }
}
