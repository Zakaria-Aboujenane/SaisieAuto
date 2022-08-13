using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSaisie.DAO
{
    interface ISaisie<T>
    {
        void ajouter(T doc);
        List<T> lister();
    }
}
