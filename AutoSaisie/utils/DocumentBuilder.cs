using AutoSaisie.data.sageaccess;
using Objets100cLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSaisie.model
{
    class DocumentBuilder
    {
        public static IBOCompteA3 getCodeAffaire(IBSCIALApplication3 basecial, String codeAff)
        {
            IBPDossierParamCial dossierParamCial = (IBPDossierParamCial)basecial.FactoryDossierParam.List[1];
            IBPAnalytique3 planAnalytique = dossierParamCial.AnalytiqueAffaire;
            IBOCompteA3 compte = basecial.CptaApplication.FactoryCompteA.ReadNumero(planAnalytique, codeAff);
            return compte;
        }
        public static IBODocumentStock3 buildDocumentStock(String do_date,String do_ref,String CompteA,String depotStockage)
        {
            IBSCIALApplication3 baseCial = new ConnectToDatabase().OuvrirBaseCIAL();
            IBODocumentStock3 documentStock = baseCial.FactoryDocumentStock.CreateType(DocumentType.DocumentTypeStockMouvIn);
            documentStock.DO_Date = DateTime.Parse(do_date);
            documentStock.DO_Ref = do_ref;
            documentStock.CompteA = DocumentBuilder.getCodeAffaire(baseCial, CompteA);
            documentStock.DepotStockage = baseCial.FactoryDepot.ReadIntitule(depotStockage);
            
            return documentStock;
        }
        public static IBODocumentStockLigne3 buildDocumentStockLigne(IBODocumentStock3 documentStock, String ref_txt,int ref_int)
        {
            IBODocumentStockLigne3 documentLigne = (IBODocumentStockLigne3)documentStock.FactoryDocumentLigne.Create();
            documentLigne.SetDefaultArticleReference(ref_txt,ref_int);
            return documentLigne;
        }
    }
}
