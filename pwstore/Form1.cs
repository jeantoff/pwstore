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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;
//using System.Xml.Serialization;
//using System.IO;


namespace pwstore
{
    public partial class Form1 : Form
    {
        private bool Connected;
        private BindingList<LogInfoStore> ListInfos;
        
        public Form1()
        {
            InitializeComponent();
            Connected = false;
            if(Settings1.Default.mainpw=="")
            {
                Settings1.Default.mainpw = cryptutils.GetSHA1HashData("mot de passe");
            }

            déconnecterToolStripMenuItem1.Visible = false;
            changerMotDePasseToolStripMenuItem.Visible = false;

        }

        void OpenMPWForm()
        {
            //default PW
            frm_MainPWEntry frm = new frm_MainPWEntry(Settings1.Default.mainpw);
            frm.ShowDialog();            
        }

        private void connecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_MainPWEntry frm = new frm_MainPWEntry(Settings1.Default.mainpw);
            frm.ShowDialog(); 
            if(frm.Controled == true)
            {
                this.Connected = true;
                connecterToolStripMenuItem1.Visible = false;
                déconnecterToolStripMenuItem1.Visible = true;
                changerMotDePasseToolStripMenuItem.Visible = true;
                this.ListInfos=pwstoreTools.UnserializeList(Settings1.Default.mainpw,Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
                if (this.ListInfos == null)
                    MessageBox.Show("Le fichier de mots de passes n'existe pas encore !", "Avertissement !");
                else
                    this.UnmaskList();
            }

        }

        private void déconnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enregistrerToolStripMenuItem.Visible = false;

            this.Connected = false;
            connecterToolStripMenuItem1.Visible = true;
            déconnecterToolStripMenuItem1.Visible = false;
            MaskList();

        }

        public void MaskList()
        {
            ListInfos.Clear();
            dataGridView1.Columns.RemoveAt(dataGridView1.Columns["Delete"].Index);
            dataGridView1.Refresh();
            dataGridView1.Visible = false;
            changerMotDePasseToolStripMenuItem.Visible = false;

            SendStatusMessage("Compte déconnecté");
        }

        public void UnmaskList()
        {
            dataGridView1.Visible = true;
            
            if(this.ListInfos.Count == 0)
            {
                this.ListInfos.Add(new LogInfoStore());

            }

            dataGridView1.DataSource = this.ListInfos;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                dataGridView1.Columns[column.Name].SortMode = DataGridViewColumnSortMode.Automatic;
            }

            DataGridViewButtonColumn DelColumn = new DataGridViewButtonColumn();
            DelColumn.Text = "Delete";
            DelColumn.Name = "Delete";
            DelColumn.DataPropertyName = "Delete";
            dataGridView1.Columns.Add(DelColumn);
            dataGridView1.Height = statusStrip1.Top - dataGridView1.Top;
            /*enregistrerToolStripMenuItem.Visible = true;
            changerMotDePasseToolStripMenuItem.Visible = true;*/
            SendStatusMessage("Connection Réussie !");
        }

        void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0 || e.RowIndex >= dataGridView1.Rows.Count) return;

            if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index)
            {
                if (MessageBox.Show("Confirmer la suppression ?", "Confirmation", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
            }
            else
            {
                string colname = dataGridView1.Columns[e.ColumnIndex].Name;
                if (dataGridView1.Rows[e.RowIndex].Cells[colname].Value.ToString() != "" &&  dataGridView1.Rows[e.RowIndex].Cells[colname].Value !=null)
                {
                    Clipboard.SetText(dataGridView1.Rows[e.RowIndex].Cells[colname].Value.ToString());
                    SendStatusMessage("La valeur de " + colname + " a été collée dans le presse papier");
                }
            }
        }

        public void SendStatusMessage(string message)
        {
            this.timer1.Stop();
            this.timer1.Start();
            this.toolStripStatusLabel1.Text=message;
        }

         private void enregistrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Enregistrer())
                SendStatusMessage("Fichier de mots de passe encrypté et enregistré !");
            else
                SendStatusMessage("Impossible d'enregistrer le fichier !");
        }

        private bool Enregistrer()
        {
            return pwstoreTools.SerializeList(this.ListInfos, Settings1.Default.mainpw, Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
        }


        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            string colname= dataGridView1.Columns[e.ColumnIndex].Name;
            SendStatusMessage("tri de la colonne " + colname);

            List<LogInfoStore> tmplist = ListInfos.ToList<LogInfoStore>();
            bool sorted = true;
           
            switch(colname)
            {
                case "Name":
                    tmplist = tmplist.OrderBy(x => x.Name).ToList();
                    break;
                case "URL":
                    tmplist = tmplist.OrderBy(x => x.URL).ToList();
                    break;

                case "Login":
                    tmplist = tmplist.OrderBy(x => x.Login).ToList();
                    break;

                default:
                    sorted = false;
                    break;
            }

            if(sorted)
            {
                ListInfos.Clear();
                foreach(LogInfoStore lg in tmplist)
                {
                    ListInfos.Add(lg);
                }
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text="";
            timer1.Stop();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
           // this.Opacity = 0.3;
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            //this.Opacity = 1.0;
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            /*
            List<LogInfoStore> lfound=new List<LogInfoStore>();
            List<LogInfoStore> lfound=new List<LogInfoStore>();

            foreach(LogInfoStore lgi in  this.ListInfos )
            {

               if(lgi.FindStringInFields(tb_search.Text))


            }
             */
        }

        private void changerMotDePasseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_MasterPWChange frm = new frm_MasterPWChange(Settings1.Default.mainpw);
            if(frm.ShowDialog()==DialogResult.OK)
            {
                if(frm.Tag.ToString() !="")
                {
                    Settings1.Default.mainpw = frm.Tag.ToString();
                    if (Enregistrer())
                        SendStatusMessage("Fichier de mots de passe encrypté et enregistré !");
                    else
                        SendStatusMessage("Impossible d'enregistrer le fichier !");

                }
                else
                {
                    Debug.WriteLine("tag vide");

                }


            }

        }

    }
}
