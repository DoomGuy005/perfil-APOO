using Perfil_Marvel.Modelo;
using Perfil_Marvel.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfil_Marvel.DAO
{
    class DAODicas
    {
        private List<Dica> dicas = new List<Dica>();
        private PDica pc = new PDica();

        public List<Dica> Select()
        {
            dicas = pc.Abrir().OrderBy(c => c.perfil_nome).ToList();
            return dicas;
        }

        public List<Dica> SelectPorPerfil(string perfil)
        {
            dicas = pc.Abrir().OrderBy(c => perfil).ToList();
            List<Dica> dicasPerfil = new List<Dica>();

            dicasPerfil = dicas.Where(x => x.perfil_nome == perfil).ToList();
            return dicasPerfil;
        }

        public void Insert(Dica c)
        {
            dicas = pc.Abrir().ToList();
            if (dicas.Count < 10)
            {
                dicas.Add(c);
                pc.Salvar(dicas);
            }
        }

        public void Update(Dica c)
        {
            dicas = pc.Abrir();
            // Busca a dica que vai ser alterado pelo nome
            Dica r = dicas.Where(x => x.perfil_nome == c.perfil_nome && x.numero == c.numero).Single();
            dicas.Remove(r);
            dicas.Add(c);
            pc.Salvar(dicas);
        }

        public void Delete(Dica c)
        {
            dicas = pc.Abrir();
            // Busca a dica que vai ser removido pelo numero e perfil
            Dica r = dicas.Where(x => x.perfil_nome == c.perfil_nome && x.numero == c.numero).Single();
            dicas.Remove(r);
            pc.Salvar(dicas);
        }
    }
}
