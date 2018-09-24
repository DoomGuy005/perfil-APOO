using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfil_Marvel.Modelo
{
    public class Partida
    {
        public bool finalizada { get; set; }
        public int valorDaVitoria { get; set; }
        public List<Participante> participantes { get; set; }
        public int qtdParticipantes { get; set; }

        public Partida(List<Participante> participantes)
        {
            this.finalizada = false;
            this.participantes = participantes;
            this.qtdParticipantes = participantes.Count;

            /*o valor da vitória é proporcional ao número de jogadores a fim de
            proporcionar uma maior jogabilidade */
            if (qtdParticipantes < 3) valorDaVitoria = 100;
            else valorDaVitoria = 50;
        }

        public void Ordenar()
        {
            List<Participante> ordenada = new List<Participante>();
            Random r = new Random();
            int nPart;
            int i = 0;

            while (ordenada.Count < qtdParticipantes)
            {
                nPart = r.Next(1, qtdParticipantes);
                if (!(ordenada.Contains(participantes[nPart])))
                {
                    ordenada[i] = participantes[nPart];
                    participantes[nPart].ordem = (i + 1);
                    i++;
                }
                participantes = ordenada;
            }
        }
    }
}
