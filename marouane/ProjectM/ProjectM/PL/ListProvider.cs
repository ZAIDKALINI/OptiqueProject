using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectMarouane.DAL;
using System.Data.SqlClient;
using MaterialSkin.Controls;

namespace ProjectM.PL
{
    public partial class ListProvider : MaterialForm
    {
        
       DataAccessLayer data = new DataAccessLayer();
        public ListProvider()
        {
            InitializeComponent();
            try
            {
                dgv_lstProvider.DataSource = data.GetData("getproviders", null);
            }
            catch
            {
                return;
            }
            
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            SqlParameter [] param = new SqlParameter[1];
            param [0]= new SqlParameter("@search", SqlDbType.VarChar, 100);
            param[0].Value = Search.Text;
            dgv_lstProvider.DataSource = data.GetData("GetAllProvider", param);
        }

        private void Dgv_lstProvider_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void ListProvider_Load(object sender, EventArgs e)
        {

        }
    }
}
