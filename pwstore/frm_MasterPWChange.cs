using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pwstore
{
    public partial class frm_MasterPWChange : Form
    {
        private string PasswordHash;
        public frm_MasterPWChange(string mainpwhash)
        {
            PasswordHash = mainpwhash;
            InitializeComponent();

            lbl_ErreurNewPw.Visible = false;
            lbl_erreurPrevPw.Visible = false;
            lbl_ok.Visible = false;
            lbl_WarningPwStrength.Visible = false;
            lbl_newPw2Ok.Visible = false;
            tb_PwNew1.Enabled = false;
            tb_PwNew2.Enabled = false;
            bp_Validation.Enabled = false;  
        }

        private void tb_prevPw_TextChanged(object sender, EventArgs e)
        {
            if(cryptutils.ValidateSHA1HashData(tb_prevPw.Text,this.PasswordHash))
            {
                lbl_ok.Visible=true;
                lbl_erreurPrevPw.Visible=false;
                tb_PwNew1.Enabled=true;
                tb_prevPw.Enabled = false;
            }
            else
            {
                lbl_ok.Visible=false;
                lbl_erreurPrevPw.Visible=true;
                tb_PwNew1.Enabled=false;  

            }
            
       }

        private void tb_PwNew1_TextChanged(object sender, EventArgs e)
        {
            if(tb_PwNew1.Text=="")
            {
                lbl_WarningPwStrength.Visible = false;
                return;

            }

           if(cryptutils.IsStrongPassword(tb_PwNew1.Text)==true)
           {
               lbl_WarningPwStrength.Visible = false;
               tb_PwNew2.Enabled = true;

           }
           else
           {
               lbl_WarningPwStrength.Visible = true;
               tb_PwNew2.Text = "";
               tb_PwNew2.Enabled = false;
           }
        }

        private void tb_PwNew2_TextChanged(object sender, EventArgs e)
        {
            if (tb_PwNew2.Text == "")
            {
                lbl_ErreurNewPw.Visible = false;
                return;
            }

            if(tb_PwNew2.Text == tb_PwNew1.Text)
            {
                lbl_newPw2Ok.Visible = true;
                lbl_ErreurNewPw.Visible = false;
                bp_Validation.Enabled = true;
            }
            else
            {
                lbl_newPw2Ok.Visible = false;
                bp_Validation.Enabled = true;
                lbl_ErreurNewPw.Visible = true;
                bp_Validation.Enabled = false;
            }
        }

        private void bp_Validation_Click(object sender, EventArgs e)
        {
            this.Tag = cryptutils.GetSHA1HashData( tb_PwNew1.Text);
            this.Close();
            this.DialogResult = DialogResult.OK;
        }
    }
}
