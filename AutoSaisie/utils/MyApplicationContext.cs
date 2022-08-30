using AutoSaisie.data.DAO;
using AutoSaisie.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSaisie.utils
{
    class MyApplicationContext
    {
        public static String nomBD = "bijou";
        public static Entreprise entrepriseCurrent = new DAOEntrepImpl().findByID(1);
        public static String appPath = "../../";
        public static String iconsPath = "../../icons/";
        public static String filesPath = "../../ress/";
    }
}
