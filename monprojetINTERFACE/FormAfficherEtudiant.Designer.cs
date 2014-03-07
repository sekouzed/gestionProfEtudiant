namespace monprojetINTERFACE
{
    partial class FormAfficherEtudiant
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAfficherEtudiant));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cNIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exporterDansUnFichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etudiantBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eTUDIANTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pROFESSEURSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matiere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professeurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelComp2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.cNIDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personneBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.personneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personneBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.etudiantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chCNI = new System.Windows.Forms.TextBox();
            this.chercher = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.etudiantBindingSource1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professeurBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personneBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personneBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etudiantBindingSource)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNIDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.cNEDataGridViewTextBoxColumn});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.DataSource = this.etudiantBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(589, 523);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.Visible = false;
            // 
            // cNIDataGridViewTextBoxColumn
            // 
            this.cNIDataGridViewTextBoxColumn.DataPropertyName = "CNI";
            this.cNIDataGridViewTextBoxColumn.HeaderText = "CNI";
            this.cNIDataGridViewTextBoxColumn.Name = "cNIDataGridViewTextBoxColumn";
            this.cNIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "prenom";
            this.prenomDataGridViewTextBoxColumn.HeaderText = "Prénom";
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            this.prenomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cNEDataGridViewTextBoxColumn
            // 
            this.cNEDataGridViewTextBoxColumn.DataPropertyName = "CNE";
            this.cNEDataGridViewTextBoxColumn.HeaderText = "CNE";
            this.cNEDataGridViewTextBoxColumn.Name = "cNEDataGridViewTextBoxColumn";
            this.cNEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exporterDansUnFichierToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(199, 26);
            // 
            // exporterDansUnFichierToolStripMenuItem
            // 
            this.exporterDansUnFichierToolStripMenuItem.Name = "exporterDansUnFichierToolStripMenuItem";
            this.exporterDansUnFichierToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.exporterDansUnFichierToolStripMenuItem.Text = "Exporter dans un fichier";
            this.exporterDansUnFichierToolStripMenuItem.Click += new System.EventHandler(this.exporterDansUnFichierToolStripMenuItem_Click);
            // 
            // etudiantBindingSource1
            // 
            this.etudiantBindingSource1.DataSource = typeof(monprojetDAL.etudiant);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::monprojetINTERFACE.Properties.Resources._1024x768__19_;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tOUTToolStripMenuItem,
            this.eTUDIANTToolStripMenuItem,
            this.pROFESSEURSToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(589, 27);
            this.menuStrip1.TabIndex = 38;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tOUTToolStripMenuItem
            // 
            this.tOUTToolStripMenuItem.Name = "tOUTToolStripMenuItem";
            this.tOUTToolStripMenuItem.Size = new System.Drawing.Size(98, 23);
            this.tOUTToolStripMenuItem.Text = "Toute la liste";
            this.tOUTToolStripMenuItem.Click += new System.EventHandler(this.tOUTToolStripMenuItem_Click);
            // 
            // eTUDIANTToolStripMenuItem
            // 
            this.eTUDIANTToolStripMenuItem.Name = "eTUDIANTToolStripMenuItem";
            this.eTUDIANTToolStripMenuItem.Size = new System.Drawing.Size(102, 23);
            this.eTUDIANTToolStripMenuItem.Text = "Les étudiants";
            this.eTUDIANTToolStripMenuItem.Click += new System.EventHandler(this.eTUDIANTToolStripMenuItem_Click);
            // 
            // pROFESSEURSToolStripMenuItem
            // 
            this.pROFESSEURSToolStripMenuItem.Name = "pROFESSEURSToolStripMenuItem";
            this.pROFESSEURSToolStripMenuItem.Size = new System.Drawing.Size(115, 23);
            this.pROFESSEURSToolStripMenuItem.Text = "Les professeurs";
            this.pROFESSEURSToolStripMenuItem.Click += new System.EventHandler(this.pROFESSEURSToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(64, 23);
            this.quitterToolStripMenuItem.Text = "Fermer";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Matiere});
            this.dataGridView2.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView2.DataSource = this.professeurBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 27);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(589, 523);
            this.dataGridView2.TabIndex = 39;
            this.dataGridView2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CNI";
            this.dataGridViewTextBoxColumn3.HeaderText = "CNI";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "nom";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "prenom";
            this.dataGridViewTextBoxColumn2.HeaderText = "Prénom";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Matiere
            // 
            this.Matiere.DataPropertyName = "matiere";
            this.Matiere.HeaderText = "Matiere";
            this.Matiere.Name = "Matiere";
            this.Matiere.ReadOnly = true;
            // 
            // professeurBindingSource
            // 
            this.professeurBindingSource.DataSource = typeof(monprojetDAL.professeur);
            // 
            // labelComp2
            // 
            this.labelComp2.AutoSize = true;
            this.labelComp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComp2.Location = new System.Drawing.Point(3, 0);
            this.labelComp2.Name = "labelComp2";
            this.labelComp2.Size = new System.Drawing.Size(0, 17);
            this.labelComp2.TabIndex = 40;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 516);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(589, 34);
            this.tableLayoutPanel1.TabIndex = 41;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNIDataGridViewTextBoxColumn1,
            this.nomDataGridViewTextBoxColumn1,
            this.prenomDataGridViewTextBoxColumn1,
            this.statutDataGridViewTextBoxColumn});
            this.dataGridView3.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView3.DataSource = this.personneBindingSource2;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(0, 27);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(589, 489);
            this.dataGridView3.TabIndex = 42;
            this.dataGridView3.Visible = false;
            // 
            // cNIDataGridViewTextBoxColumn1
            // 
            this.cNIDataGridViewTextBoxColumn1.DataPropertyName = "CNI";
            this.cNIDataGridViewTextBoxColumn1.HeaderText = "CNI";
            this.cNIDataGridViewTextBoxColumn1.Name = "cNIDataGridViewTextBoxColumn1";
            this.cNIDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nomDataGridViewTextBoxColumn1
            // 
            this.nomDataGridViewTextBoxColumn1.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn1.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn1.Name = "nomDataGridViewTextBoxColumn1";
            this.nomDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // prenomDataGridViewTextBoxColumn1
            // 
            this.prenomDataGridViewTextBoxColumn1.DataPropertyName = "prenom";
            this.prenomDataGridViewTextBoxColumn1.HeaderText = "Prénom";
            this.prenomDataGridViewTextBoxColumn1.Name = "prenomDataGridViewTextBoxColumn1";
            this.prenomDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // statutDataGridViewTextBoxColumn
            // 
            this.statutDataGridViewTextBoxColumn.DataPropertyName = "statut";
            this.statutDataGridViewTextBoxColumn.HeaderText = "Statut";
            this.statutDataGridViewTextBoxColumn.Name = "statutDataGridViewTextBoxColumn";
            this.statutDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personneBindingSource2
            // 
            this.personneBindingSource2.DataSource = typeof(monprojetDAL.personne);
            // 
            // personneBindingSource
            // 
            this.personneBindingSource.DataSource = typeof(monprojetDAL.personne);
            // 
            // personneBindingSource1
            // 
            this.personneBindingSource1.DataSource = typeof(monprojetDAL.personne);
            // 
            // etudiantBindingSource
            // 
            this.etudiantBindingSource.DataSource = typeof(monprojetDAL.etudiant);
            // 
            // chCNI
            // 
            this.chCNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chCNI.ForeColor = System.Drawing.SystemColors.MenuText;
            this.chCNI.Location = new System.Drawing.Point(397, 3);
            this.chCNI.Name = "chCNI";
            this.chCNI.Size = new System.Drawing.Size(150, 20);
            this.chCNI.TabIndex = 58;
            this.chCNI.Text = "taper le CNI  ";
            // 
            // chercher
            // 
            this.chercher.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chercher.BackgroundImage")));
            this.chercher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chercher.ForeColor = System.Drawing.Color.Black;
            this.chercher.Location = new System.Drawing.Point(553, 3);
            this.chercher.Name = "chercher";
            this.chercher.Size = new System.Drawing.Size(27, 22);
            this.chercher.TabIndex = 59;
            this.chercher.UseVisualStyleBackColor = true;
            this.chercher.Click += new System.EventHandler(this.chercher_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.68142F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.31858F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.Controls.Add(this.chercher, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.chCNI, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelComp2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(583, 28);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // FormAfficherEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::monprojetINTERFACE.Properties.Resources._1024x768__19_;
            this.ClientSize = new System.Drawing.Size(589, 550);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(605, 588);
            this.MinimumSize = new System.Drawing.Size(605, 588);
            this.Name = "FormAfficherEtudiant";
            this.Text = "Visionneuse";
            this.Load += new System.EventHandler(this.FormAfficherEtudiant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.etudiantBindingSource1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professeurBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personneBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personneBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etudiantBindingSource)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource etudiantBindingSource;
        private System.Windows.Forms.BindingSource etudiantBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eTUDIANTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pROFESSEURSToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matiere;
        private System.Windows.Forms.BindingSource professeurBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Label labelComp2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exporterDansUnFichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tOUTToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource personneBindingSource;
        private System.Windows.Forms.BindingSource personneBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNIDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn statutDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.BindingSource personneBindingSource2;
        public System.Windows.Forms.TextBox chCNI;
        private System.Windows.Forms.Button chercher;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}