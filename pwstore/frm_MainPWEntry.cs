/*    
    PWSTORE store login informations fin an encrypted xml file
    Use only for testing or code re-use purpose.
    
    Copyright (C) 2014  Jean-Christophe Bouvard

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.

    Also add information on how to contact you by electronic and paper mail.

If the program does terminal interaction, make it output a short notice like this when it starts in an interactive mode:

    PWSTORE  Copyright (C) 2014  Jean-Christophe Bouvard
    This program comes with ABSOLUTELY NO WARRANTY.
    This is free software, and you are welcome to redistribute it
    under certain conditions.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pwstore
{
    public partial class frm_MainPWEntry : Form
    {
        private string MainPwHash;
        public bool Controled = false;

        public frm_MainPWEntry(string mainpwhash)
        {
            InitializeComponent();
            MainPwHash=mainpwhash;
        }

        private void bp_validmpw_Click(object sender, EventArgs e)
        {
            string pw = this.tb_mpw.Text;
            string sh = cryptutils.GetSHA1HashData(pw);
            if(! cryptutils.ValidateSHA1HashData(pw,MainPwHash))
            {
                label2.Visible = true;
                return;
            }

            this.Controled = true;
            this.Close();
        }
    }
}
