namespace monprojetINTERFACE
{
    partial class FormAjouterEtudiant
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAjouterEtudiant));
            this.bt_fermer = new System.Windows.Forms.Button();
            this.bt_ajouter = new System.Windows.Forms.Button();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_prenom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_CIN = new System.Windows.Forms.TextBox();
            this.txt_CNE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rad_etudiant = new System.Windows.Forms.RadioButton();
            this.rad_prof = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.importerÀPartirDunFichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_fermer
            // 
            this.bt_fermer.BackgroundImage = global::monprojetINTERFACE.Properties.Resources._1024x768__19_;
            this.bt_fermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bt_fermer.ForeColor = System.Drawing.Color.Black;
            this.bt_fermer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bt_fermer.Location = new System.Drawing.Point(525, 284);
            this.bt_fermer.Name = "bt_fermer";
            this.bt_fermer.Size = new System.Drawing.Size(92, 29);
            this.bt_fermer.TabIndex = 35;
            this.bt_fermer.Text = "Annuler";
            this.bt_fermer.UseVisualStyleBackColor = true;
            this.bt_fermer.Click += new System.EventHandler(this.bt_fermer_Click);
            // 
            // bt_ajouter
            // 
            this.bt_ajouter.BackgroundImage = global::monprojetINTERFACE.Properties.Resources._1024x768__19_;
            this.bt_ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bt_ajouter.ForeColor = System.Drawing.Color.Black;
            this.bt_ajouter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bt_ajouter.Location = new System.Drawing.Point(400, 284);
            this.bt_ajouter.Name = "bt_ajouter";
            this.bt_ajouter.Size = new System.Drawing.Size(119, 29);
            this.bt_ajouter.TabIndex = 32;
            this.bt_ajouter.Text = "Ajouter";
            this.bt_ajouter.UseVisualStyleBackColor = true;
            this.bt_ajouter.Click += new System.EventHandler(this.bt_ajouter_Click);
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(16, 151);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(186, 23);
            this.txt_nom.TabIndex = 33;
            // 
            // txt_prenom
            // 
            this.txt_prenom.Location = new System.Drawing.Point(16, 199);
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.Size = new System.Drawing.Size(186, 23);
            this.txt_prenom.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(13, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 7;
            // 
            // txt_CIN
            // 
            this.txt_CIN.Location = new System.Drawing.Point(16, 55);
            this.txt_CIN.Name = "txt_CIN";
            this.txt_CIN.Size = new System.Drawing.Size(186, 23);
            this.txt_CIN.TabIndex = 9;
            // 
            // txt_CNE
            // 
            this.txt_CNE.Location = new System.Drawing.Point(16, 103);
            this.txt_CNE.Name = "txt_CNE";
            this.txt_CNE.Size = new System.Drawing.Size(186, 23);
            this.txt_CNE.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(13, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(13, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(13, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 20;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txt_CIN);
            this.groupBox2.Controls.Add(this.txt_CNE);
            this.groupBox2.Controls.Add(this.txt_nom);
            this.groupBox2.Controls.Add(this.txt_prenom);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox2.Location = new System.Drawing.Point(400, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 232);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            // 
            // rad_etudiant
            // 
            this.rad_etudiant.AutoSize = true;
            this.rad_etudiant.BackColor = System.Drawing.Color.Transparent;
            this.rad_etudiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.rad_etudiant.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rad_etudiant.Location = new System.Drawing.Point(140, 50);
            this.rad_etudiant.Name = "rad_etudiant";
            this.rad_etudiant.Size = new System.Drawing.Size(103, 21);
            this.rad_etudiant.TabIndex = 37;
            this.rad_etudiant.TabStop = true;
            this.rad_etudiant.Text = "ETUDIANT";
            this.rad_etudiant.UseVisualStyleBackColor = false;
            this.rad_etudiant.CheckedChanged += new System.EventHandler(this.rad_etudiant_CheckedChanged);
            // 
            // rad_prof
            // 
            this.rad_prof.AutoSize = true;
            this.rad_prof.BackColor = System.Drawing.Color.Transparent;
            this.rad_prof.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.rad_prof.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rad_prof.Location = new System.Drawing.Point(140, 72);
            this.rad_prof.Name = "rad_prof";
            this.rad_prof.Size = new System.Drawing.Size(130, 21);
            this.rad_prof.TabIndex = 38;
            this.rad_prof.TabStop = true;
            this.rad_prof.Text = "PROFESSEUR";
            this.rad_prof.UseVisualStyleBackColor = false;
            this.rad_prof.CheckedChanged += new System.EventHandler(this.rad_prof_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::monprojetINTERFACE.Properties.Resources.ici_gif2_;
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(125, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(106, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importerÀPartirDunFichierToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(224, 26);
            // 
            // importerÀPartirDunFichierToolStripMenuItem
            // 
            this.importerÀPartirDunFichierToolStripMenuItem.Name = "importerÀPartirDunFichierToolStripMenuItem";
            this.importerÀPartirDunFichierToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.importerÀPartirDunFichierToolStripMenuItem.Text = "Importer à partir d\'un fichier";
            this.importerÀPartirDunFichierToolStripMenuItem.Click += new System.EventHandler(this.importerÀPartirDunFichierToolStripMenuItem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(64, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 41;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::monprojetINTERFACE.Properties.Resources.Untitled_12;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(101, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(104, 108);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 56;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(12, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 78;
            this.label6.Text = "retour";
            // 
            // FormAjouterEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::monprojetINTERFACE.Properties.Resources._1024x768__19_;
            this.ClientSize = new System.Drawing.Size(684, 337);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.ControlBox = false;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.rad_etudiant);
            this.Controls.Add(this.rad_prof);
            this.Controls.Add(this.bt_ajouter);
            this.Controls.Add(this.bt_fermer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 375);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(700, 375);
            this.Name = "FormAjouterEtudiant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter un élément";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_fermer;
        private System.Windows.Forms.Button bt_ajouter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rad_etudiant;
        private System.Windows.Forms.RadioButton rad_prof;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem importerÀPartirDunFichierToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_prenom;
        private System.Windows.Forms.TextBox txt_CIN;
        private System.Windows.Forms.TextBox txt_CNE;

    }
}