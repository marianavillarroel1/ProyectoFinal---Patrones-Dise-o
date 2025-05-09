using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalConsole.Proxy
{
    internal class Proxy : ISistema
    {
        private SistemaReal sistemaReal;

        public Proxy()
        {
            sistemaReal = new SistemaReal();
        }

        public bool acceder(string usuario, string contrasena)
        {
            if (!validarCredenciales(usuario, contrasena))
            {
                Console.WriteLine("Acceso denegado: credenciales incorrectas.");
                return false;
            }

            if (!sistemaReal.verificarModulos())
            {
                Console.WriteLine("Acceso denegado: los módulos del sistema no están operativos.");
                return false;
            }

            return sistemaReal.acceder(usuario, contrasena);
        }

        public bool validarCredenciales(string usuario, string contrasena)
        {
            // Simulación de validación: por ejemplo, usuario = admin y contraseña = 1234
            return usuario == "admin" && contrasena == "1234";
        }
    }
}
