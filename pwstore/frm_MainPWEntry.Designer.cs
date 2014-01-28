namespace pwstore
{
    partial class frm_MainPWEntry
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bp_validmpw = new System.Windows.Forms.Button();
            this.tb_mpw = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bp_validmpw
            // 
            this.bp_validmpw.Location = new System.Drawing.Point(163, 136);
            this.bp_validmpw.Name = "bp_validmpw";
            this.bp_validmpw.Size = new System.Drawing.Size(144, 32);
            this.bp_validmpw.TabIndex = 7;
            this.bp_validmpw.Text = "Valider";
            this.bp_validmpw.UseVisualStyleBackColor = true;
            this.bp_validmpw.Click += new System.EventHandler(this.bp_validmpw_Click);
            // 
            // tb_mpw
            // 
            this.tb_mpw.Location = new System.Drawing.Point(28, 55);
            this.tb_mpw.Name = "tb_mpw";
            this.tb_mpw.PasswordChar = '*';
            this.tb_mpw.Size = new System.Drawing.Size(279, 20);
            this.tb_mpw.TabIndex = 6;
            this.tb_mpw.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Merci de saisir un mot de passe maître";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(90, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mauvais Mot de passe";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // frm_MainPWEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 197);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bp_validmpw);
            this.Controls.Add(this.tb_mpw);
            this.Controls.Add(this.label1);
            this.Name = "frm_MainPWEntry";
            this.Text = "frm_MainPWEntry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bp_validmpw;
        private System.Windows.Forms.TextBox tb_mpw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}