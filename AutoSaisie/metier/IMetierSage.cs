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
        void deleteFichier(int id);
        void updateFichier(int id);

        Entreprise setEntreprise(Entreprise e);

    }
}
