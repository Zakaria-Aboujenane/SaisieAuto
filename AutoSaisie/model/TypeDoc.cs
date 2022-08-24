using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSaisie.model
{
    class TypeDoc
    {
        public int id { get; set; }
        public String type { get; set; }
        public String nomClasse { get; set; }
        public String classeSage { get; set; }
        public String champs { get; set; }

        public List<Fichier> fichiers { get; set; }
    }
}
