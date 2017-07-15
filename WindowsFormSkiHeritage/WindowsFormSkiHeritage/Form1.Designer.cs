namespace WindowsFormSkiHeritage
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbListeComp = new System.Windows.Forms.ComboBox();
            this.labClassWCSL = new System.Windows.Forms.Label();
            this.labClassFIS = new System.Windows.Forms.Label();
            this.labNom = new System.Windows.Forms.Label();
            this.labPrenom = new System.Windows.Forms.Label();
            this.tbClassWCSL = new System.Windows.Forms.TextBox();
            this.tbClassFIS = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.btnInscrire = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbEtatNeige = new System.Windows.Forms.ComboBox();
            this.tbLongueur = new System.Windows.Forms.TextBox();
            this.mtbDateHeure = new System.Windows.Forms.MaskedTextBox();
            this.tbNomCourse = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labDateCourse = new System.Windows.Forms.Label();
            this.labNomCourse = new System.Windows.Forms.Label();
            this.btnSlalom = new System.Windows.Forms.Button();
            this.btnDescente = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnReinitialise = new System.Windows.Forms.Button();
            this.labDesignationCourse = new System.Windows.Forms.Label();
            this.btnAttribuerDossard = new System.Windows.Forms.Button();
            this.cbListeCoureur = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbListeComp);
            this.groupBox1.Controls.Add(this.labClassWCSL);
            this.groupBox1.Controls.Add(this.labClassFIS);
            this.groupBox1.Controls.Add(this.labNom);
            this.groupBox1.Controls.Add(this.labPrenom);
            this.groupBox1.Controls.Add(this.tbClassWCSL);
            this.groupBox1.Controls.Add(this.tbClassFIS);
            this.groupBox1.Controls.Add(this.tbNom);
            this.groupBox1.Controls.Add(this.tbPrenom);
            this.groupBox1.Controls.Add(this.btnInscrire);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1485, 258);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inscrire Coureur";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormSkiHeritage.Properties.Resources.index;
            this.pictureBox1.Location = new System.Drawing.Point(935, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 230);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Liste des coureurs inscrits";
            // 
            // cbListeComp
            // 
            this.cbListeComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbListeComp.FormattingEnabled = true;
            this.cbListeComp.Location = new System.Drawing.Point(250, 186);
            this.cbListeComp.Name = "cbListeComp";
            this.cbListeComp.Size = new System.Drawing.Size(649, 21);
            this.cbListeComp.TabIndex = 9;
            // 
            // labClassWCSL
            // 
            this.labClassWCSL.AutoSize = true;
            this.labClassWCSL.Location = new System.Drawing.Point(96, 166);
            this.labClassWCSL.Name = "labClassWCSL";
            this.labClassWCSL.Size = new System.Drawing.Size(95, 13);
            this.labClassWCSL.TabIndex = 8;
            this.labClassWCSL.Text = "Classement WCSL";
            // 
            // labClassFIS
            // 
            this.labClassFIS.AutoSize = true;
            this.labClassFIS.Location = new System.Drawing.Point(96, 125);
            this.labClassFIS.Name = "labClassFIS";
            this.labClassFIS.Size = new System.Drawing.Size(80, 13);
            this.labClassFIS.TabIndex = 7;
            this.labClassFIS.Text = "Classement FIS";
            // 
            // labNom
            // 
            this.labNom.AutoSize = true;
            this.labNom.Location = new System.Drawing.Point(96, 88);
            this.labNom.Name = "labNom";
            this.labNom.Size = new System.Drawing.Size(68, 13);
            this.labNom.TabIndex = 6;
            this.labNom.Text = "Nom coureur";
            // 
            // labPrenom
            // 
            this.labPrenom.AutoSize = true;
            this.labPrenom.Location = new System.Drawing.Point(96, 45);
            this.labPrenom.Name = "labPrenom";
            this.labPrenom.Size = new System.Drawing.Size(83, 13);
            this.labPrenom.TabIndex = 5;
            this.labPrenom.Text = "Prénom Coureur";
            // 
            // tbClassWCSL
            // 
            this.tbClassWCSL.Location = new System.Drawing.Point(250, 159);
            this.tbClassWCSL.Name = "tbClassWCSL";
            this.tbClassWCSL.Size = new System.Drawing.Size(242, 20);
            this.tbClassWCSL.TabIndex = 4;
            // 
            // tbClassFIS
            // 
            this.tbClassFIS.Location = new System.Drawing.Point(250, 118);
            this.tbClassFIS.Name = "tbClassFIS";
            this.tbClassFIS.Size = new System.Drawing.Size(242, 20);
            this.tbClassFIS.TabIndex = 3;
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(250, 81);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(242, 20);
            this.tbNom.TabIndex = 2;
            // 
            // tbPrenom
            // 
            this.tbPrenom.Location = new System.Drawing.Point(250, 39);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(242, 20);
            this.tbPrenom.TabIndex = 1;
            // 
            // btnInscrire
            // 
            this.btnInscrire.Location = new System.Drawing.Point(1261, 39);
            this.btnInscrire.Name = "btnInscrire";
            this.btnInscrire.Size = new System.Drawing.Size(178, 79);
            this.btnInscrire.TabIndex = 0;
            this.btnInscrire.Text = "Inscrire";
            this.btnInscrire.UseVisualStyleBackColor = true;
            this.btnInscrire.Click += new System.EventHandler(this.btnInscrire_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbEtatNeige);
            this.groupBox2.Controls.Add(this.tbLongueur);
            this.groupBox2.Controls.Add(this.mtbDateHeure);
            this.groupBox2.Controls.Add(this.tbNomCourse);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.labDateCourse);
            this.groupBox2.Controls.Add(this.labNomCourse);
            this.groupBox2.Controls.Add(this.btnSlalom);
            this.groupBox2.Controls.Add(this.btnDescente);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(13, 277);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1485, 171);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Organiser course";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1002, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Code état neige : 1-Neige dure 0-Neige molle";
            // 
            // cbEtatNeige
            // 
            this.cbEtatNeige.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEtatNeige.FormattingEnabled = true;
            this.cbEtatNeige.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cbEtatNeige.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbEtatNeige.Location = new System.Drawing.Point(841, 61);
            this.cbEtatNeige.Name = "cbEtatNeige";
            this.cbEtatNeige.Size = new System.Drawing.Size(121, 21);
            this.cbEtatNeige.TabIndex = 9;
            // 
            // tbLongueur
            // 
            this.tbLongueur.Location = new System.Drawing.Point(841, 25);
            this.tbLongueur.Name = "tbLongueur";
            this.tbLongueur.Size = new System.Drawing.Size(121, 20);
            this.tbLongueur.TabIndex = 8;
            // 
            // mtbDateHeure
            // 
            this.mtbDateHeure.Location = new System.Drawing.Point(232, 62);
            this.mtbDateHeure.Mask = "00/00/0000 00:00";
            this.mtbDateHeure.Name = "mtbDateHeure";
            this.mtbDateHeure.Size = new System.Drawing.Size(115, 20);
            this.mtbDateHeure.TabIndex = 7;
            this.mtbDateHeure.ValidatingType = typeof(System.DateTime);
            // 
            // tbNomCourse
            // 
            this.tbNomCourse.Location = new System.Drawing.Point(232, 25);
            this.tbNomCourse.Name = "tbNomCourse";
            this.tbNomCourse.Size = new System.Drawing.Size(115, 20);
            this.tbNomCourse.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(648, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Etat neige (pour descente)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(648, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Longueur (en métres pour descente)";
            // 
            // labDateCourse
            // 
            this.labDateCourse.AutoSize = true;
            this.labDateCourse.Location = new System.Drawing.Point(127, 69);
            this.labDateCourse.Name = "labDateCourse";
            this.labDateCourse.Size = new System.Drawing.Size(99, 13);
            this.labDateCourse.TabIndex = 3;
            this.labDateCourse.Text = "Date/Heure course";
            // 
            // labNomCourse
            // 
            this.labNomCourse.AutoSize = true;
            this.labNomCourse.Location = new System.Drawing.Point(127, 32);
            this.labNomCourse.Name = "labNomCourse";
            this.labNomCourse.Size = new System.Drawing.Size(64, 13);
            this.labNomCourse.TabIndex = 2;
            this.labNomCourse.Text = "Nom course";
            // 
            // btnSlalom
            // 
            this.btnSlalom.Location = new System.Drawing.Point(768, 102);
            this.btnSlalom.Name = "btnSlalom";
            this.btnSlalom.Size = new System.Drawing.Size(311, 63);
            this.btnSlalom.TabIndex = 1;
            this.btnSlalom.Text = "Organiser slalom";
            this.btnSlalom.UseVisualStyleBackColor = true;
            this.btnSlalom.Click += new System.EventHandler(this.btnSlalom_Click);
            // 
            // btnDescente
            // 
            this.btnDescente.Location = new System.Drawing.Point(146, 99);
            this.btnDescente.Name = "btnDescente";
            this.btnDescente.Size = new System.Drawing.Size(339, 66);
            this.btnDescente.TabIndex = 0;
            this.btnDescente.Text = "Organiser descente";
            this.btnDescente.UseVisualStyleBackColor = true;
            this.btnDescente.Click += new System.EventHandler(this.btnDescente_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnQuitter);
            this.groupBox3.Controls.Add(this.btnReinitialise);
            this.groupBox3.Controls.Add(this.labDesignationCourse);
            this.groupBox3.Controls.Add(this.btnAttribuerDossard);
            this.groupBox3.Controls.Add(this.cbListeCoureur);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(13, 455);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1485, 185);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Descriptif coureur";
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(935, 50);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnQuitter.Size = new System.Drawing.Size(200, 50);
            this.btnQuitter.TabIndex = 5;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnReinitialise
            // 
            this.btnReinitialise.Location = new System.Drawing.Point(592, 50);
            this.btnReinitialise.Name = "btnReinitialise";
            this.btnReinitialise.Size = new System.Drawing.Size(285, 50);
            this.btnReinitialise.TabIndex = 4;
            this.btnReinitialise.Text = "Reinitialiser le formulaire";
            this.btnReinitialise.UseVisualStyleBackColor = true;
            this.btnReinitialise.Click += new System.EventHandler(this.btnReinitialise_Click);
            // 
            // labDesignationCourse
            // 
            this.labDesignationCourse.AutoSize = true;
            this.labDesignationCourse.Location = new System.Drawing.Point(628, 16);
            this.labDesignationCourse.Name = "labDesignationCourse";
            this.labDesignationCourse.Size = new System.Drawing.Size(0, 13);
            this.labDesignationCourse.TabIndex = 3;
            // 
            // btnAttribuerDossard
            // 
            this.btnAttribuerDossard.Location = new System.Drawing.Point(146, 50);
            this.btnAttribuerDossard.Name = "btnAttribuerDossard";
            this.btnAttribuerDossard.Size = new System.Drawing.Size(319, 50);
            this.btnAttribuerDossard.TabIndex = 1;
            this.btnAttribuerDossard.Text = "Attribuer dossard";
            this.btnAttribuerDossard.UseVisualStyleBackColor = true;
            this.btnAttribuerDossard.Click += new System.EventHandler(this.btnAttribuerDossard_Click);
            // 
            // cbListeCoureur
            // 
            this.cbListeCoureur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbListeCoureur.FormattingEnabled = true;
            this.cbListeCoureur.Location = new System.Drawing.Point(19, 132);
            this.cbListeCoureur.Name = "cbListeCoureur";
            this.cbListeCoureur.Size = new System.Drawing.Size(1447, 21);
            this.cbListeCoureur.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1510, 652);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Formulaire organisation course de ski coupe du monde";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnInscrire;
        private System.Windows.Forms.Label labClassWCSL;
        private System.Windows.Forms.Label labClassFIS;
        private System.Windows.Forms.Label labNom;
        private System.Windows.Forms.Label labPrenom;
        private System.Windows.Forms.TextBox tbClassWCSL;
        private System.Windows.Forms.TextBox tbClassFIS;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbEtatNeige;
        private System.Windows.Forms.TextBox tbLongueur;
        private System.Windows.Forms.MaskedTextBox mtbDateHeure;
        private System.Windows.Forms.TextBox tbNomCourse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labDateCourse;
        private System.Windows.Forms.Label labNomCourse;
        private System.Windows.Forms.Button btnSlalom;
        private System.Windows.Forms.Button btnDescente;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAttribuerDossard;
        private System.Windows.Forms.ComboBox cbListeCoureur;
        private System.Windows.Forms.Label labDesignationCourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbListeComp;
        private System.Windows.Forms.Button btnReinitialise;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

