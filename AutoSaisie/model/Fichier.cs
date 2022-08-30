using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSaisie.model
{
    class Fichier
    {
        public int id { get; set; }
        public String nomFichier { get; set; }
        public String localisation { get; set; }
        public String separateur { get; set; }
        public String structure { get; set; }

        public TypeDoc typeDocument { get; set; }
        public Entreprise entreprise { get; set; }
    }
}
