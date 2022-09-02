
namespace AutoSaisie
{
    partial class AutoSaisie
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            this.parametresBtn = new System.Windows.Forms.Button();
            this.nomEntrepriseLabel = new System.Windows.Forms.Label();
            this.btnInsererDansERP = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.separateur = new System.Windows.Forms.TextBox();
            this.structure = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.typeDocsCombobox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.localisation = new System.Windows.Forms.TextBox();
            this.labelTest = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nomFichier = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panelWait = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.labelDomaine = new System.Windows.Forms.Label();
            this.panelWait.SuspendLayout();
            this.SuspendLayout();
            // 
            // parametresBtn
            // 
            this.parametresBtn.Location = new System.Drawing.Point(713, 18);
            this.parametresBtn.Name = "parametresBtn";
            this.parametresBtn.Size = new System.Drawing.Size(75, 23);
            this.parametresBtn.TabIndex = 0;
            this.parametresBtn.Text = "parametres";
            this.parametresBtn.UseVisualStyleBackColor = true;
            this.parametresBtn.Click += new System.EventHandler(this.parametresBtn_Click);
            // 
            // nomEntrepriseLabel
            // 
            this.nomEntrepriseLabel.AutoSize = true;
            this.nomEntrepriseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomEntrepriseLabel.Location = new System.Drawing.Point(12, 18);
            this.nomEntrepriseLabel.Name = "nomEntrepriseLabel";
            this.nomEntrepriseLabel.Size = new System.Drawing.Size(259, 39);
            this.nomEntrepriseLabel.TabIndex = 1;
            this.nomEntrepriseLabel.Text = "Nom Entreprise";
            this.nomEntrepriseLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnInsererDansERP
            // 
            this.btnInsererDansERP.Enabled = false;
            this.btnInsererDansERP.Location = new System.Drawing.Point(703, 165);
            this.btnInsererDansERP.Name = "btnInsererDansERP";
            this.btnInsererDansERP.Size = new System.Drawing.Size(85, 101);
            this.btnInsererDansERP.TabIndex = 3;
            this.btnInsererDansERP.Text = "inserer vers ERP";
            this.btnInsererDansERP.UseVisualStyleBackColor = true;
            this.btnInsererDansERP.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.listView1.Location = new System.Drawing.Point(352, 91);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(348, 287);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Enabled = false;
            this.btnSupprimer.Location = new System.Drawing.Point(366, 384);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(90, 23);
            this.btnSupprimer.TabIndex = 16;
            this.btnSupprimer.Text = "supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Enabled = false;
            this.btnAjouter.Location = new System.Drawing.Point(610, 384);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(90, 23);
            this.btnAjouter.TabIndex = 17;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(274, 303);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(72, 23);
            this.btnEnregistrer.TabIndex = 27;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "separateur";
            // 
            // separateur
            // 
            this.separateur.Location = new System.Drawing.Point(99, 175);
            this.separateur.Name = "separateur";
            this.separateur.Size = new System.Drawing.Size(247, 20);
            this.separateur.TabIndex = 25;
            // 
            // structure
            // 
            this.structure.Location = new System.Drawing.Point(99, 201);
            this.structure.Name = "structure";
            this.structure.Size = new System.Drawing.Size(247, 96);
            this.structure.TabIndex = 24;
            this.structure.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "structure";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "localisation";
            // 
            // typeDocsCombobox
            // 
            this.typeDocsCombobox.FormattingEnabled = true;
            this.typeDocsCombobox.Location = new System.Drawing.Point(99, 122);
            this.typeDocsCombobox.Name = "typeDocsCombobox";
            this.typeDocsCombobox.Size = new System.Drawing.Size(247, 21);
            this.typeDocsCombobox.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "type Du fichier";
            // 
            // localisation
            // 
            this.localisation.Location = new System.Drawing.Point(99, 149);
            this.localisation.Name = "localisation";
            this.localisation.Size = new System.Drawing.Size(247, 20);
            this.localisation.TabIndex = 19;
            // 
            // labelTest
            // 
            this.labelTest.AutoSize = true;
            this.labelTest.Location = new System.Drawing.Point(53, 256);
            this.labelTest.Name = "labelTest";
            this.labelTest.Size = new System.Drawing.Size(0, 13);
            this.labelTest.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "nom du fichier";
            // 
            // nomFichier
            // 
            this.nomFichier.Location = new System.Drawing.Point(99, 96);
            this.nomFichier.Name = "nomFichier";
            this.nomFichier.Size = new System.Drawing.Size(247, 20);
            this.nomFichier.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(291, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Veuillez patientez ...... cela peut prendre quelques secondes";
            // 
            // panelWait
            // 
            this.panelWait.Controls.Add(this.label6);
            this.panelWait.Location = new System.Drawing.Point(172, 221);
            this.panelWait.Name = "panelWait";
            this.panelWait.Size = new System.Drawing.Size(433, 48);
            this.panelWait.TabIndex = 31;
            this.panelWait.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(311, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "domaine : ";
            // 
            // labelDomaine
            // 
            this.labelDomaine.AutoSize = true;
            this.labelDomaine.Location = new System.Drawing.Point(384, 44);
            this.labelDomaine.Name = "labelDomaine";
            this.labelDomaine.Size = new System.Drawing.Size(0, 13);
            this.labelDomaine.TabIndex = 33;
            // 
            // AutoSaisie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelDomaine);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panelWait);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nomFichier);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.separateur);
            this.Controls.Add(this.structure);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.typeDocsCombobox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.localisation);
            this.Controls.Add(this.labelTest);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnInsererDansERP);
            this.Controls.Add(this.nomEntrepriseLabel);
            this.Controls.Add(this.parametresBtn);
            this.Name = "AutoSaisie";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelWait.ResumeLayout(false);
            this.panelWait.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button parametresBtn;
        private System.Windows.Forms.Label nomEntrepriseLabel;
        private System.Windows.Forms.Button btnInsererDansERP;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox separateur;
        private System.Windows.Forms.RichTextBox structure;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox typeDocsCombobox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox localisation;
        private System.Windows.Forms.Label labelTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomFichier;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelWait;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelDomaine;
    }
}

