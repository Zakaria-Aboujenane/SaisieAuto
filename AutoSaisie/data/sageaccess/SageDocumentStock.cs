using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoSaisie.data.lecturefichier;
using AutoSaisie.model;
using Objets100cLib;

namespace AutoSaisie.data.sageaccess
{
    class SageDocumentStock : ISage<IBODocumentStock3>
    {
        public ConnectToDatabase db { get; set; }
        public IBODocumentStock3 document { get; set; }
        public IBSCIALApplication3 baseCial { get; set; }
        public IBODocumentStockLigne3 documentLigne { get; set; }
        public SageDocumentStock()
        {
            db = new ConnectToDatabase();
            baseCial = db.OuvrirBaseCIAL();
        }
        public void enregistrerDansERP(IBODocumentStock3 document)
        {
            try
            {

                document.WriteDefault();
                document.CouldModified();
                documentLigne.WriteDefault();
                documentLigne.CouldModified();

            }
            catch (Exception e)
            {
                db.errorMsg = "erreur durant la creation du document stock : " + e.Message;
            }
        }

        public List<IBODocumentStock3> readAll(Fichier fichier)
        {
            List<IBODocumentStock3> listeDocStock = new List<IBODocumentStock3>();

            var structureMap = FileUtils.stuctureToMap(fichier.structure);
            List<String> lignes = FileUtils.fileToStrings(fichier.localisation);

            foreach (var ligne in lignes)
            {
                String[] listEls = ligne.Split(fichier.separateur[0]);
                int x = structureMap["do_date"];
                String x2 = listEls[x];
                Dictionary<String, String> mYList = new Dictionary<string, string>();
                mYList["do_date"] = listEls[structureMap["do_date"]];
                mYList["do_ref"] = listEls[structureMap["do_ref"]];
                mYList["CompteA"] = listEls[structureMap["CompteA"]];
                mYList["depotStockage"] = listEls[structureMap["depotStockage"]];
                mYList["ref_txt"] = listEls[structureMap["ref_txt"]];
                mYList["ref_int"] = listEls[structureMap["ref_int"]];
                buildData(mYList);
                enregistrerDansERP(document);
            }

            return listeDocStock;
        }

        public IBODocumentStock3 rehcerhceParRef(DocumentType type, string reference)
        {
            IBODocumentStock3 doc = new ConnectToDatabase().OuvrirBaseCIAL().FactoryDocumentStock.ReadPiece(type, reference);
            return doc;
        }
        public IBODocumentStock3 buildData(Dictionary<String, String> data)
        {

            IBODocumentStock3 documentStock = baseCial.FactoryDocumentStock.CreateType(DocumentType.DocumentTypeStockMouvIn);
            documentStock.DO_Date = DateTime.Parse(data["do_date"]);
            documentStock.DO_Ref = data["do_ref"];
            documentStock.CompteA = DocumentBuilder.getCodeAffaire(baseCial, data["CompteA"]);
            documentStock.DepotStockage = baseCial.FactoryDepot.ReadIntitule(data["depotStockage"]);
            document = documentStock;
            documentLigne = (IBODocumentStockLigne3)document.FactoryDocumentLigne.Create();
            documentLigne.SetDefaultArticleReference(data["ref_txt"], Int16.Parse(data["ref_int"]));
            return documentStock;
        }
    }
}
