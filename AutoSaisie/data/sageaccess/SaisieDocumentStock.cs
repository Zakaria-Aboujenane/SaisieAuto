using Objets100cLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSaisie.data.sageaccess
{
    class SaisieDocumentStock : ISaisie<IBODocumentStock3>
    {
        public ConnectToDatabase db { get; set; }

        public IBSCIALApplication3 baseCIAL { get; set; }
        public SaisieDocumentStock()
        {
            db = new ConnectToDatabase();
            baseCIAL = db.OuvrirBaseCIAL();
        }
        public void enregistrerDansERP(IBODocumentStock3 document)
        {
            try
            {

                document.WriteDefault();
                document.CouldModified();

            }
            catch (Exception e)
            {
                db.errorMsg = "error creation document stock : " + e.Message;
            }
        }

        public IBODocumentStock3 rehcerhceParRef(DocumentType type,string reference)
        {
            IBODocumentStock3 doc = new ConnectToDatabase().OuvrirBaseCIAL().FactoryDocumentStock.ReadPiece(type,reference);
            return doc;
        }
    }
}
