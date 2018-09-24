using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfil_Marvel.Persistencia
{
    class PDica : Arquivo<List<Perfil_Marvel.Modelo.Dica>>
    {
        public PDica() : base("ldica.xml")
        {
        }
    }
}
