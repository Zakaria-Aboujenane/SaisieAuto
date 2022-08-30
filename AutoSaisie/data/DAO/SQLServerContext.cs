using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using AutoSaisie.model;
using System.Data.SqlClient;

namespace AutoSaisie.data.DAO
{
    class SQLServerContext : DbContext
    {
        public SQLServerContext():base("name=MYDBNAME")
        {
            SqlConnection.ClearAllPools();
            Database.SetInitializer<SQLServerContext>(new CreateDatabaseIfNotExists<SQLServerContext>());
            SqlConnection.ClearAllPools();
        }
        public DbSet<Fichier> fichiers { get; set; }
        public DbSet<Entreprise> entreprises { get; set; }
        public DbSet<TypeDoc> typeDocs { get; set; }


    }
}
