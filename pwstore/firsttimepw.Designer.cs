namespace pwstore
{
    partial class firsttimepw
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_mpwtxt1 = new System.Windows.Forms.TextBox();
            this.tb_mpwtxt2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bp_validpw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Avant de pouvoir stocker vos identifiants merci de saisir un mot de passe maître";
            // 
            // tb_mpwtxt1
            // 
            this.tb_mpwtxt1.Location = new System.Drawing.Point(85, 40);
            this.tb_mpwtxt1.Name = "tb_mpwtxt1";
            this.tb_mpwtxt1.Size = new System.Drawing.Size(379, 20);
            this.tb_mpwtxt1.TabIndex = 1;
            // 
            // tb_mpwtxt2
            // 
            this.tb_mpwtxt2.Location = new System.Drawing.Point(85, 98);
            this.tb_mpwtxt2.Name = "tb_mpwtxt2";
            this.tb_mpwtxt2.Size = new System.Drawing.Size(379, 20);
            this.tb_mpwtxt2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Une deuxième fois S.V.P";
            // 
            // bp_validpw
            // 
            this.bp_validpw.Location = new System.Drawing.Point(480, 178);
            this.bp_validpw.Name = "bp_validpw";
            this.bp_validpw.Size = new System.Drawing.Size(144, 32);
            this.bp_validpw.TabIndex = 4;
            this.bp_validpw.Text = "Valider";
            this.bp_validpw.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bp_validpw.UseVisualStyleBackColor = true;
            // 
            // firsttimepw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 232);
            this.Controls.Add(this.bp_validpw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_mpwtxt2);
            this.Controls.Add(this.tb_mpwtxt1);
            this.Controls.Add(this.label1);
            this.Name = "firsttimepw";
            this.Text = "firsttimepw";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_mpwtxt1;
        private System.Windows.Forms.TextBox tb_mpwtxt2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bp_validpw;
    }
}