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
using System.Reflection;
using Objets100cLib;

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

   
        public void updateFichier(Fichier f)
        {
            idaoF.edit(f);
        }

  
        public Entreprise setEntreprise(Entreprise e)
        {
            return idaoE.edit(e);
        }

        public void loadAndSave(Fichier f)
        {
           
            Object o = ReflectionUtils.createInstance("Sage" + f.typeDocument.nomClasse);
            Type typeSage = o.GetType();
            MethodInfo lireEtEnregistrer = typeSage.GetMethod("readAll");
            object[] parametersArray = new object[] { f };
            lireEtEnregistrer.Invoke(o, parametersArray);





        }

        public List<Fichier> getFichiersByEntreprise(Entreprise entreprise)
        {
            return  entreprise.fichiers;
        }

        public Fichier findFichier(int id)
        {
            return idaoF.findByID(id);
        }

        public List<TypeDoc> getAllTypeDocs()
        {
            return idaoTypeDoc.getAll();
        }

        public TypeDoc getTypeByID(int id)
        {
            return idaoTypeDoc.findByID(id);
        }

        public void ajouterFichier(Fichier f)
        {
             idaoF.add(f);
        }
    }
}
