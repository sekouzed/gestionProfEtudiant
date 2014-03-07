namespace monprojetINTERFACE
{
    partial class FormTrouver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTrouver));
            this.labCNI = new System.Windows.Forms.Label();
            this.textCNI = new System.Windows.Forms.TextBox();
            this.labNOM = new System.Windows.Forms.Label();
            this.labPRENOM = new System.Windows.Forms.Label();
            this.textCNE = new System.Windows.Forms.TextBox();
            this.bt_modiffier = new System.Windows.Forms.Button();
            this.labCNE = new System.Windows.Forms.Label();
            this.textNom = new System.Windows.Forms.TextBox();
            this.textPrenom = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labCNI
            // 
            this.labCNI.AutoSize = true;
            this.labCNI.BackColor = System.Drawing.Color.Transparent;
            this.labCNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCNI.ForeColor = System.Drawing.Color.Black;
            this.labCNI.Location = new System.Drawing.Point(7, 31);
            this.labCNI.Name = "labCNI";
            this.labCNI.Size = new System.Drawing.Size(38, 17);
            this.labCNI.TabIndex = 67;
            this.labCNI.Text = "CNI :";
            // 
            // textCNI
            // 
            this.textCNI.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textCNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCNI.Location = new System.Drawing.Point(87, 30);
            this.textCNI.Name = "textCNI";
            this.textCNI.Size = new System.Drawing.Size(102, 20);
            this.textCNI.TabIndex = 68;
            this.textCNI.Visible = false;
            // 
            // labNOM
            // 
            this.labNOM.AutoSize = true;
            this.labNOM.BackColor = System.Drawing.Color.Transparent;
            this.labNOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNOM.ForeColor = System.Drawing.Color.Black;
            this.labNOM.Location = new System.Drawing.Point(6, 57);
            this.labNOM.Name = "labNOM";
            this.labNOM.Size = new System.Drawing.Size(45, 17);
            this.labNOM.TabIndex = 61;
            this.labNOM.Text = "Nom :";
            // 
            // labPRENOM
            // 
            this.labPRENOM.AutoSize = true;
            this.labPRENOM.BackColor = System.Drawing.Color.Transparent;
            this.labPRENOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPRENOM.ForeColor = System.Drawing.Color.Black;
            this.labPRENOM.Location = new System.Drawing.Point(7, 83);
            this.labPRENOM.Name = "labPRENOM";
            this.labPRENOM.Size = new System.Drawing.Size(65, 17);
            this.labPRENOM.TabIndex = 62;
            this.labPRENOM.Text = "Prénom :";
            // 
            // textCNE
            // 
            this.textCNE.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textCNE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCNE.Location = new System.Drawing.Point(87, 108);
            this.textCNE.Name = "textCNE";
            this.textCNE.Size = new System.Drawing.Size(102, 20);
            this.textCNE.TabIndex = 66;
            this.textCNE.Visible = false;
            // 
            // bt_modiffier
            // 
            this.bt_modiffier.BackgroundImage = global::monprojetINTERFACE.Properties.Resources._1024x768__19_;
            this.bt_modiffier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_modiffier.ForeColor = System.Drawing.Color.Black;
            this.bt_modiffier.Location = new System.Drawing.Point(437, 208);
            this.bt_modiffier.Name = "bt_modiffier";
            this.bt_modiffier.Size = new System.Drawing.Size(102, 27);
            this.bt_modiffier.TabIndex = 60;
            this.bt_modiffier.Text = "Enregistrer";
            this.bt_modiffier.UseVisualStyleBackColor = true;
            this.bt_modiffier.Visible = false;
            this.bt_modiffier.Click += new System.EventHandler(this.bt_modiffier_Click);
            // 
            // labCNE
            // 
            this.labCNE.AutoSize = true;
            this.labCNE.BackColor = System.Drawing.Color.Transparent;
            this.labCNE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCNE.ForeColor = System.Drawing.Color.Black;
            this.labCNE.Location = new System.Drawing.Point(7, 109);
            this.labCNE.Name = "labCNE";
            this.labCNE.Size = new System.Drawing.Size(44, 17);
            this.labCNE.TabIndex = 63;
            this.labCNE.Text = "CNE :";
            // 
            // textNom
            // 
            this.textNom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNom.Location = new System.Drawing.Point(87, 56);
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(102, 20);
            this.textNom.TabIndex = 64;
            this.textNom.Visible = false;
            // 
            // textPrenom
            // 
            this.textPrenom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPrenom.Location = new System.Drawing.Point(87, 82);
            this.textPrenom.Name = "textPrenom";
            this.textPrenom.Size = new System.Drawing.Size(102, 20);
            this.textPrenom.TabIndex = 65;
            this.textPrenom.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::monprojetINTERFACE.Properties.Resources.trouver1;
            this.pictureBox3.Location = new System.Drawing.Point(79, 61);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(226, 170);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 69;
            this.pictureBox3.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::monprojetINTERFACE.Properties.Resources._1024x768__19_;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifierToolStripMenuItem,
            this.supprimerToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(97, 234);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(206, 24);
            this.menuStrip1.TabIndex = 72;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.modifierToolStripMenuItem.Text = "Modiffier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(131, 26);
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.ajouterToolStripMenuItem.Text = "voir la liste";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 75;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.labCNI);
            this.groupBox1.Controls.Add(this.textCNE);
            this.groupBox1.Controls.Add(this.textPrenom);
            this.groupBox1.Controls.Add(this.textNom);
            this.groupBox1.Controls.Add(this.textCNI);
            this.groupBox1.Controls.Add(this.labNOM);
            this.groupBox1.Controls.Add(this.labPRENOM);
            this.groupBox1.Controls.Add(this.labCNE);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(350, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 141);
            this.groupBox1.TabIndex = 76;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "statut";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 77;
            this.label1.Text = "retour";
            // 
            // FormTrouver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::monprojetINTERFACE.Properties.Resources._1024x768__19_;
            this.ClientSize = new System.Drawing.Size(591, 289);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_modiffier);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox3);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(607, 327);
            this.MinimumSize = new System.Drawing.Size(607, 327);
            this.Name = "FormTrouver";
            this.Text = "Trouver";
            this.Load += new System.EventHandler(this.FormTrouver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labCNI;
        private System.Windows.Forms.TextBox textCNI;
        private System.Windows.Forms.Label labNOM;
        private System.Windows.Forms.Label labPRENOM;
        private System.Windows.Forms.TextBox textCNE;
        private System.Windows.Forms.Button bt_modiffier;
        private System.Windows.Forms.Label labCNE;
        private System.Windows.Forms.TextBox textNom;
        private System.Windows.Forms.TextBox textPrenom;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}