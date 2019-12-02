using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using ProjectMarouane.DAL;
using System.Data.SqlClient;
namespace ProjectM.PL
{
    public partial class Back_Up : MaterialForm
    {
        DataAccessLayer data = new DataAccessLayer();
        SqlCommand cmd;
        public Back_Up()
        {
            InitializeComponent();
        }

        private void TxtChoose_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.ShowDialog();
            txtPath.Text = save.FileName;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string path = txtPath.Text;
                string str = "Backup Database Optique1 To Disk='" + path + ".bak'";
                cmd = new SqlCommand(str, data.cn);
                data.Open();
                cmd.ExecuteNonQuery();
                data.Close();
                MessageBox.Show("Vous avez enregistrer votre DataBase avec succées", "Enregistrer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch
            {
                MessageBox.Show("Echéq d'enregistrement ", "Enregistrer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
} 
