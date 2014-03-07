using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using monprojetDAL;
using monprojetBO;

namespace monprojetINTERFACE
{
    public partial class FormAjouterEtudiant : Form
    {
        public FormAjouterEtudiant()
        {
            InitializeComponent();
        }

        private void bt_ajouter_Click(object sender, EventArgs e)
        {
            if (txt_CIN.Text == "" || txt_nom.Text == "" || txt_prenom.Text == "" || txt_CNE.Text == "")
                MessageBox.Show("Veillez remplire tous les champs, s'il vous plait !");
            else
            {
                personne P = new personne();
                P = personneBO.trouver(txt_CIN.Text);
                if (P != null)
                {
                    MessageBox.Show("Une personne existe dejà avec ce CNI");
                }
                else
                {

                    if (rad_etudiant.Checked)
                    {
                        etudiantBO.Ajouter(txt_CIN.Text, txt_CNE.Text, txt_nom.Text, txt_prenom.Text);
                        Compt();
                        bt_fermer.Text = "Terminer";
                        int nombre_etudiant = etudiantBO.GetTous().Count;
                        if (nombre_etudiant == 1)
                            MessageBox.Show(nombre_etudiant.ToString() + " étudiant ajouté dans la liste");
                        else
                            MessageBox.Show(nombre_etudiant.ToString() + " étudiants ajoutés dans la liste");
                    }
                    else
                    {
                        if (rad_prof.Checked)
                        {
                            professeurBO.Ajouter(txt_CIN.Text, txt_CNE.Text, txt_nom.Text, txt_prenom.Text);
                            Compt();
                            bt_fermer.Text = "Terminer";
                            int nombre_professeur = professeurBO.GetTous().Count;
                            if (nombre_professeur == 1)
                                MessageBox.Show(nombre_professeur.ToString() + " professeur ajouté dans la liste");
                            else
                                MessageBox.Show(nombre_professeur.ToString() + " professeur ajoutés dans la liste");
                        }
                        else
                        {
                            MessageBox.Show("Vous devez d'abord caucher : ETUDIANT ou PROFESSEUR !");
                        }
                    }
                }
            }
        }

        private void rad_prof_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            groupBox2.Text = "Ajouter un professeur";
            label4.Text = "CIN";
            label3.Text = "Matière de base";
            label2.Text = "Nom";
            label1.Text = "Prénom";
            txt_CIN.Clear(); ; txt_CNE.Clear(); txt_nom.Clear(); txt_prenom.Clear();
        }

        private void rad_etudiant_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            groupBox2.Text = "Ajouter un étudiant";
            label4.Text = "CIN";
            label3.Text = "CNE";
            label2.Text = "Nom";
            label1.Text = "Prénom";
            txt_CIN.Clear(); ; txt_CNE.Clear(); txt_nom.Clear(); txt_prenom.Clear();
        }

        private void importerÀPartirDunFichierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormImporter formImporter = new FormImporter();
            formImporter.Show();
            this.Close();
        }

        public void Compt()
        {
            int nombre_etudiant = etudiantBO.GetTous().Count;
            int nombre_professeur = professeurBO.GetTous().Count;
            int nombre_element = nombre_etudiant + nombre_professeur;
            label5.Text = nombre_element + " éléments dans la liste : " + nombre_etudiant + " étudiants et " + nombre_professeur + " professeurs.";

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
