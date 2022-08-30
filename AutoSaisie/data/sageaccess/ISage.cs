using AutoSaisie.model;
using Objets100cLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSaisie.data.sageaccess
{
    interface ISage<T>
    {
        List<T> readAll(Fichier fichier);
        void enregistrerDansERP(T document);
        T rehcerhceParRef(DocumentType type, String reference);

        T buildData(Dictionary<String,String> data);
    }
}
