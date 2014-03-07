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
    public partial class FormAfficherEtudiant : Form
    {
        
        public FormAfficherEtudiant()
        {
            InitializeComponent();
        }
        public FormAfficherEtudiant(List<personne> listeAafficher)
        {
            InitializeComponent();
            dataGridView3.DataSource = listeAafficher;
        }

        private void FormAfficherEtudiant_Load(object sender, EventArgs e)
        {
            
            dataGridView2.Visible = false;
            dataGridView1.Visible = false;
            dataGridView3.Visible = true;
            Compt();
        }

        private void tOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView3.DataSource = personneBO.GetTous();
            dataGridView2.Visible = false;
            dataGridView1.Visible = false;
            dataGridView3.Visible = true;
            Compt();
        }

        private void eTUDIANTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = etudiantBO.GetTous();
            dataGridView3.Visible = false;
            dataGridView2.Visible = false;
            dataGridView1.Visible = true;
            Compt();

        }

        private void pROFESSEURSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = professeurBO.GetTous();
            dataGridView3.Visible = false;
            dataGridView1.Visible = false;
            dataGridView2.Visible = true;
            Compt();
        }

        public void Compt()
        {
            int nombre_etudiant = etudiantBO.GetTous().Count;
            int nombre_professeur = professeurBO.GetTous().Count;
            int nombre_element = nombre_etudiant + nombre_professeur;
            labelComp2.Text = nombre_element + " éléments dans la liste : " + nombre_etudiant + " étudiants et " + nombre_professeur + " professeurs.";
       
        }

        private void exporterDansUnFichierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExporter formExporter = new FormExporter();
            formExporter.Show();
            this.Close();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chercher_Click(object sender, EventArgs e)
        {
            personne P_trouver = new personne();
            P_trouver = personneBO.trouver(chCNI.Text);
            if (P_trouver == null)
            {
                MessageBox.Show("Cette personne n'est pas dans la liste");
            }
            else
            {
                FormTrouver formTouver = new FormTrouver(P_trouver);
                formTouver.Show();
                this.Close();
            }
        }
 
    }
}
