using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfil_Marvel.Modelo
{
    [Serializable]
    public class Perfil
    {
        public string nome { get; set; }
        public string categoria { get; set; }
        public List<Dica> dicas { get; set; }

        public Perfil()
        {
            this.nome = "";
            this.categoria = "";
            this.dicas = null;
        }

        public Perfil(string nome, string categoria, List<Dica> dicas)
        {
            this.nome = nome;
            this.categoria = categoria;
            this.dicas = dicas;
        }
    }
}
