using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfil_Marvel.Modelo
{
    public class Dica
    {
        public int numero { get; set; }
        public string texto { get; set; }
        public string perfil_nome { get; set; }

        public Dica()
        {
            this.numero = -1;
            this.texto = "";
            this.perfil_nome = "";
        }

        public Dica(string perfil_nome, int numero, string texto)
        {
            this.perfil_nome = perfil_nome;
            this.numero = numero;
            this.texto = texto;
        }

        public override string ToString()
        {
            return (numero+1) + ". " + texto;
        }

        public string ToStringSemNumero()
        {
            return texto;
        }
    }
}
