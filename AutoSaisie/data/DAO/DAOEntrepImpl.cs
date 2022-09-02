using AutoSaisie.model;
using AutoSaisie.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSaisie.data.DAO
{
    class DAOEntrepImpl : IDAOParams<Entreprise>
    {
        public MyDBContext dbcontext;
        public DAOEntrepImpl()
        {
            dbcontext = new MyDBContext();
        }

        public void add(Entreprise t)
        {
            dbcontext.entreprises.Add(t);
            dbcontext.SaveChanges();
        }

        public void delete(Entreprise t)
        {
            t = findByID(t.id);
            dbcontext.entreprises.Remove(t);
            dbcontext.SaveChanges();
        }

        public Entreprise edit(Entreprise t)
        {
            Entreprise e = dbcontext.entreprises.Find(t.id);
            e.nomEntreprise = t.nomEntreprise;
            e.nomBaseDonnee = t.nomBaseDonnee;
            e.domaine = t.domaine;
            dbcontext.SaveChanges();
            return e;
        }

        public Entreprise findByID(int id)
        {
            var entreWithFiles = dbcontext.entreprises.
                 Include("Fichiers").FirstOrDefault(p => p.id == id);

            return entreWithFiles;
        }

        public List<Entreprise> getAll()
        {
            return dbcontext.entreprises.ToList<Entreprise>();
        }
    }
}
