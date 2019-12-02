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
using MaterialSkin.Controls;

namespace ProjectMarouane.PL
{
    public partial class lstProduct : MaterialForm
    {
        BL.CLS_Prod prd = new BL.CLS_Prod();
        SqlDataAdapter adapter ;
        DAL.DataAccessLayer data = new DAL.DataAccessLayer();
        DataTable dt = new DataTable();
       
        public lstProduct()
        {
            InitializeComponent();
            try
            {
                dgv_lstPrd.DataSource = prd.GetAllProduct();
            }
            catch
            {
                return;
            }
            
        }

        private void Dgv_lstPrd_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Close();
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dt.Clear();
                adapter = new SqlDataAdapter("Select * from Product_tb where ProductName+UnitSalePrice+ProductDesc like '%" + Search.Text + "%'", data.cn);
                adapter.Fill(dt);
                dgv_lstPrd.DataSource = dt;
            }
            catch
            {
                return;
            }
           
           


        }
    }
}
