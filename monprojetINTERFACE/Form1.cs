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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAjouterEtudiant formAjouterE = new FormAjouterEtudiant();
            formAjouterE.Show();
        }

        private void afficherToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormAfficherEtudiant formAfficherE = new FormAfficherEtudiant();
            formAfficherE.Show();
        }

        private void quiterToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            int nombre_etudiant = etudiantBO.GetTous().Count;
            int nombre_professeur = professeurBO.GetTous().Count;
            int nombre_element = nombre_etudiant + nombre_professeur;
            labelComp.Text = nombre_element + " éléments dans la base : " + nombre_etudiant + " étudiants et " + nombre_professeur + " professeurs.";

        }

        private void importerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormImporter formImporter = new FormImporter();
            formImporter.Show();
        }

        private void exporterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExporter formExporter = new FormExporter();
            formExporter.Show();
        }
        
        private void chercher_Click(object sender, EventArgs e)
        {
            List<personne> P_trouver = new List<personne>();

              P_trouver = personneBO.chercher(ch_CNI.Text);
               
                   FormAfficherEtudiant formTouver = new FormAfficherEtudiant(P_trouver);
                    formTouver.Show();
         }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ch_CNI.Text = "taper le CNI ici ";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ch_CNI.Text = "taper le NOM ici ";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            ch_CNI.Text = "taper le PRENOM ici ";
        }

    }
}
