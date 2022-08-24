using AutoSaisie.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSaisie.data.DAO
{
    interface IDAOParams<T>
    {
        List<T> getAll();
        void add(T t);
        T edit(T t);
        void delete(T t);
        T findByID(int id);


    }
}
