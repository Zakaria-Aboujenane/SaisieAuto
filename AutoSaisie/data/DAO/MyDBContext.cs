using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using AutoSaisie.model;
using System.Data;
using AutoSaisie.data.lecturefichier;

namespace AutoSaisie.data.DAO
{
    class MyDBContext : DbContext
    {
        
       
        public MyDBContext(String ConnectionString):base(ConnectionString)
        {
           
            Database.SetInitializer<MyDBContext>(new CreateDatabaseIfNotExists<MyDBContext>());

        }
        public MyDBContext() : base("name=MYDBNAME")
        {

            Database.SetInitializer<MyDBContext>(new CreateDatabaseIfNotExists<MyDBContext>());

        }
        public DbSet<Fichier> fichiers { get; set; }
        public DbSet<Entreprise> entreprises { get; set; }
        public DbSet<TypeDoc> typeDocs { get; set; }


    }
}
