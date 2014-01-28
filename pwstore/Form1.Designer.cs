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
            this.compteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connecterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.déconnecterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.changerMotDePasseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tb_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_logPath = new System.Windows.Forms.TextBox();
            this.bp_RecordSettings = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_dbFileName = new System.Windows.Forms.TextBox();
            this.bp_explorePath = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Path = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
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
            this.changerMotDePasseToolStripMenuItem.Click += new System.EventHandler(this.changerMotDePasseToolStripMenuItem_Click);
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
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(417, 2);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(220, 20);
            this.tb_search.TabIndex = 3;
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rechercher :";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(831, 464);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(823, 438);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Liste";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(817, 322);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.tb_logPath);
            this.tabPage2.Controls.Add(this.bp_RecordSettings);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.tb_dbFileName);
            this.tabPage2.Controls.Add(this.bp_explorePath);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.tb_Path);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(823, 438);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Config";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(419, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Chemin du fichier journal";
            // 
            // tb_logPath
            // 
            this.tb_logPath.Location = new System.Drawing.Point(23, 203);
            this.tb_logPath.Name = "tb_logPath";
            this.tb_logPath.Size = new System.Drawing.Size(390, 20);
            this.tb_logPath.TabIndex = 6;
            // 
            // bp_RecordSettings
            // 
            this.bp_RecordSettings.Location = new System.Drawing.Point(393, 280);
            this.bp_RecordSettings.Name = "bp_RecordSettings";
            this.bp_RecordSettings.Size = new System.Drawing.Size(188, 23);
            this.bp_RecordSettings.TabIndex = 5;
            this.bp_RecordSettings.Text = "Enregistrer";
            this.bp_RecordSettings.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nom du fichier de données";
            // 
            // tb_dbFileName
            // 
            this.tb_dbFileName.Location = new System.Drawing.Point(20, 98);
            this.tb_dbFileName.Name = "tb_dbFileName";
            this.tb_dbFileName.Size = new System.Drawing.Size(390, 20);
            this.tb_dbFileName.TabIndex = 3;
            // 
            // bp_explorePath
            // 
            this.bp_explorePath.Location = new System.Drawing.Point(433, 41);
            this.bp_explorePath.Name = "bp_explorePath";
            this.bp_explorePath.Size = new System.Drawing.Size(75, 23);
            this.bp_explorePath.TabIndex = 2;
            this.bp_explorePath.Text = "...";
            this.bp_explorePath.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chemin du fichier de données";
            // 
            // tb_Path
            // 
            this.tb_Path.Location = new System.Drawing.Point(20, 41);
            this.tb_Path.Name = "tb_Path";
            this.tb_Path.Size = new System.Drawing.Size(390, 20);
            this.tb_Path.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 510);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "PW Store";
            this.MouseEnter += new System.EventHandler(this.Form1_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FichierToolStripMenuItem;
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_logPath;
        private System.Windows.Forms.Button bp_RecordSettings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_dbFileName;
        private System.Windows.Forms.Button bp_explorePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Path;
    }
}

