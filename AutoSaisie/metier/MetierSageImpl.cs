using AutoSaisie.data.sageaccess;
using AutoSaisie.data.DAO;
using AutoSaisie.data.lecturefichier;
using AutoSaisie.model;
using AutoSaisie.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSaisie.metier
{
    class MetierSageImpl : IMetierSage
    {
       
        public IDAOParams<Fichier> idaoF { get; set; }
        public IDAOParams<Entreprise> idaoE { get; set; }
        public IDAOParams<TypeDoc> idaoTypeDoc { get; set; }



        public MetierSageImpl()
        {
            idaoE = new DAOEntrepImpl();
            idaoF = new DAOFichierimpl();
            idaoTypeDoc = new DAOTypeDocImpl();
        }

        public void deleteFichier(int id)
        {
            idaoF.delete(idaoF.findByID(id));
        }

        public List<Fichier> getFichers()
        {
            return idaoF.getAll();
        }

   
        public void updateFichier(int id)
        {
            idaoF.edit(idaoF.findByID(id));
        }

  
        public Entreprise setEntreprise(Entreprise e)
        {
            return idaoE.edit(e);
        }

        public void loadAndSave(Fichier f)
        {
           
            Object classeSage = ReflectionUtils.createInstance(f.typeDocument.classeSage);
            ILecteur<Object> o = (ILecteur<object>)ReflectionUtils.createInstance("Lecteur" + f.typeDocument.nomClasse);
            ISaisie<Object> osaisie = (ISaisie<object>)ReflectionUtils.createInstance("Saisie" + f.typeDocument.nomClasse); 
            foreach (var item in o.readAll(f))
            {
                osaisie.enregistrerDansERP(item);
            }
        }

    }
}
