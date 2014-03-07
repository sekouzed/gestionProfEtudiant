namespace monprojetINTERFACE
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AjouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.importerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exporterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quiterToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.labelComp = new System.Windows.Forms.Label();
            this.auteur = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.ch_CNI = new System.Windows.Forms.TextBox();
            this.chercher = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::monprojetINTERFACE.Properties.Resources.Z;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Font = new System.Drawing.Font("Poor Richard", 36.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AjouterToolStripMenuItem,
            this.afficherToolStripMenuItem1,
            this.importerToolStripMenuItem,
            this.exporterToolStripMenuItem,
            this.quiterToolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 119);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AjouterToolStripMenuItem
            // 
            this.AjouterToolStripMenuItem.Name = "AjouterToolStripMenuItem";
            this.AjouterToolStripMenuItem.Size = new System.Drawing.Size(194, 115);
            this.AjouterToolStripMenuItem.Text = " Ajouter ";
            this.AjouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // afficherToolStripMenuItem1
            // 
            this.afficherToolStripMenuItem1.Name = "afficherToolStripMenuItem1";
            this.afficherToolStripMenuItem1.Size = new System.Drawing.Size(211, 115);
            this.afficherToolStripMenuItem1.Text = "Visionner";
            this.afficherToolStripMenuItem1.Click += new System.EventHandler(this.afficherToolStripMenuItem1_Click);
            // 
            // importerToolStripMenuItem
            // 
            this.importerToolStripMenuItem.Name = "importerToolStripMenuItem";
            this.importerToolStripMenuItem.Size = new System.Drawing.Size(194, 115);
            this.importerToolStripMenuItem.Text = "Importer";
            this.importerToolStripMenuItem.Click += new System.EventHandler(this.importerToolStripMenuItem_Click);
            // 
            // exporterToolStripMenuItem
            // 
            this.exporterToolStripMenuItem.Name = "exporterToolStripMenuItem";
            this.exporterToolStripMenuItem.Size = new System.Drawing.Size(193, 115);
            this.exporterToolStripMenuItem.Text = "Exporter";
            this.exporterToolStripMenuItem.Click += new System.EventHandler(this.exporterToolStripMenuItem_Click);
            // 
            // quiterToolStripMenuItem2
            // 
            this.quiterToolStripMenuItem2.Name = "quiterToolStripMenuItem2";
            this.quiterToolStripMenuItem2.Size = new System.Drawing.Size(184, 115);
            this.quiterToolStripMenuItem2.Text = "  Quiter ";
            this.quiterToolStripMenuItem2.Click += new System.EventHandler(this.quiterToolStripMenuItem2_Click);
            // 
            // labelComp
            // 
            this.labelComp.AutoSize = true;
            this.labelComp.BackColor = System.Drawing.Color.Transparent;
            this.labelComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelComp.Location = new System.Drawing.Point(23, 508);
            this.labelComp.Name = "labelComp";
            this.labelComp.Size = new System.Drawing.Size(46, 17);
            this.labelComp.TabIndex = 9;
            this.labelComp.Text = "compt";
            // 
            // auteur
            // 
            this.auteur.AutoSize = true;
            this.auteur.BackColor = System.Drawing.Color.Transparent;
            this.auteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auteur.ForeColor = System.Drawing.Color.Black;
            this.auteur.Location = new System.Drawing.Point(687, 599);
            this.auteur.Name = "auteur";
            this.auteur.Size = new System.Drawing.Size(325, 24);
            this.auteur.TabIndex = 8;
            this.auteur.Text = "réaliser par DIOUBATE SEKOU, LSI-1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(285, 49);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(744, 349);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 60;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(12, 386);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 119);
            this.panel1.TabIndex = 62;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.BackColor = System.Drawing.Color.Transparent;
            this.radioButton3.Font = new System.Drawing.Font("Poor Richard", 12F);
            this.radioButton3.Location = new System.Drawing.Point(131, 325);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(73, 23);
            this.radioButton3.TabIndex = 60;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Prénom";
            this.radioButton3.UseVisualStyleBackColor = false;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Font = new System.Drawing.Font("Poor Richard", 12F);
            this.radioButton2.Location = new System.Drawing.Point(79, 325);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(56, 23);
            this.radioButton2.TabIndex = 59;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Nom";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Font = new System.Drawing.Font("Poor Richard", 12F);
            this.radioButton1.Location = new System.Drawing.Point(26, 325);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(53, 23);
            this.radioButton1.TabIndex = 58;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "CNI";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // ch_CNI
            // 
            this.ch_CNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch_CNI.ForeColor = System.Drawing.SystemColors.MenuText;
            this.ch_CNI.Location = new System.Drawing.Point(26, 354);
            this.ch_CNI.Name = "ch_CNI";
            this.ch_CNI.Size = new System.Drawing.Size(153, 20);
            this.ch_CNI.TabIndex = 56;
            // 
            // chercher
            // 
            this.chercher.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chercher.BackgroundImage")));
            this.chercher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chercher.ForeColor = System.Drawing.Color.Black;
            this.chercher.Location = new System.Drawing.Point(183, 352);
            this.chercher.Name = "chercher";
            this.chercher.Size = new System.Drawing.Size(27, 25);
            this.chercher.TabIndex = 57;
            this.chercher.UseVisualStyleBackColor = true;
            this.chercher.Click += new System.EventHandler(this.chercher_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::monprojetINTERFACE.Properties.Resources.KJHG;
            this.pictureBox1.Location = new System.Drawing.Point(4, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 265);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::monprojetINTERFACE.Properties.Resources._1024x768__19_;
            this.ClientSize = new System.Drawing.Size(1024, 632);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.auteur);
            this.Controls.Add(this.ch_CNI);
            this.Controls.Add(this.labelComp);
            this.Controls.Add(this.chercher);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1040, 670);
            this.MinimumSize = new System.Drawing.Size(1040, 670);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestiOn des PrOfs et EtudiAnts | Sékou Dioubaté, LSI-1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label auteur;
        private System.Windows.Forms.Label labelComp;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AjouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quiterToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem importerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exporterToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox ch_CNI;
        private System.Windows.Forms.Button chercher;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

