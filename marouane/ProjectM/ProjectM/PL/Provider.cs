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
    public partial class Provider : Form
    {
        DAL.DataAccessLayer data = new DAL.DataAccessLayer();
        DataTable dt = new DataTable();
        SqlDataAdapter adapter;
        SqlCommandBuilder cmdb;
        BindingManagerBase bmb;
        public Provider()
        {
            InitializeComponent();
            try
            {
                btn_add.Enabled = false;
                adapter = new SqlDataAdapter("Select * from Provider_tb", data.cn);
                adapter.Fill(dt);
                txtId.DataBindings.Add("Text", dt, "IdProvider");
                txtNomF.DataBindings.Add("Text", dt, "ProviderName");
                txtTele1.DataBindings.Add("Text", dt, "Tele1");
                txtTele2.DataBindings.Add("Text", dt, "Tele2");
                txtEmail.DataBindings.Add("Text", dt, "Email");

                bmb = this.BindingContext[dt];
                dataGridView1.DataSource = dt;
                lblPos.Text = bmb.Position + 1 + "/" + bmb.Count;
            }
            catch
            {
                return;
            }
           
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
         
                int ind = dataGridView1.Rows.Count - 1;
                bmb.AddNew();
            try
            {
                foreach (var c in groupBox1.Controls)
                {
                    if (c is TextBox)
                    {
                        var text = (TextBox)c;
                        text.Text = "-";
                        text.ForeColor = Color.DarkGray;
                        text.TextAlign = HorizontalAlignment.Center;
                    }

                }
                txtId.ForeColor = Color.Black;
                txtId.Text = (Convert.ToInt32(dataGridView1.Rows[ind].Cells[0].Value) + 1).ToString();
                txtId.Text = data.GetData("getProviderId", null).Rows[0][0].ToString();
                btn_add.Enabled = true;
                btnNew.Enabled = false;
                lblPos.Text = bmb.Position + 1 + "/" + bmb.Count;
                txtNomF.Text = "-";
                txtNomF.ForeColor = Color.DarkGray;
                txtTele1.Text = "-";
                txtTele1.ForeColor = Color.DarkGray;
                txtTele2.Text = "-";
                txtTele2.ForeColor = Color.DarkGray;
                txtEmail.Text = "-";
                txtEmail.ForeColor = Color.DarkGray;
            }
            catch
            {
                txtId.Text = data.GetData("getProviderId", null).Rows[0][0].ToString();
                btn_add.Enabled = true;
                btnNew.Enabled = false;
                lblPos.Text = bmb.Position + 1 + "/" + bmb.Count;
                txtNomF.Text = "-";
                txtNomF.ForeColor = Color.DarkGray;
                txtTele1.Text = "-";
                txtTele1.ForeColor = Color.DarkGray;
                txtTele2.Text = "-";
                txtTele2.ForeColor = Color.DarkGray;
                txtEmail.Text = "-";
                txtEmail.ForeColor = Color.DarkGray;
                return;
            }
          
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                bmb.EndCurrentEdit();
                cmdb = new SqlCommandBuilder(adapter);
                adapter.Update(dt);
                MessageBox.Show("Vous avez ajouté le fournisseur avec succés", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblPos.Text = bmb.Position + 1 + "/" + bmb.Count;
                btn_add.Enabled = false;
                btnNew.Enabled = true;
            }
            catch
            {
                return;
            }
          
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                bmb.EndCurrentEdit();
                cmdb = new SqlCommandBuilder(adapter);
                adapter.Update(dt);
                MessageBox.Show("Vous avez modifié le fournisseur avec succés", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblPos.Text = bmb.Position + 1 + "/" + bmb.Count;
            }
            catch
            {
                return;
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Confirmation cfr = new Confirmation();
                if (cfr.ShowDialog() == DialogResult.OK)
                {
                    SqlParameter[] param = new SqlParameter[1];
                    int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    param[0] = new SqlParameter("@IdProvider", SqlDbType.Int);
                    param[0].Value = id;

                    data.ExcuteCommand("DeleteProvider", param);
                    if (dataGridView1.Rows.Count != 0)
                        dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                    MessageBox.Show("Vous avez suprimé ce fournisseur avec succés", "Suprimer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblPos.Text = bmb.Position + 1 + "/" + bmb.Count;
                }
            }
            catch
            {
                return;
            }
           
            
        }

        private void BtnExist_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_last_Click(object sender, EventArgs e)
        {
            bmb.Position = bmb.Count;
            lblPos.Text = bmb.Position + 1 + "/" + bmb.Count;
        }

        private void Btn_next_Click(object sender, EventArgs e)
        {
            bmb.Position ++;
            lblPos.Text = bmb.Position + 1 + "/" + bmb.Count;
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            bmb.Position--;
            lblPos.Text = bmb.Position + 1 + "/" + bmb.Count;
        }

        private void Btn_first_Click(object sender, EventArgs e)
        {
            bmb.Position =0;
            lblPos.Text = bmb.Position + 1 + "/" + bmb.Count;
            
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@search", SqlDbType.NVarChar, 100);
            param[0].Value = Search.Text;
            dataGridView1.DataSource = data.GetData("GetAllProvider", param);
        }

        private void TxtTele1_KeyPress(object sender, KeyPressEventArgs e)
        {
            var text = sender as TextBox;
            if (text.ForeColor == Color.DarkGray)
            {
                text.Clear();
                text.ForeColor = Color.Black;

            }
        }
        private void txtNomF_LostFocus(object sender, EventArgs e)
        {
            if (txtNomF.ForeColor == Color.DarkGray)
            {
                bmb.CancelCurrentEdit();
                btnNew.Enabled = true;
                btn_add.Enabled = false;
                foreach (Control c in groupBox1.Controls)
                {
                    if (c is TextBox)
                    {
                        var text = (TextBox)c;
                        text.ForeColor = Color.Black;

                    }
                }
                dt.Rows.RemoveAt(dt.Rows.Count - 1);
            }
            else
            {
                foreach (Control c in groupBox1.Controls)
                {
                    if (c is TextBox)
                    {
                        var text = (TextBox)c;
                        text.ForeColor = Color.Black;

                    }
                }
            }
        }

        private void DataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            txtNomF_LostFocus(sender, e);
        }

        private void placeholder(object sender, MouseEventArgs e)
        {
            var text = sender as TextBox;
            if (text.ForeColor == Color.DarkGray)
            {
                text.Clear();
            }
        }

        private void TxtNomF_Validated(object sender, EventArgs e)
        {

        }

        private void text_validated(object sender, EventArgs e)
        {
            var text = sender as TextBox;
            if (text.Text == string.Empty || text.Text == " ")
            {
                text.Text = "-";
                text.ForeColor = Color.DarkGray;
                text.TextAlign = HorizontalAlignment.Center;
            }
          
        }
    }
}
