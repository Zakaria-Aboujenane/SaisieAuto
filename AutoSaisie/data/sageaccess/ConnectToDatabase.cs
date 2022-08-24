using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Objets100cLib;

namespace AutoSaisie.data.sageaccess
{

    class ConnectToDatabase
    {
        public IBSCPTAApplication3 baseComptable { get; set; }
        public IBSCIALApplication3 baseCommerciale { get; set; }
        public String errorMsg { get; set; }
        public String seccessMsg { get; set; }

        public ConnectToDatabase()
        {
            baseComptable = new BSCPTAApplication100c();
            baseCommerciale = new BSCIALApplication100c();

        }
        public IBSCIALApplication3 OuvrirBaseCIAL()
        {
            try
            {

                baseCommerciale.Name = "C:/Users/Public/Documents/Sage/Entreprise 100c/Bijou.gcm";
                baseCommerciale.Loggable.UserName = "<Administrateur>";
                baseCommerciale.Loggable.UserPwd = "";
                baseCommerciale.Open();
                return baseCommerciale;


            }
            catch (Exception ex)
            {
                errorMsg = "erreur Base Commerciale : " + ex.Message;
                throw ex;
            }

        }

        public IBSCPTAApplication3 OuvrirBaseCOMP()
        {
            try
            {

                baseComptable.Name = "C:/Users/Public/Documents/Sage/Entreprise 100c/Bijou.mae";
                baseComptable.Loggable.UserName = "<Administrateur>";
                baseComptable.Loggable.UserPwd = "";
                baseComptable.Open();
                return baseComptable;

            }
            catch (Exception ex)
            {
                errorMsg = "erreur Base Comptable : " + ex.Message;
                throw ex;
            }


        }

    }
}
