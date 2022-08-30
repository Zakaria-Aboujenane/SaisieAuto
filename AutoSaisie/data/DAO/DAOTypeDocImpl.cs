using AutoSaisie.data;
using AutoSaisie.model;
using AutoSaisie.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AutoSaisie.data.DAO
{
    class DAOTypeDocImpl : IDAOParams<TypeDoc>
    {
        public SQLServerContext dbcontext { get; set; }
        public DAOTypeDocImpl()
        {
            dbcontext = new SQLServerContext();
        }


        public void add(TypeDoc t)
        {
            dbcontext.typeDocs.Add(t);
            dbcontext.SaveChanges();
        }

        public void delete(TypeDoc t)
        {
            throw new NotImplementedException();
        }

        public TypeDoc edit(TypeDoc t)
        {
            throw new NotImplementedException();
        }

        public TypeDoc findByID(int id)
        {
            int x = 10;
            return dbcontext.typeDocs.Find(id);
            
        }

        public List<TypeDoc> getAll()
        {
            List<TypeDoc> types = new List<TypeDoc>();
            foreach (var type in dbcontext.typeDocs.ToList<TypeDoc>())
            {
                if (ReflectionUtils.createInstance("Sage" + type.nomClasse) != null)
                {
                    types.Add(type);
                }
            }
            return types;
        }
        
    }
}
