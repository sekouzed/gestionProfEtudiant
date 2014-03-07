namespace monprojetINTERFACE
{
    partial class FormImporter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImporter));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.radetudiant = new System.Windows.Forms.RadioButton();
            this.radprof = new System.Windows.Forms.RadioButton();
            this.bt_importer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nomFichier = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::monprojetINTERFACE.Properties.Resources.ici_gif2_;
            this.pictureBox2.Location = new System.Drawing.Point(176, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(106, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 44;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // radetudiant
            // 
            this.radetudiant.AutoSize = true;
            this.radetudiant.BackColor = System.Drawing.Color.Transparent;
            this.radetudiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radetudiant.Location = new System.Drawing.Point(190, 66);
            this.radetudiant.Name = "radetudiant";
            this.radetudiant.Size = new System.Drawing.Size(187, 17);
            this.radetudiant.TabIndex = 42;
            this.radetudiant.TabStop = true;
            this.radetudiant.Text = "Importer dans la liste des étudiants";
            this.radetudiant.UseVisualStyleBackColor = false;
            this.radetudiant.CheckedChanged += new System.EventHandler(this.radetudiant_CheckedChanged);
            // 
            // radprof
            // 
            this.radprof.AutoSize = true;
            this.radprof.BackColor = System.Drawing.Color.Transparent;
            this.radprof.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radprof.Location = new System.Drawing.Point(190, 89);
            this.radprof.Name = "radprof";
            this.radprof.Size = new System.Drawing.Size(198, 17);
            this.radprof.TabIndex = 43;
            this.radprof.TabStop = true;
            this.radprof.Text = "Importer dans la liste des professeurs";
            this.radprof.UseVisualStyleBackColor = false;
            this.radprof.CheckedChanged += new System.EventHandler(this.radprof_CheckedChanged);
            // 
            // bt_importer
            // 
            this.bt_importer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_importer.ForeColor = System.Drawing.Color.Black;
            this.bt_importer.Location = new System.Drawing.Point(190, 112);
            this.bt_importer.Name = "bt_importer";
            this.bt_importer.Size = new System.Drawing.Size(198, 29);
            this.bt_importer.TabIndex = 41;
            this.bt_importer.Text = "Importer";
            this.bt_importer.UseVisualStyleBackColor = true;
            this.bt_importer.Click += new System.EventHandler(this.bt_importer_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::monprojetINTERFACE.Properties.Resources.Untitled_11;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(44, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 75);
            this.button1.TabIndex = 45;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Title = "Selectionner le fichier à importer";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::monprojetINTERFACE.Properties.Resources.ici_gif2_;
            this.pictureBox1.Location = new System.Drawing.Point(44, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // nomFichier
            // 
            this.nomFichier.AutoSize = true;
            this.nomFichier.BackColor = System.Drawing.Color.Transparent;
            this.nomFichier.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomFichier.Location = new System.Drawing.Point(47, 47);
            this.nomFichier.Name = "nomFichier";
            this.nomFichier.Size = new System.Drawing.Size(0, 13);
            this.nomFichier.TabIndex = 49;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::monprojetINTERFACE.Properties.Resources._1024x768__19_;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(510, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 29);
            this.button2.TabIndex = 50;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.bt_importer);
            this.groupBox1.Controls.Add(this.nomFichier);
            this.groupBox1.Controls.Add(this.radetudiant);
            this.groupBox1.Controls.Add(this.radprof);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Location = new System.Drawing.Point(182, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 174);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(104, 108);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 56;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 78;
            this.label1.Text = "retour";
            // 
            // FormImporter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::monprojetINTERFACE.Properties.Resources._1024x768__19_;
            this.ClientSize = new System.Drawing.Size(684, 337);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.MaximumSize = new System.Drawing.Size(700, 375);
            this.MinimumSize = new System.Drawing.Size(700, 375);
            this.Name = "FormImporter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Importer à partir d\'un fichier";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton radetudiant;
        private System.Windows.Forms.RadioButton radprof;
        private System.Windows.Forms.Button bt_importer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label nomFichier;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
    }
}