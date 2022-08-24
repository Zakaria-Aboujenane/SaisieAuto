using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Objets100cLib;

namespace AutoSaisie.data.sageaccess
{
    interface ISaisie<T>
    {
        void enregistrerDansERP(T document);
        T rehcerhceParRef(DocumentType type,String reference);
    }
}
