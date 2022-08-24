using AutoSaisie.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSaisie.data.lecturefichier
{
    interface ILecteur<T>
    {
        List<T> readAll(Fichier fichier);
    }
}
