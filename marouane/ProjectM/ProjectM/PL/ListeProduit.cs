using ProjectMarouane.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectM.PL
{
    public partial class ListeProduit : Form
    {
       
        DataAccessLayer data = new DataAccessLayer();
        DataTable dt = new DataTable();
        SqlParameter[] param = new SqlParameter[1];
        public ListeProduit()
        {
            InitializeComponent();
            try
            {
                dgv.DataSource = data.GetData("GetAllProduct", null);
                txtTotal.Text = TotalSaleProduct().ToString();
            }
            catch
            {
                return;
            }
            
        }
        int TotalSaleProduct()
        {
            return (from DataGridViewRow r in dgv.Rows select (int)r.Cells["Qte"].Value).Sum();
        }

        private void ListeProduit_Load(object sender, EventArgs e)
        {

        }

        private void MaterialSingleLineTextField1_Click(object sender, EventArgs e)
        {
        }

        private void MaterialSingleLineTextField1_TextChanged(object sender, EventArgs e)
        {

            param[0] = new SqlParameter("@search", SqlDbType.NVarChar, 100);
            param[0].Value = materialSingleLineTextField1.Text;
            dgv.DataSource = data.GetData("getSpesificProd", param);
            txtTotal.Text = TotalSaleProduct().ToString();
        }
    }
}
