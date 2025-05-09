using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalConsole.Proxy
{
    internal class SistemaReal : ISistema
    {
        public bool acceder(string usuario, string contrasena)
        {
            Console.WriteLine($"Acceso concedido al sistema para el usuario: {usuario}");
            return true;
        }

        public bool verificarModulos()
        {
            Console.WriteLine("Verificando conexión con Torre de Control... OK");
            Console.WriteLine("Verificando servicio de rutas... OK");
            Console.WriteLine("Verificando módulo de estadísticas... OK");
            return true;
        }

    }
}
