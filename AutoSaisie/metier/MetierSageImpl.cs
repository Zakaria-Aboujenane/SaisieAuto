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
            String s="";
            Object classeSage = ReflectionUtils.createInstance(f.typeDocument.classeSage);
            Object o = ReflectionUtils.createInstance("Lecteur" + f.typeDocument.nomClasse);
            Type typeLecture = o.GetType();
            MethodInfo methodReadAll = typeLecture.GetMethod("readAll");
            object[] parametersArray = new object[] { f };
            var allDocs = methodReadAll.Invoke(o, parametersArray);


            Object osaisie = ReflectionUtils.createInstance("Saisie" + f.typeDocument.nomClasse);
            Type typeSaisie = osaisie.GetType();
            MethodInfo methodERP = typeSaisie.GetMethod("enregistrerDansERP");
            foreach (var item in (dynamic)allDocs)
            {
                object[] saisieParams = new object[] { item };
                methodERP.Invoke(osaisie, saisieParams);
            }
        }

    }
}
