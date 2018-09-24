using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Perfil_Marvel.Modelo;
using Perfil_Marvel.Persistencia;

namespace Perfil_Marvel.DAO
{
    public class DAOPerfil
    {
        private List<Perfil> perfis = new List<Perfil>();
        private PPerfil pc = new PPerfil();

        public List<Perfil> Select()
        {
            perfis = pc.Abrir().OrderBy(c => c.nome).ToList();
            return perfis;
        }

        public void Insert(Perfil c)
        {
            perfis = pc.Abrir().ToList();
            if(perfis.Count < 15)
            {
                perfis.Add(c);
                pc.Salvar(perfis);
            }
        }

        public void Update(Perfil c)
        {
            perfis = pc.Abrir();
            // Busca o perfil que vai ser alterado pelo nome
            Perfil r = perfis.Where(x => x.nome == c.nome).Single();
            perfis.Remove(r);
            perfis.Add(c);
            pc.Salvar(perfis);
        }

        public void Delete(Perfil c)
        {
            perfis = pc.Abrir();
            // Busca o perfil que vai ser removido pelo nome
            Perfil r = perfis.Where(x => x.nome == c.nome).Single();
            perfis.Remove(r);
            pc.Salvar(perfis);
        }
    }
}
