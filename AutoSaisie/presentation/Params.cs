using AutoSaisie.metier;
using AutoSaisie.model;
using AutoSaisie.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSaisie.presentation
{
    public partial class Params : Form
    {
        IMetierSage metier;
        public Params()
        {
            InitializeComponent();
            metier = new MetierSageImpl();
            Entreprise entreprise = MyApplicationContext.entrepriseCurrent;
            domaine.Text = entreprise.domaine;
            nomEntrep.Text = entreprise.nomEntreprise;
            baseSage.Text = entreprise.nomBaseDonnee;
           
        }

     

        private void button1_Click(object sender, EventArgs e)
        {

            Entreprise mentreprise = MyApplicationContext.entrepriseCurrent;
            mentreprise.domaine = domaine.Text;
            mentreprise.nomEntreprise = nomEntrep.Text;
            mentreprise.nomBaseDonnee = baseSage.Text;
            metier.setEntreprise(mentreprise);
            MyApplicationContext.entrepriseCurrent = mentreprise;
            this.Close();

        }
    }
}
