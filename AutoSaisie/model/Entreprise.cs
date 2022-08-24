using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSaisie.model
{
    class Entreprise
    {
        public int id { get; set; }
        public String nomEntreprise { get; set; }
        public String domaine { get; set; }
        public String nomBaseDonnee { get; set; }

        public List<Fichier> fichiers { get; set; }
    }
}
