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
namespace ProjectMarouane.PL
{
    public partial class ListClients : Form
    {
        DAL.DataAccessLayer data = new DAL.DataAccessLayer();
        SqlDataAdapter adapter;
        DataTable dt = new DataTable();
        
        
        public ListClients()
        {
            InitializeComponent();
            try
            {
                adapter = new SqlDataAdapter("Select * from Client_tb Order by IdClt Desc", data.cn);
                adapter.Fill(dt);
                dgv_lstClt.DataSource = dt;
            }
            catch
            {
                return;
            }
         
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
          
            adapter = new SqlDataAdapter("select * from Client_tb c where c.NomClt + c.Tele + c.Email like '%" + Search.Text+ "%'", data.cn);
            dt.Clear();
            adapter.Fill(dt);
            dgv_lstClt.DataSource = dt;

        }

        private void DataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
          
            
            Close();
        }
    }
}
