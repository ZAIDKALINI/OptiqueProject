using ProjectMarouane;
using ProjectMarouane.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectM.PL
{
    public partial class Client_Détails : MaterialSkin.Controls.MaterialForm
    {
        BL.CLS_Client clt = new BL.CLS_Client();
        DataAccessLayer data = new DataAccessLayer();
        DataTable dt = new DataTable();
        SqlParameter[] param = new SqlParameter[1];
        public Client_Détails()
        {
            InitializeComponent();
            try
            {
                param[0] = new SqlParameter("@idClt", SqlDbType.Int);
                param[0].Value = Program.indClt;
                dt = data.GetData("GetSingleClient", param);
                txtId.Text = dt.Rows[0][0].ToString();
                txtComplet.Text = dt.Rows[0][1].ToString();
                txtTele.Text = dt.Rows[0][2].ToString();
                txtEmail.Text = dt.Rows[0][3].ToString();
                txtAge.Text = dt.Rows[0][4].ToString();
                txtId.Enabled = false;
            }
            catch
            {
                return;
            }
           
        }

        private void Client_Détails_Load(object sender, EventArgs e)
        {

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                SqlParameter[] param = new SqlParameter[5];
                param[0] = new SqlParameter("@IdClt", SqlDbType.Int);
                param[0].Value = txtId.Text;

                param[1] = new SqlParameter("@NomClt", SqlDbType.NVarChar, 60);
                param[1].Value = txtComplet.Text;

                param[2] = new SqlParameter("@Tele", SqlDbType.NChar, 14);
                param[2].Value = txtTele.Text;

                param[3] = new SqlParameter("@Email", SqlDbType.NVarChar, 100);
                param[3].Value = txtEmail.Text;

                param[4] = new SqlParameter("@Age", SqlDbType.Int);
                param[4].Value = txtAge.Text;
                data.ExcuteCommand("EditClient", param);
                MessageBox.Show("Vous avez modifié le client avec succées !", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ereur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }
    }
}
