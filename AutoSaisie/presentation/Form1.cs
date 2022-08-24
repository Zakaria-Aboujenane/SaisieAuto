using AutoSaisie.data.DAO;
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

namespace AutoSaisie
{
    public partial class Form1 : Form
    {

        IMetierSage metier;
        public Form1()
        {
            InitializeComponent();
            metier = new MetierSageImpl();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IDAOParams<TypeDoc> daotype = new DAOTypeDocImpl();
            /*
            
            List<TypeDoc> types = dao.getAll();
            foreach (var item in types)
            {
                labelTest.Text += item.nomClasse;
            }
            */

            Fichier f = new Fichier();
            f.id = 1;
            f.separateur = ';';
            f.structure = "do_date-0;do_ref-1;CompteA-2;depotStockage-3";
            f.localisation = "C:/Users/Zakaria/Desktop/test_sage/doc_stock.txt";
            f.typeDocument = daotype.findByID(1);
            Entreprise entr = new Entreprise();
            entr.domaine = "economie";
            entr.id = 1;
            entr.nomBaseDonnee = "BIJOU";
            entr.nomEntreprise = "ROBINHOOD";
            metier.setEntreprise(entr);
            metier.loadAndSave(f);


        }
    }
}
