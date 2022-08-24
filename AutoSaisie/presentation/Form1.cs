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
            /*
            IDAOParams<TypeDoc> dao = new DAOTypeDocImpl();
            List<TypeDoc> types = dao.getAll();
            foreach (var item in types)
            {
                labelTest.Text += item.nomClasse;
            }
            */
            ReflectionUtils.createInstance("SaisieDocumentStock");
            
        }
    }
}
