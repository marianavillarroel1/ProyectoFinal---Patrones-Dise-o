using SimulacionAeronaves.Proxy;
using System;

class Program
{
    static void Main(string[] args)
    {
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
