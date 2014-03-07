using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using monprojetBO;

namespace monprojetINTERFACE
{
    public partial class FormImporter : Form
    {
        public FormImporter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            nomFichier.Text= openFileDialog1.FileName;
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
        }

        private void bt_importer_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader fichier = new StreamReader(nomFichier.Text);
                string ligne = fichier.ReadLine();
                string[] champ;
                if (radetudiant.Checked)
                {
                    while (ligne != null)
                    {
                        champ = ligne.Split(',');
                        etudiantBO.Ajouter(champ[0], champ[1], champ[2], champ[3]);
                                           // CIN    ,  Nom     , Prénom  , CNE
                        ligne = fichier.ReadLine();
                    }
                    MessageBox.Show("Le contenu du fichier a été bien importer dans la liste des étudiants.");
                }
                else
                {
                    if (radprof.Checked)
                    {

                        while (ligne != null)
                        {
                            champ = ligne.Split(',');
                            professeurBO.Ajouter(champ[0], champ[1], champ[2], champ[3]);
                            ligne = fichier.ReadLine();
                        }
                        MessageBox.Show("Le contenu du fichier a été bien importer dans la liste des professeurs.");
                    }
                    else
                        MessageBox.Show("Vous devez d'abord caucher : ETUDIANT ou PROFESSEUR !");
                }

                fichier.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue au cours de la lecture !");
                MessageBox.Show(ex.Message);
            }
            button2.Text = "Terminer";
        }

        private void radprof_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
        }

        private void radetudiant_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
