using AutoSaisie.data.DAO;
using AutoSaisie.data.lecturefichier;
using AutoSaisie.metier;
using AutoSaisie.model;
using AutoSaisie.presentation;
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
using Tulpep.NotificationWindow;

namespace AutoSaisie
{
    public partial class AutoSaisie : Form
    {
        Dictionary<int, String> typesDoc;
        public static int selectedIDF;
        Dictionary<int, int> indexOfFichier;
        IMetierSage metier;
        public AutoSaisie()
        {
            InitializeComponent();
            
            indexOfFichier = new Dictionary<int, int>();
            metier = new MetierSageImpl();

            nomEntrepriseLabel.Text = MyApplicationContext.entrepriseCurrent.nomEntreprise;
            labelDomaine.Text = MyApplicationContext.entrepriseCurrent.domaine;
            fillListView();
            fillTypeCombobox();
            
           


        }
        public void fillTypeCombobox()
        {
            
            typesDoc = new Dictionary<int, string>();
            typesDoc.Clear();
            foreach (var type in metier.getAllTypeDocs())
            {
                typesDoc.Add(type.id, type.type);
            }
            typesDoc.Add(0, "");
            typeDocsCombobox.DataSource = new BindingSource(typesDoc, null);
            typeDocsCombobox.DisplayMember = "Value";
            typeDocsCombobox.ValueMember = "Key";
        }
        public void fillListView()
        {
            listView1.Items.Clear();
            var imageList = FileUtils.getImageListFromFile();
            listView1.LargeImageList = imageList;
            int index = -1;
            foreach (var fichier in metier.getFichiersByEntreprise(MyApplicationContext.entrepriseCurrent))
            {
                Fichier myF = metier.findFichier(fichier.id);
                ListViewItem item = new ListViewItem(myF.nomFichier);
                item.Tag = myF.nomFichier;
                indexOfFichier[++index] = myF.id;
                if (myF.typeDocument != null)
                {
                    if (imageList.Images.ContainsKey(myF.typeDocument.nomClasse))
                    {
                        item.ImageKey = myF.typeDocument.nomClasse;
                    }
                    else
                    {
                        item.ImageKey = "Default";
                    }
                }
              


                listView1.Items.Add(item);
            }
        }
    
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fichier f = metier.findFichier(selectedIDF);
            panelWait.Visible = true;
          
            metier.loadAndSave(f);
            showWaitWindows("les donnees sont bien enregistres dans l'ERP Sage");
            panelWait.Visible = false;


        }
        public void showWaitWindows(String msg)
        {
            PopupNotifier popup = new PopupNotifier();
            popup.TitleText = "Notification de AutoSaiseSAGE";
            popup.ContentText = msg;
            popup.Popup();// show  
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int indexSelected = listView1.SelectedItems[0].Index;
                int idSelected = indexOfFichier[indexSelected];
                selectedIDF = idSelected;
                Fichier f = metier.findFichier(idSelected);

                localisation.Text = f.localisation;
                separateur.Text = f.separateur + "";
                typeDocsCombobox.SelectedIndex = typeDocsCombobox.FindStringExact(f.typeDocument.type);
                structure.Text = f.structure;
                nomFichier.Text = f.nomFichier;
            }catch(Exception exception)
            {

            }

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            nomFichier.Text = "";
            localisation.Text = "";
            separateur.Text = "";
            typeDocsCombobox.SelectedIndex = typeDocsCombobox.FindStringExact("");
            structure.Text = "";
            selectedIDF = -1;
            fillTypeCombobox();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (selectedIDF >= 0)
            {
                Fichier f = metier.findFichier(selectedIDF);
                f.nomFichier = nomFichier.Text;
                f.localisation = localisation.Text;
                f.separateur = separateur.Text;
                int typeDocID = ((KeyValuePair<int, string>)typeDocsCombobox.SelectedItem).Key;
                f.typeDocument.id = typeDocID;
                metier.updateFichier(f);
               
            }
            else
            {
                Fichier f = new Fichier();
                f.nomFichier = nomFichier.Text;
                f.localisation = localisation.Text;
                f.separateur = separateur.Text;
                int typeDocID = ((KeyValuePair<int, string>)typeDocsCombobox.SelectedItem).Key;
                f.typeDocument.id = typeDocID;
                metier.ajouterFichier(f);
               
            }
            fillListView();

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem eachItem in listView1.SelectedItems)
            {
                listView1.Items.Remove(eachItem);
                metier.deleteFichier(indexOfFichier[eachItem.Index]);
            }
        }

        private void parametresBtn_Click(object sender, EventArgs e)
        {
          
            using (Params newProjectForm = new Params())
            {
                if (newProjectForm.ShowDialog() == DialogResult.OK)
                {
                    
                }
                else
                {
                    nomEntrepriseLabel.Text = MyApplicationContext.entrepriseCurrent.nomEntreprise;
                    labelDomaine.Text = MyApplicationContext.entrepriseCurrent.domaine;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
