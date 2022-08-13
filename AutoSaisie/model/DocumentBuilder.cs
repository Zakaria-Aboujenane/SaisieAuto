using AutoSaisie.DAO;
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
        public static IBODocumentStock3 buildDocumentStock(DateTime do_date,String do_ref,IBOCompteA3 CompteA,IBODepot3 depotStockage,)
        {
            IBSCIALApplication3 baseCial = new ConnectToDatabase().OuvrirBaseCIAL();
            IBODocumentStock3 documentStock = baseCial.FactoryDocumentStock.CreateType(DocumentType.DocumentTypeStockMouvIn);
            documentStock.DO_Date = do_date;
            documentStock.DO_Ref = do_ref;
            documentStock.CompteA = CompteA;
            documentStock.DepotStockage = depotStockage;
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
