using System;
using System.Collections.Generic;

namespace ProyectoFinalConsole.Proxy
{
    internal class Proxy : ISistema
    {
        private SistemaReal sistemaReal;
        private Dictionary<string, string> usuariosValidos;

        public Proxy()
        {
            sistemaReal = new SistemaReal();

            usuariosValidos = new Dictionary<string, string>()
            {
                { "isa", "12345" },
                { "majo", "12345" },
                { "mari", "12345" },
                { "vale", "12345" },
                { "admin", "admin123" }
            };
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

        private bool validarCredenciales(string usuario, string contrasena)
        {
            return usuariosValidos.ContainsKey(usuario) && usuariosValidos[usuario] == contrasena;
        }
    }
}
