using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacionAeronaves.Proxy
{
    internal interface ISistema
    {
        bool acceder(string usuario, string contrasena);
    }
}
