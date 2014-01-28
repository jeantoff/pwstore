namespace pwstore
{
    partial class frm_MasterPWChange
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_prevPw = new System.Windows.Forms.TextBox();
            this.tb_PwNew1 = new System.Windows.Forms.TextBox();
            this.tb_PwNew2 = new System.Windows.Forms.TextBox();
            this.lbl_ok = new System.Windows.Forms.Label();
            this.lbl_erreurPrevPw = new System.Windows.Forms.Label();
            this.lbl_ErreurNewPw = new System.Windows.Forms.Label();
            this.lbl_WarningPwStrength = new System.Windows.Forms.Label();
            this.bp_Validation = new System.Windows.Forms.Button();
            this.lbl_newPw2Ok = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ancien Mot de Passe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nouveau Mot de Passe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Saisir à nouveau...";
            // 
            // tb_prevPw
            // 
            this.tb_prevPw.Location = new System.Drawing.Point(16, 30);
            this.tb_prevPw.Name = "tb_prevPw";
            this.tb_prevPw.Size = new System.Drawing.Size(225, 20);
            this.tb_prevPw.TabIndex = 3;
            this.tb_prevPw.UseSystemPasswordChar = true;
            this.tb_prevPw.TextChanged += new System.EventHandler(this.tb_prevPw_TextChanged);
            // 
            // tb_PwNew1
            // 
            this.tb_PwNew1.Location = new System.Drawing.Point(19, 88);
            this.tb_PwNew1.Name = "tb_PwNew1";
            this.tb_PwNew1.Size = new System.Drawing.Size(222, 20);
            this.tb_PwNew1.TabIndex = 4;
            this.tb_PwNew1.UseSystemPasswordChar = true;
            this.tb_PwNew1.TextChanged += new System.EventHandler(this.tb_PwNew1_TextChanged);
            // 
            // tb_PwNew2
            // 
            this.tb_PwNew2.Location = new System.Drawing.Point(16, 136);
            this.tb_PwNew2.Name = "tb_PwNew2";
            this.tb_PwNew2.PasswordChar = '$';
            this.tb_PwNew2.Size = new System.Drawing.Size(222, 20);
            this.tb_PwNew2.TabIndex = 5;
            this.tb_PwNew2.UseSystemPasswordChar = true;
            this.tb_PwNew2.TextChanged += new System.EventHandler(this.tb_PwNew2_TextChanged);
            // 
            // lbl_ok
            // 
            this.lbl_ok.AutoSize = true;
            this.lbl_ok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl_ok.Location = new System.Drawing.Point(247, 33);
            this.lbl_ok.Name = "lbl_ok";
            this.lbl_ok.Size = new System.Drawing.Size(22, 13);
            this.lbl_ok.TabIndex = 6;
            this.lbl_ok.Text = "OK";
            // 
            // lbl_erreurPrevPw
            // 
            this.lbl_erreurPrevPw.AutoSize = true;
            this.lbl_erreurPrevPw.ForeColor = System.Drawing.Color.Red;
            this.lbl_erreurPrevPw.Location = new System.Drawing.Point(275, 33);
            this.lbl_erreurPrevPw.Name = "lbl_erreurPrevPw";
            this.lbl_erreurPrevPw.Size = new System.Drawing.Size(41, 13);
            this.lbl_erreurPrevPw.TabIndex = 7;
            this.lbl_erreurPrevPw.Text = "Erreur !";
            // 
            // lbl_ErreurNewPw
            // 
            this.lbl_ErreurNewPw.AutoSize = true;
            this.lbl_ErreurNewPw.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErreurNewPw.Location = new System.Drawing.Point(275, 136);
            this.lbl_ErreurNewPw.Name = "lbl_ErreurNewPw";
            this.lbl_ErreurNewPw.Size = new System.Drawing.Size(41, 13);
            this.lbl_ErreurNewPw.TabIndex = 7;
            this.lbl_ErreurNewPw.Text = "Erreur !";
            // 
            // lbl_WarningPwStrength
            // 
            this.lbl_WarningPwStrength.AutoSize = true;
            this.lbl_WarningPwStrength.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_WarningPwStrength.Location = new System.Drawing.Point(16, 169);
            this.lbl_WarningPwStrength.Name = "lbl_WarningPwStrength";
            this.lbl_WarningPwStrength.Size = new System.Drawing.Size(361, 13);
            this.lbl_WarningPwStrength.TabIndex = 8;
            this.lbl_WarningPwStrength.Text = "Dois contenir minuscule(s), majuscule(s), chiffres(s), caractère spécial(-aux).";
            // 
            // bp_Validation
            // 
            this.bp_Validation.Location = new System.Drawing.Point(395, 234);
            this.bp_Validation.Name = "bp_Validation";
            this.bp_Validation.Size = new System.Drawing.Size(75, 23);
            this.bp_Validation.TabIndex = 9;
            this.bp_Validation.Text = "Valider";
            this.bp_Validation.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.bp_Validation.UseVisualStyleBackColor = true;
            this.bp_Validation.Click += new System.EventHandler(this.bp_Validation_Click);
            // 
            // lbl_newPw2Ok
            // 
            this.lbl_newPw2Ok.AutoSize = true;
            this.lbl_newPw2Ok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl_newPw2Ok.Location = new System.Drawing.Point(244, 136);
            this.lbl_newPw2Ok.Name = "lbl_newPw2Ok";
            this.lbl_newPw2Ok.Size = new System.Drawing.Size(22, 13);
            this.lbl_newPw2Ok.TabIndex = 10;
            this.lbl_newPw2Ok.Text = "OK";
            // 
            // frm_MasterPWChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 271);
            this.Controls.Add(this.lbl_newPw2Ok);
            this.Controls.Add(this.bp_Validation);
            this.Controls.Add(this.lbl_WarningPwStrength);
            this.Controls.Add(this.lbl_ErreurNewPw);
            this.Controls.Add(this.lbl_erreurPrevPw);
            this.Controls.Add(this.lbl_ok);
            this.Controls.Add(this.tb_PwNew2);
            this.Controls.Add(this.tb_PwNew1);
            this.Controls.Add(this.tb_prevPw);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_MasterPWChange";
            this.Text = "MasterPWChange";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_prevPw;
        private System.Windows.Forms.TextBox tb_PwNew1;
        private System.Windows.Forms.TextBox tb_PwNew2;
        private System.Windows.Forms.Label lbl_ok;
        private System.Windows.Forms.Label lbl_erreurPrevPw;
        private System.Windows.Forms.Label lbl_ErreurNewPw;
        private System.Windows.Forms.Label lbl_WarningPwStrength;
        private System.Windows.Forms.Button bp_Validation;
        private System.Windows.Forms.Label lbl_newPw2Ok;
    }
}