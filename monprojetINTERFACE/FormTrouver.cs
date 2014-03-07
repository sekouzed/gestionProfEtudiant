using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using monprojetBO;
using monprojetDAL;

namespace monprojetINTERFACE
{
    public partial class FormTrouver : Form
    {
        static personne pTrouver = new personne();
        static string ancienCNI;
        public FormTrouver(personne P)
        {
            InitializeComponent();
            pTrouver = P;
        }

        private void FormTrouver_Load(object sender, EventArgs e)
        {
             if (pTrouver.statut == "Etudiant")
                {
                    etudiant E = new etudiant();
                    E = etudiantBO.chercher(pTrouver.CNI);

                    textCNI.Text = E.CNI;
                    textNom.Text = E.nom;
                    textPrenom.Text = E.prenom;
                    textCNE.Text = E.CNE;
                    groupBox1.Text = "Statut : ETUDIANT";
                 }
                else
                {
                    if (pTrouver.statut == "Professeur")
                    {
                        professeur P = new professeur();
                        P = professeurBO.chercher(pTrouver.CNI);

                        textCNI.Text = P.CNI;
                        textNom.Text = P.nom;
                        textPrenom.Text = P.prenom;
                        textCNE.Text = P.matiere;
                        groupBox1.Text = "Statut : PROFESSEUR";
                    }
                }

             ancienCNI = pTrouver.CNI;
             labCNI.Text = "CNI :     " + textCNI.Text;
             labNOM.Text = "Nom :     " + textNom.Text;
             labPRENOM.Text = "Prénom :  " + textPrenom.Text ;
             labCNE.Text = "Matière : " + textCNE.Text;
            }


        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labCNI.Text = "CNI :     ";
            labNOM.Text = "Nom :     ";
            labPRENOM.Text = "Prénom :  ";
            labCNE.Text = "Matière : ";
            textCNI.Visible = true;
            textNom.Visible = true;
            textPrenom.Visible = true;
            textCNE.Visible = true;
            bt_modiffier.Visible = true; 
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (groupBox1.Text == "Statut : ETUDIANT")
                {
                    etudiantBO.Supprimer(ancienCNI);
                    MessageBox.Show("Cet élément a ete bien supprimer de la liste des étudiants");
                    groupBox1.Text = "Etudiant supprimé";
                }
                else
                {
                    if (groupBox1.Text == "Statut : PROFESSEUR")
                    {
                        professeurBO.Supprimer(ancienCNI);
                        MessageBox.Show("Cet élément a ete bien supprimer de la liste des professeurs");
                        groupBox1.Text = "Professeur supprimé";
                    }
                }
            supprimerToolStripMenuItem.Enabled = false;
            modifierToolStripMenuItem.Enabled = false;
            textCNI.Visible = false;
            textNom.Visible = false; ;
            textPrenom.Visible = false;
            textCNE.Visible = false;
       }

        private void bt_modiffier_Click(object sender, EventArgs e)
        {
            if ((textCNI.Text != labCNI.Text) || (textNom.Text != labNOM.Text) || (textPrenom.Text != labNOM.Text) || (textCNE.Text != labCNE.Text))
            {
                if (groupBox1.Text == "Statut : ETUDIANT")
                    {
                        etudiantBO.modifier(ancienCNI, textCNI.Text, textCNE.Text, textNom.Text, textPrenom.Text);
                        MessageBox.Show("Cet étudiant a été bien devez modifier ");
                    }
                    else
                    {
                        if (groupBox1.Text == "Statut : PROFESSEUR")
                        {
                            professeurBO.modifier(ancienCNI, textCNI.Text, textCNE.Text, textNom.Text, textPrenom.Text);
                            MessageBox.Show("Cet professeur a été bien devez modifier ");
                        }
                    }
                ancienCNI = textCNI.Text;
              }
            else 
            {
                MessageBox.Show("Vous n'avez rien modifier");
            }

            bt_modiffier.Visible = false;
            textCNI.Visible = false;
            textNom.Visible = false;
            textPrenom.Visible = false;
            textCNE.Visible = false;
            labCNI.Text = "CNI :     " + textCNI.Text;
            labNOM.Text = "Nom :     " + textNom.Text;
            labPRENOM.Text = "Prénom :  " + textPrenom.Text;
            labCNE.Text = "Matière : " + textCNE.Text;
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAfficherEtudiant formAfficherE = new FormAfficherEtudiant();
            formAfficherE.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}