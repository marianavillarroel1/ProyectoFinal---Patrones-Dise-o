using SimulacionAeronaves.Proxy;
using System;
using SimulacionAeronaves.Mediator;
using SimulacionAeronaves.Composite;


class Program
{
    static void Main(string[] args)
    {
        //MEDIATOR
        CentralDeMandoMediator central = new CentralDeMandoMediator();

        IDron dron1 = new ConcreteDronCivil("Alpha");
        IDron dron2 = new ConcreteDronMilitar("Bravo");

        central.RegistrarDron(dron1);
        central.RegistrarDron(dron2);

        dron1.Volar();
        dron1.SolicitarReasignacionRuta();
        dron1.SolicitarConfirmacionPatrullaje();

        dron2.Volar();
        dron2.SolicitarReubicacionVigilancia();
        //

        //COMPOSITE
        // Crear rutas simples
        var ruta1 = new RutaSimple("La Paz", 100);
        var ruta2 = new RutaSimple("Cochabamba", 120);
        var ruta3 = new RutaSimple("Santa Cruz", 150);

        // Crear ruta compuesta
        var rutaCompuesta = new RutaCompuesta();
        rutaCompuesta.AgregarTramo(ruta1);
        rutaCompuesta.AgregarTramo(ruta2);
        rutaCompuesta.AgregarTramo(ruta3);
        //
        
        ISistema sistema = new Proxy();

        Console.WriteLine("=== SISTEMA DE SIMULACION DE AERONAVES ===");

        Console.WriteLine("- Proxy de acceso. -");

        bool continuar = true; 

        while (continuar)
        {
            Console.Write("Ingrese su usuario: ");
            string usuario = Console.ReadLine();

            Console.Write("Ingrese su contraseña: ");
            string contrasena = Console.ReadLine();

            bool accesoConcedido = sistema.acceder(usuario, contrasena);

            if (accesoConcedido)
            {
                Console.WriteLine(">>> Ingreso exitoso.");
                //Display Menu
            }
            else
            {
                Console.WriteLine(">>> No se pudo ingresar al sistema.");
                Console.Write("¿Desea intentar nuevamente? (s/n): ");
                string respuesta = Console.ReadLine().ToLower();

                if (respuesta != "s")
                {
                    continuar = false;
                    Console.WriteLine(">>> Saliendo del sistema...");
                }
            }
        }
    }
}
