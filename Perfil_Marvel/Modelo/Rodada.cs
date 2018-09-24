using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfil_Marvel.Modelo
{
    public class Rodada
    {
        public bool finalizada { get; set; }
        public Perfil perfilDaRodada { get; set; }
        public List<Dica> dicasUtilizadas { get; set; }
        public Participante jogadorDaVez { get; set; }
        public Participante mediador { get; set; }

        public Rodada(Perfil perfilDaRodada, Participante jogadorDaVez, Participante mediador)
        {
            this.finalizada = false;
            this.perfilDaRodada = perfilDaRodada;
            this.jogadorDaVez = jogadorDaVez;
            this.mediador = mediador;
        }
        public void FinalizarRodada()
        {
            finalizada = true;
        }
        public void UtilizarDica(Dica dica)
        {
            dicasUtilizadas.Add(dica);
        }
    }
}
