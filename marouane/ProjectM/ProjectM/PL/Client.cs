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
using ProjectM.PL;

namespace ProjectMarouane.PL
{
    public partial class Client : Form
    {
        DAL.DataAccessLayer data = new DAL.DataAccessLayer();
        DataTable dt = new DataTable();
       
       
        public Client()
        {
            InitializeComponent();
            try
            {
                dgv.DataSource = data.GetData("GetAllClient", null);
                txtTotal.Text = dgv.RowCount.ToString();
            }
            catch
            {
                return;
            }
           


        }
    
     

        private void Search_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void Dt_de_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@de", SqlDbType.Date);
                param[0].Value = dt_de.Value;
                param[1] = new SqlParameter("@a", SqlDbType.Date);
                param[1].Value = dt_A.Value;
                dgv.DataSource = data.GetData("getCltByDate", param);
                txtTotal.Text = dgv.RowCount.ToString();
            }
            catch
            {

                return;
            }
        }

        private void Dgv_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            Program.indClt = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
            Client_Détails cl = new Client_Détails();
            cl.ShowDialog();
            dgv.DataSource = data.GetData("GetAllClient", null);

        }

        private void TxtSear_TextChanged(object sender, EventArgs e)
        {

            try
            {
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@search", SqlDbType.NVarChar, 100);
                param[0].Value = txtSear.Text;
                dgv.DataSource = data.GetData("SearchClt", param);
                txtTotal.Text = dgv.RowCount.ToString();
            }
            catch
            {

                return;
            }
        }
    }
}
