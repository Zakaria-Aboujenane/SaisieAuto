using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoSaisie.model;
using Objets100cLib;

namespace AutoSaisie.data.lecturefichier
{
    class LecteurDocumentStock : ILecteur<IBODocumentStock3>
    {
       
        public List<IBODocumentStock3> readAll(Fichier fichier)
        {
            List<IBODocumentStock3> listeDocStock = new List<IBODocumentStock3>();

            var structureMap = FileUtils.stuctureToMap(fichier.structure);
            List<String> lignes = FileUtils.fileToStrings(fichier.localisation);
            
            foreach (var ligne in lignes)
            {
                String[] listEls = ligne.Split(fichier.separateur);
                int x = structureMap["do_date"];
                String x2 = listEls[x];
                
                listeDocStock.Add(DocumentBuilder.buildDocumentStock(
                        listEls[structureMap["do_date"]],
                        listEls[structureMap["do_ref"]],
                        listEls[structureMap["compteA"]],
                        listEls[structureMap["depotStockage"]]
                ));
            }
            
            return listeDocStock;
        }
    }
}
