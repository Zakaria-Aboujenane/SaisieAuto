using AutoSaisie.data.DAO;
using AutoSaisie.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSaisie.utils
{
    class MyAppCtx
    {
        public static String nomBD = "bijou";
        public static Entreprise entrepriseCurrent = new DAOEntrepImpl().findByID(1);
        public static String appPath = "./";
        public static String iconsPath = "./icons/";
        public static String filesPath = "./ress/";
        public static String cnxParams = "Server=DESKTOP-E691V93; Database=AutoSaisieDB;user=;password=;";
        public static String cnxStringParams = "persist security info=True;     Integrated Security=SSPI;Pooling=false;";
        public static String cnxString = cnxParams + cnxStringParams;

        public String getCnxString()
        {
            return "Server = DESKTOP - E691V93; Database = AutoSaisieDB; persist security info = True; Integrated Security = SSPI; Pooling = false";
        }
    }
}
