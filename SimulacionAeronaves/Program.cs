using SimulacionAeronaves.Proxy;
using System;

class Program
{
    static void Main(string[] args)
    {
        ISistema sistema = new Proxy();

        Console.WriteLine("=== SISTEMA DE ACCESO ===");

        Console.Write("Ingrese su usuario: ");
        string usuario = Console.ReadLine();

        Console.Write("Ingrese su contraseña: ");
        string contrasena = Console.ReadLine();

        bool accesoConcedido = sistema.acceder(usuario, contrasena);

        if (accesoConcedido)
        {
            Console.WriteLine(">>> Ingreso exitoso.");
        }
        else
        {
            Console.WriteLine(">>> No se pudo ingresar al sistema.");
        }

        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }
}
