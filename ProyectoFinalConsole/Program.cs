using ProyectoFinalConsole.AbstractFactory;
using ProyectoFinalConsole.Composite;
using ProyectoFinalConsole.Mediator;
using ProyectoFinalConsole.Observer;
using ProyectoFinalConsole.Proxy;
using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;

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

            TorreDeControlSubject torre = new TorreDeControlSubject();
            List<AbstractAeronaveBase> aeronaves = new List<AbstractAeronaveBase>();
            CentralDeMandoMediator central = new CentralDeMandoMediator();

            bool salirPrograma = false;

            while (!salirPrograma)
            {
                Console.WriteLine("\n----- MENÚ PRINCIPAL -----");
                Console.WriteLine("1. Crear aeronave");
                Console.WriteLine("2. Subscribir o Dar de Baja aeronave a Torre Control");
                Console.WriteLine("3. Enviar alerta por Torre de Control");
                Console.WriteLine("4. Asignar operaciones a drones");
                Console.WriteLine("5. Agregar nueva ruta");
                Console.WriteLine("7. Salir");
                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        MenuCrearAeronave(aeronaves);
                        break;
                    case "2":
                        MenuSuscripcionesTorre(aeronaves, torre);
                        break;
                    case "4":
                        MenuOperacionesDron(aeronaves, central);
                        break;
                    case "7":
                        salirPrograma = true;
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }
        static void MenuCrearAeronave(List<AbstractAeronaveBase> aeronaves)
        {
            bool salirFamilia = false;

            while (!salirFamilia)
            {
                Console.WriteLine("\n--- Seleccione tipo de aeronave ---");
                Console.WriteLine("1. Civil");
                Console.WriteLine("2. Militar");
                Console.WriteLine("3. Salir");
                Console.Write("Opción: ");
                string tipo = Console.ReadLine();

                AbstractAeronaveFactory fabrica = null;

                switch (tipo)
                {
                    case "1":
                        fabrica = new ConcreteFabricaCivil();
                        break;
                    case "2":
                        fabrica = new ConcreteFabricaMilitar();
                        break;
                    case "3":
                        salirFamilia = true;
                        continue;
                    default:
                        Console.WriteLine("Opción no válida.");
                        continue;
                }

                bool salirTipo = false;
                while (!salirTipo)
                {
                    Console.WriteLine("\n--- Crear aeronave tipo " + (tipo == "1" ? "Civil" : "Militar") + " ---");
                    Console.WriteLine("1. Avión");
                    Console.WriteLine("2. Avión Privado");
                    Console.WriteLine("3. Helicóptero");
                    Console.WriteLine("4. Dron");
                    Console.WriteLine("5. Salir");
                    Console.Write("Opción: ");
                    string opcionAeronave = Console.ReadLine();

                    switch (opcionAeronave)
                    {
                        case "1":
                            aeronaves.Add(fabrica.CrearAvion());
                            Console.WriteLine("Avión creado.");
                            break;
                        case "2":
                            aeronaves.Add(fabrica.CrearAvionPrivado());
                            Console.WriteLine("Avión Privado creado.");
                            break;
                        case "3":
                            aeronaves.Add(fabrica.CrearHelicoptero());
                            Console.WriteLine("Helicóptero creado.");
                            break;
                        case "4":
                            Console.Write("Nombre del dron: ");
                            string nombre = Console.ReadLine();
                            aeronaves.Add(fabrica.CrearDron(nombre));
                            Console.WriteLine($"Dron '{nombre}' creado.");
                            break;
                        case "5":
                            salirTipo = true;
                            break;
                        default:
                            Console.WriteLine("Opción no válida.");
                            break;
                    }
                }
            }
        }

        static void MenuSuscripcionesTorre(List<AbstractAeronaveBase> aeronaves, TorreDeControlSubject torre)
        {
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("\n--- Gestión de Torre de Control ---");
                Console.WriteLine("1. Subscribir aeronave");
                Console.WriteLine("2. Dar de baja aeronave");
                Console.WriteLine("3. Salir");
                Console.Write("Opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        SubscribirAeronave(torre, aeronaves);
                        break;
                    case "2":
                        DarDeBajaAeronave(torre);
                        break;
                    case "3":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }

        static void SubscribirAeronave(TorreDeControlSubject torre, List<AbstractAeronaveBase> aeronaves)
        {
            var disponibles = torre.ObtenerNoSuscritas(aeronaves);

            if (disponibles.Count == 0)
            {
                Console.WriteLine("\nNo hay aeronaves disponibles para subscribir.");
                return;
            }

            Console.WriteLine("\n--- Aeronaves disponibles para suscripción ---");
            foreach (var a in disponibles)
                Console.WriteLine($"- {a.Modelo}");

            Console.Write("Ingrese el modelo de la aeronave a subscribir (o 'salir'): ");
            string entrada = Console.ReadLine();

            if (entrada.ToLower() == "salir") return;

            var aeronave = disponibles.Find(a => a.Modelo.Equals(entrada, StringComparison.OrdinalIgnoreCase));

            if (aeronave != null)
            {
                torre.suscribir(aeronave);
            }
            else
            {
                Console.WriteLine("No se encontró la aeronave o ya está suscrita.");
            }
        }


        static void DarDeBajaAeronave(TorreDeControlSubject torre)
        {
            var suscritas = torre.ObtenerSuscritas();

            if (suscritas.Count == 0)
            {
                Console.WriteLine("\nNo hay aeronaves suscritas actualmente.");
                return;
            }

            Console.WriteLine("\n--- Aeronaves actualmente suscritas ---");
            foreach (var a in suscritas)
                Console.WriteLine($"- {a.Modelo}");

            Console.Write("Ingrese el modelo de la aeronave a dar de baja (o 'salir'): ");
            string entrada = Console.ReadLine();

            if (entrada.ToLower() == "salir") return;

            var aeronave = suscritas.Find(a => a.Modelo.Equals(entrada, StringComparison.OrdinalIgnoreCase));

            if (aeronave != null)
            {
                torre.darDeBaja(aeronave);
            }
            else
            {
                Console.WriteLine("No se encontró la aeronave suscrita con ese modelo.");
            }
        }

        static void MenuOperacionesDron(List<AbstractAeronaveBase> aeronaves, CentralDeMandoMediator central)
        {
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("\n--- Operaciones de Drones ---");
                Console.WriteLine("1. Actualizar registro de drones");
                Console.WriteLine("2. Asignar operación a drones");
                Console.WriteLine("3. Salir");
                Console.Write("Opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        ActualizarRegistroDrones(aeronaves, central);
                        break;
                    case "2":
                        MenuAsignarOperacionDrones(aeronaves);
                        break;
                    case "3":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }


        static void ActualizarRegistroDrones(List<AbstractAeronaveBase> aeronaves, CentralDeMandoMediator central)
        {
            Console.WriteLine("\nRegistrando drones en la central de mando...");

            foreach (var a in aeronaves)
            {
                if (a is IDron dron)
                {
                    central.RegistrarDron(dron);
                    Console.WriteLine($"Dron {a.Modelo} registrado.");
                }
            }
        }


        static void MenuAsignarOperacionDrones(List<AbstractAeronaveBase> aeronaves)
        {
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("\n--- Asignar Operación ---");
                Console.WriteLine("1. Reasignación de rutas");
                Console.WriteLine("2. Confirmación de patrullaje");
                Console.WriteLine("3. Reubicación de vigilancia");
                Console.WriteLine("4. Salir");
                Console.Write("Opción: ");
                string opcion = Console.ReadLine();

                var drones = aeronaves.Where(a => a is IDron).Cast<IDron>().ToList();

                if (drones.Count == 0)
                {
                    Console.WriteLine("No hay drones disponibles.");
                    return;
                }

                switch (opcion)
                {
                    case "1":
                        foreach (var d in drones)
                            d.SolicitarReasignacionRuta();
                        break;
                    case "2":
                        foreach (var d in drones)
                            d.SolicitarConfirmacionPatrullaje();
                        break;
                    case "3":
                        foreach (var d in drones)
                            d.SolicitarReubicacionVigilancia();
                        break;
                    case "4":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }

        /*Console.WriteLine("Iniciando sistema...");

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
    */
    }
}