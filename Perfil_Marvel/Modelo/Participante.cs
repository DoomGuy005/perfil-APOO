using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfil_Marvel.Modelo
{
    public class Participante
    {
        public string nome { get; set; }
        public int ordem { get; set; }
        public int placar { get; set; }

        public Participante(string n)
        {
            this.nome = n;
            this.placar = 0;
            this.ordem = 0;
        }        
    }
}
