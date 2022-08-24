using AutoSaisie.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSaisie.data.DAO
{
    class DAOFichierimpl : IDAOParams<Fichier>
    {
        public SQLServerContext dbcontext { get; set; }
        public DAOFichierimpl()
        {
            dbcontext = new SQLServerContext();
        }

        public void add(Fichier t)
        {
            dbcontext.fichiers.Add(t);
            dbcontext.SaveChanges();
        }

        public void delete(Fichier t)
        {
            t = findByID(t.id);
            dbcontext.fichiers.Remove(t);
            dbcontext.SaveChanges();
        }

        public Fichier edit(Fichier t)
        {
            Fichier f = dbcontext.fichiers.Add(t);
            dbcontext.SaveChanges();
            return f;
        }

        public List<Fichier> getAll()
        {
            return dbcontext.fichiers.ToList<Fichier>();
        }

        public Fichier findByID(int id)
        {
            return dbcontext.fichiers.Find(id);
        }
    }
}
