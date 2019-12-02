using ProjectMarouane.PL;
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
using ProjectMarouane;

namespace ProjectM.PL
{
    public partial class BuyingManagement : Form
    {
        DataAccessLayer data = new DataAccessLayer();
        public BuyingManagement()
        {
            InitializeComponent();
            try
            {
                dgv_Invoices.DataSource = data.GetData("GetBuyOerder", null);
                ttlAchats.Text = dgv_Invoices.RowCount.ToString();
            }
            catch
            {
                return;
            }
           
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            Buy buy = new Buy();
            buy.ShowDialog();
        }

        private void BuyingManagement_Load(object sender, EventArgs e)
        {
            PL.WinAPI.AnimateWindow(this.Handle, 2000, WinAPI.HOR_Positive);
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@search", SqlDbType.NVarChar, 100);
            param[0].Value = Search.Text;
            dgv_Invoices.DataSource = data.GetData("GetSpecBuyOerder", param);
            ttlAchats.Text = dgv_Invoices.RowCount.ToString();
        }

        private void ValueChanged(object sender, EventArgs e)
        {
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@from", SqlDbType.Date);
            param[0].Value = from.Value;
            param[1] = new SqlParameter("@to", SqlDbType.Date);
            param[1].Value = to.Value;
            dgv_Invoices.DataSource = data.GetData("GetBuyOerderbyDate", param);
            ttlAchats.Text = dgv_Invoices.RowCount.ToString();

        }

        private void BtnExist_Click(object sender, EventArgs e)
        {
            Close();
        }
        void mousedblClick()
        {
            try
            {
                Program.i2 = Convert.ToInt32(dgv_Invoices.CurrentRow.Cells[0].Value);
                ViewAch view = new ViewAch();
                view.Show();
            }
            catch
            {
                return;
            }
        }
        private void Dgv_Invoices_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                Program.i2 = Convert.ToInt32(dgv_Invoices.CurrentRow.Cells[0].Value);
                ViewAch view = new ViewAch();
                view.Show();
            }
            catch
            {
                return;
            }
           

        }

        private void ActualizerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgv_Invoices.DataSource = data.GetData("GetBuyOerder", null);
            ttlAchats.Text = dgv_Invoices.RowCount.ToString();
        }

        private void EffacerVenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Confirmation cfr = new Confirmation();
            if (cfr.ShowDialog() == DialogResult.OK)
            {
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@NumOB", SqlDbType.Int);
                param[0].Value = dgv_Invoices.CurrentRow.Cells[0].Value.ToString();
                data.ExcuteCommand("DeleteOrderBuying", param);
                dgv_Invoices.DataSource = data.GetData("GetBuyOerder", null);
                ttlAchats.Text = dgv_Invoices.RowCount.ToString();
            }
           
        }

        private void QuitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
