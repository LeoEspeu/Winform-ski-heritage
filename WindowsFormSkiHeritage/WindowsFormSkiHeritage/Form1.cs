using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormSkiHeritage
{
    public partial class Form1 : Form
    {
        private List<Competiteur> lesCompetiteurs = new List<Competiteur>();
        private Int32 idCoureur = 1;
        private CourseDescente laDescente;
        private CourseSlalom leSlalom;
        private int course;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInscrire_Click(object sender, EventArgs e)
        {
            try
            {
                int doublon = 0;
                if(tbNom.Text=="" || tbPrenom.Text == "")
                {
                    throw new Exception("Toutes les cases doivent être remplis");
                }
                foreach (Competiteur i in lesCompetiteurs)
                {
                    if (i.ClassementFIS == Convert.ToInt32(tbClassFIS.Text) || Convert.ToInt32(tbClassFIS.Text)<1)
                    {
                        doublon = 1;
                    }
                    if (i.ClassementWCSL == Convert.ToInt32(tbClassWCSL.Text) || Convert.ToInt32(tbClassWCSL.Text)<1)
                    {
                        doublon = 1;
                    }
                }
                if (doublon == 1)
                {
                    throw new Exception("classement WCSL/FIS invalide");
                }
                else
                {
                    lesCompetiteurs.Add(new Competiteur(idCoureur, tbNom.Text, tbPrenom.Text, Convert.ToInt32(tbClassFIS.Text), Convert.ToInt32(tbClassWCSL.Text)));
                    cbListeComp.Items.Clear();
                    foreach (Competiteur m in lesCompetiteurs)
                    {
                        cbListeComp.Items.Add(m);
                    }
                    cbListeComp.Text = cbListeComp.Items[0].ToString();
                    idCoureur = idCoureur + 1;
                    if (lesCompetiteurs.Count >= 2)
                    {
                        groupBox2.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Erreur de remplissage du formulaire",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnDescente_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbNomCourse.Text == "")
                {
                    throw new Exception("Toutes les cases doivent être remplis pour la course concernées");
                }
                labDesignationCourse.Text = "Liste des coureurs participant à l'epreuve de coupe du monde "+tbNomCourse.Text+" organisé le "+mtbDateHeure.Text+" sur une longueur de "+tbLongueur.Text+".";
                laDescente = new CourseDescente(tbNomCourse.Text,Convert.ToDateTime(mtbDateHeure.Text),lesCompetiteurs,Convert.ToInt32(tbLongueur.Text),Convert.ToInt32(cbEtatNeige.Text));
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                groupBox3.Enabled = true;
                course = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur de remplissage du formulaire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSlalom_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbNomCourse.Text == "")
                {
                    throw new Exception("Toutes les cases doivent être remplis pour la course concernées");
                }
                labDesignationCourse.Text = "Liste des coureurs participant à l'epreuve de coupe du monde " + tbNomCourse.Text + " organisé le " + mtbDateHeure.Text+".";
                leSlalom = new CourseSlalom(tbNomCourse.Text, Convert.ToDateTime(mtbDateHeure.Text), lesCompetiteurs);
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                groupBox3.Enabled = true;
                course = 2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur de remplissage du formulaire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAttribuerDossard_Click(object sender, EventArgs e)
        {
            try
            {
                if (course == 1)
                {
                    laDescente.TraitementDossards();
                    foreach (Participation p  in laDescente.LesParticipants)
                    {
                        cbListeCoureur.Items.Add(p);
                    }
                }
                else
                {
                    leSlalom.TraitementDossards();
                    foreach (Participation p in leSlalom.LesParticipants)
                    {
                        cbListeCoureur.Items.Add(p);
                    }
                }
                cbListeCoureur.Text = cbListeCoureur.Items[0].ToString();
                btnAttribuerDossard.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur de remplissage du formulaire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReinitialise_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous reinitialliser le formulaire ? Toutes les données enregistrés seront perdus !", "Avertissement avant reinitialisation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tbClassFIS.Text = "";
                tbClassWCSL.Text = "";
                tbLongueur.Text = "";
                tbNom.Text = "";
                tbNomCourse.Text = "";
                tbPrenom.Text = "";
                labDesignationCourse.Text = "";
                mtbDateHeure.Text = "";
                cbListeCoureur.Items.Clear();
                cbListeComp.Items.Clear();
                groupBox1.Enabled = true;
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                btnAttribuerDossard.Enabled = true;
                idCoureur = 1;
                lesCompetiteurs.Clear();
                if (course == 1)
                {
                    laDescente.LesParticipants.Clear();
                }
                else
                {
                    leSlalom.LesParticipants.Clear();
                }
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Voulez vous quitter définitivement l'application","Dernier avertissement avant fermeture de l'application", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
