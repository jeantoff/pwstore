namespace pwstore
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.compteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connecterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.déconnecterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.changerMotDePasseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FichierToolStripMenuItem,
            this.compteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(831, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FichierToolStripMenuItem
            // 
            this.FichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enregistrerToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.FichierToolStripMenuItem.Name = "FichierToolStripMenuItem";
            this.FichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.FichierToolStripMenuItem.Text = "Fichier";
            // 
            // enregistrerToolStripMenuItem
            // 
            this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.enregistrerToolStripMenuItem.Text = "Enregistrer";
            this.enregistrerToolStripMenuItem.Visible = false;
            this.enregistrerToolStripMenuItem.Click += new System.EventHandler(this.enregistrerToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(831, 442);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            this.dataGridView1.MouseEnter += new System.EventHandler(this.Form1_MouseEnter);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 488);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(831, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(115, 17);
            this.toolStripStatusLabel1.Text = "Compte déconnecté";
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // compteToolStripMenuItem
            // 
            this.compteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connecterToolStripMenuItem1,
            this.déconnecterToolStripMenuItem1,
            this.changerMotDePasseToolStripMenuItem});
            this.compteToolStripMenuItem.Name = "compteToolStripMenuItem";
            this.compteToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.compteToolStripMenuItem.Text = "Compte";
            // 
            // connecterToolStripMenuItem1
            // 
            this.connecterToolStripMenuItem1.Name = "connecterToolStripMenuItem1";
            this.connecterToolStripMenuItem1.Size = new System.Drawing.Size(192, 22);
            this.connecterToolStripMenuItem1.Text = "Connecter";
            this.connecterToolStripMenuItem1.Click += new System.EventHandler(this.connecterToolStripMenuItem_Click);
            // 
            // déconnecterToolStripMenuItem1
            // 
            this.déconnecterToolStripMenuItem1.Name = "déconnecterToolStripMenuItem1";
            this.déconnecterToolStripMenuItem1.Size = new System.Drawing.Size(192, 22);
            this.déconnecterToolStripMenuItem1.Text = "Déconnecter";
            this.déconnecterToolStripMenuItem1.Click += new System.EventHandler(this.déconnecterToolStripMenuItem_Click);
            // 
            // changerMotDePasseToolStripMenuItem
            // 
            this.changerMotDePasseToolStripMenuItem.Name = "changerMotDePasseToolStripMenuItem";
            this.changerMotDePasseToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.changerMotDePasseToolStripMenuItem.Text = "Changer Mot de Passe";
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(277, 2);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(220, 20);
            this.tb_search.TabIndex = 3;
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rechercher :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 510);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "PW Store";
            this.MouseEnter += new System.EventHandler(this.Form1_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FichierToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connecterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem déconnecterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem changerMotDePasseToolStripMenuItem;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Label label1;
    }
}

