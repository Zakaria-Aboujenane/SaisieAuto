using AutoSaisie.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSaisie.metier
{
    interface IMetierSage
    {
        void loadAndSave(Fichier f);// loader du fichier et enregistrer vers la base de donnee de l'ERP
        List<Fichier> getFichers();
        void ajouterFichier(Fichier f);
        void deleteFichier(int id);
        void updateFichier(Fichier f);
        Fichier findFichier(int id);
        List<Fichier> getFichiersByEntreprise(Entreprise entreprise);

        Entreprise setEntreprise(Entreprise e);

        List<TypeDoc> getAllTypeDocs();

        TypeDoc getTypeByID(int id);

    }
}
