using Objets100cLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSaisie.DAO
{
    class SaisieDocumentStock : ISaisie<IBODocumentStock3>
    {
        public ConnectToDatabase db { get; set; }

        public IBSCIALApplication3 baseCIAL { get; set; }
        public SaisieDocumentStock()
        {
            baseCIAL = db.OuvrirBaseCIAL();
        }

        public void ajouter(IBODocumentStock3 documentStock)
        {
            try
            {
                documentStock = baseCIAL.FactoryDocumentStock.CreateType(DocumentType.DocumentTypeStockMouvIn);
                documentStock.DO_Date = DateTime.Now;
                documentStock.DO_Ref = "ZAKI123";
                documentStock.CompteA = getCodeAffaire(baseCIAL, "953INDE");
                documentStock.DepotStockage = baseCIAL.FactoryDepot.ReadIntitule("Bijou SA");
                documentStock.WriteDefault();
                documentStock.CouldModified();

                IBODocumentStockLigne3 documentLigne = (IBODocumentStockLigne3)documentStock.FactoryDocumentLigne.Create();
                documentLigne.SetDefaultArticleReference("BAAR01", 5);
                documentLigne.WriteDefault();

                documentLigne = (IBODocumentStockLigne3)documentStock.FactoryDocumentLigne.Create();
                documentLigne.SetDefaultArticleReference("CHFE01", 12);
                documentLigne.WriteDefault();

                db.seccessMsg = "document Added !";
            }catch(Exception e)
            {
                db.errorMsg = "error creation document stock : " + e.Message;
            }
        }

        public List<IBODocumentStock3> lister()
        {
            throw new NotImplementedException();
        }

        public IBOCompteA3 getCodeAffaire(IBSCIALApplication3 basecial, String codeAff)
        {
            IBPDossierParamCial dossierParamCial = (IBPDossierParamCial)basecial.FactoryDossierParam.List[1];
            IBPAnalytique3 planAnalytique = dossierParamCial.AnalytiqueAffaire;
            IBOCompteA3 compte = basecial.CptaApplication.FactoryCompteA.ReadNumero(planAnalytique, codeAff);
            return compte;
        }
    }
}
