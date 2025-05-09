using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalConsole.Proxy
{
    internal interface ISistema
    {
        bool acceder(string usuario, string contrasena);
    }
}
