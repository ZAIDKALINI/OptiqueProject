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
    public partial class ViewAch : Form
    {
        DataTable dt ;
        DataTable d;
        DataAccessLayer data = new DataAccessLayer();
        public ViewAch()
        {
            InitializeComponent();
        }
        DataTable fillData(string stored_procedure)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@NumOB", SqlDbType.Int);
            param[0].Value = Program.i2;
            return data.GetData(stored_procedure, param);


        }
        double sum(int i)
        {
            return (from DataGridViewRow r in dataGridView1.Rows
                        where r.Cells[i].FormattedValue.ToString() != string.Empty
                        select Convert.ToDouble(r.Cells[i].FormattedValue.ToString())).Sum();
        }
        private void ViewAch_Load(object sender, EventArgs e)
        {
            try
            {
                dt = fillData("GetViewBuying");
                d = fillData("getDBView");
                txtId.Text = dt.Rows[0][4].ToString();
                txtNomC.Text = dt.Rows[0][5].ToString();
                txtTele1.Text = dt.Rows[0][6].ToString();
                txtTele2.Text = dt.Rows[0][7].ToString();
                txtEmail.Text = dt.Rows[0][8].ToString();
                txtNumOB.Text = dt.Rows[0][0].ToString();
                txtDesc.Text = dt.Rows[0][1].ToString();
                dateTimePicker1.Value = Convert.ToDateTime(dt.Rows[0][2]);
                if (dt.Rows[0][3].ToString() == "Oui")
                    rb_Yes.Checked = true;
                else
                    rb_False.Checked = true;


                dataGridView1.DataSource = d;
                txtSumTTC.Text = sum(5).ToString(); //index sum ttc 
                txtSum.Text = sum(3).ToString(); //index sum HT
            }
            catch
            {
                return;
            }
         

        }
    }
}
