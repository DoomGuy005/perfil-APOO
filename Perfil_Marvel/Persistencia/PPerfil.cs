using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfil_Marvel.Persistencia
{
    class PPerfil : Arquivo<List<Perfil_Marvel.Modelo.Perfil>>
    {
        public PPerfil() : base("lperfil.xml")
        {
        }
    }
}
