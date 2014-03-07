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
    public partial class FormExporter : Form
    {
        public FormExporter()
        {
            InitializeComponent();
        }

        private void bt_exporter_Click(object sender, EventArgs e)
        {
           try
            {
                if (radetudiant.Checked)
                {
                    saveFileDialog1.ShowDialog();
                    string fichier = saveFileDialog1.FileName;
                    etudiantBO.exporter(fichier);
                    MessageBox.Show("La liste des étudiants a été bien exporter le fichier: " + fichier);
                }
                else 
                {
                    if (radprof.Checked)
                    {
                        saveFileDialog1.ShowDialog();
                        string fichier = saveFileDialog1.FileName;
                        professeurBO.exporter(fichier);
                        MessageBox.Show("La liste des professeurs a été bien exporter le fichier: " + fichier);
                    }
                    else 
                    { 
                        if (radtout.Checked)
                        {
                            saveFileDialog1.ShowDialog();
                            string fichier = saveFileDialog1.FileName;
                            personneBO.exporter(fichier);
                            MessageBox.Show("La liste des étudiants a été bien exporter le fichier: " + fichier);
                        }
                        else
                             MessageBox.Show("Vous devez d'abord caucher : ETUDIANT ou PROFESSEUR !");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            button2.Visible = true;
            pictureBox1.Visible = false;
            button2.Text = "Terminer";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radprof_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox1.Visible = true;
            saveFileDialog1.FileName = "liste des professeurs";
        }

        private void radetudiant_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox1.Visible = true;
            saveFileDialog1.FileName = "liste des etudiants";
        }

        private void radtout_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox1.Visible = true;
            saveFileDialog1.FileName = "liste des prersonnes";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
