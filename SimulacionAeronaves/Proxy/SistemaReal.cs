using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacionAeronaves.Proxy
{
    public class SistemaReal : ISistema
    {
        public bool acceder(string usuario, string contrasena)
        {
            Console.WriteLine($"Acceso concedido al sistema para el usuario: {usuario}");
            return true;
        }

        public bool verificarModulos()
        {
            Console.WriteLine("Verificando módulos del sistema...");
            return true;
        }
    }
}
