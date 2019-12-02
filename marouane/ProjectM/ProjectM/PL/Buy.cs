using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectM.BL;
using ProjectM.PL;

namespace ProjectMarouane.PL
{
    public partial class Buy : Form
    {
        DataColumn [] dc = new DataColumn[7];
        DataTable dt = new DataTable();
        DAL.DataAccessLayer data = new DAL.DataAccessLayer();
        public Buy()
        {
            InitializeComponent();
            dc[0] = new DataColumn("idProduct");
            dc[1] = new DataColumn("Nom");
            dc[2] = new DataColumn("Qte");
            dc[3] = new DataColumn("Total TTC");
            dc[4] = new DataColumn("TV");
            dc[5] = new DataColumn("Total HT");

            dt.Columns.AddRange(dc);
            dataGridView1.DataSource = dt;
            btn_new.Enabled = true;
            btn_add.Enabled = false;
            rb_Yes.Checked = true;
        }

        private void Buy_Load(object sender, EventArgs e)
        {
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                ListProvider lst = new ListProvider();
                lst.ShowDialog();
                txtId.Text = lst.dgv_lstProvider.CurrentRow.Cells[0].Value.ToString();
                txtNomC.Text = lst.dgv_lstProvider.CurrentRow.Cells[1].Value.ToString();
                txtTele1.Text = lst.dgv_lstProvider.CurrentRow.Cells[2].Value.ToString();
                txtTele2.Text = lst.dgv_lstProvider.CurrentRow.Cells[3].Value.ToString();
                txtEmail.Text = lst.dgv_lstProvider.CurrentRow.Cells[4].Value.ToString();
            }
            catch
            {
                return;
            }
           

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                lstProduct lst = new lstProduct();
                lst.ShowDialog();
                txtIdP.Text = lst.dgv_lstPrd.CurrentRow.Cells[0].Value.ToString();
                txtNomP.Text = lst.dgv_lstPrd.CurrentRow.Cells[1].Value.ToString();
            }
            catch
            {
                return;
            }
           

        }

        private void textValidated(object sender, EventArgs e)
        {
            if(txtQte.Text!=string.Empty && txtTHT.Text != string.Empty && txtTva.Text != string.Empty && txtTTC.Text != string.Empty)
            {
                dt.Rows.Add(txtIdP.Text, txtNomP.Text, txtQte.Text, txtTTC.Text, txtTva.Text, txtTHT.Text ); 
                txtQte.Clear(); txtTHT.Clear(); txtTva.Clear(); txtTTC.Clear(); txtIdP.Clear(); txtNomP.Clear();
                txtSum.Text=(from DataGridViewRow r in dataGridView1.Rows
                             where r.Cells[5].FormattedValue.ToString()!=string.Empty
                             select Convert.ToDouble(r.Cells[5].FormattedValue)).Sum().ToString();
                txtSumTTC.Text = (from DataGridViewRow r in dataGridView1.Rows
                                  where r.Cells[3].FormattedValue.ToString() != string.Empty
                                  select Convert.ToDouble(r.Cells[3].FormattedValue)).Sum().ToString();
            }
        }
        private string GetMatricule(string number)
        {

            int cmp = 8 - number.Length;
            string mt = "";
            for (int i = 0; i < cmp; i++)
            {
                mt += "0";
            }
            return mt + number;
        }

        private void Btn_new_Click(object sender, EventArgs e)
        {
            txtNumOB.Text = GetMatricule(data.GetData("getNumOB", null).Rows[0][0].ToString());
            btn_new.Enabled = false;
            btn_add.Enabled = true;
        }

        private void EffacerToutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Confirmation cfr = new Confirmation();
            if (cfr.ShowDialog() == DialogResult.OK)
            {
                dt.Rows.Clear();
            }
        }

        private void EffacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Confirmation cfr = new Confirmation();
            if (cfr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            }
        }

        private void ModifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                txtIdP.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtNomP.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtQte.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtTTC.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtTva.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtTHT.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            }
            catch
            {
                return;
            }
        }

        private void DataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                txtSum.Text = (from DataGridViewRow r in dataGridView1.Rows
                               where r.Cells[5].FormattedValue.ToString() != string.Empty
                               select Convert.ToDouble(r.Cells[5].FormattedValue)).Sum().ToString();
                txtSumTTC.Text = (from DataGridViewRow r in dataGridView1.Rows
                                  where r.Cells[3].FormattedValue.ToString() != string.Empty
                                  select Convert.ToDouble(r.Cells[3].FormattedValue)).Sum().ToString();
            }
            else
            {
                txtSum.Text = "";
                txtSumTTC.Text = "";
            }
       
        }
        CLS_Buying_Order bo = new CLS_Buying_Order();
        BL.CLS_Prod prd = new BL.CLS_Prod();
        private void Btn_add_Click(object sender, EventArgs e)
        {
            if (rb_Yes.Checked)
            {
                bo.AddOrderBuying(Convert.ToInt32(txtNumOB.Text), txtDesc.Text, dateTimePicker1.Value, Convert.ToInt32(txtId.Text), rb_Yes.Text);
            
            }
            else
            {
                bo.AddOrderBuying(Convert.ToInt32(txtNumOB.Text), txtDesc.Text, dateTimePicker1.Value, Convert.ToInt32(txtId.Text), rb_False.Text);

            }
            for(int i =0; i < dataGridView1.RowCount; i++)
            {
                bo.addDetBuying(Convert.ToInt32(txtNumOB.Text), Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value), Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value), Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value),
                    Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value), Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value));
                // update qte product
                prd.EditQteProduct(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value), Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value));
            }
            
            MessageBox.Show("Vous avez ajoutez votre achats avect succées", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Effacer();
            Close();

        }
        void Effacer()
        {
            foreach(var c in groupBox1.Controls)
            {
                if(c is TextBox)
                {
                    var txt = (TextBox)c;
                    txt.Clear();
                }
            }
            foreach (var c in groupBox2.Controls)
            {
                if (c is TextBox)
                {
                    var txt = (TextBox)c;
                    txt.Clear();
                }
            }
            foreach (var c in groupBox4.Controls)
            {
                if (c is TextBox)
                {
                    var txt = (TextBox)c;
                    txt.Clear();
                }
                
            }
            dt.Rows.Clear();
        }

        private void TxtQte_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtPHT_TextChanged(object sender, EventArgs e)
        {
            TxtQte_TextChanged(sender, e);// calcule Total Hors Taxe
        }

        private void TxtTHT_TextChanged(object sender, EventArgs e)
        {
           
           
        }

        private void TxtTva_TextChanged(object sender, EventArgs e)
        {
           
            
        }
        public double calculeHT(double TTC, double tva)
        {
            return TTC * (1 - tva / 100);

        }
        private void TxtTTC_TextChanged(object sender, EventArgs e)
        {
            if (txtTTC.Text != string.Empty)
            {
                txtTva.Text="20";
                txtTHT.Text = calculeHT(Convert.ToDouble(txtTTC.Text), Convert.ToDouble(txtTva.Text)).ToString();
            }


        }

        private void TxtTTC_Validating(object sender, CancelEventArgs e)
        {
            //calculeTVA();
        }

        private void TxtTva_Validating(object sender, CancelEventArgs e)
        {
           
        }

      

        private void TxtMouseClick(object sender, MouseEventArgs e)
        {
            // for delete contente of textboxes size when they have gray line
            var text = sender as TextBox;
            if (text.ForeColor == Color.DarkGray)
            {
                text.Clear();
            }
        }

        private void TxtValidated(object sender, EventArgs e)
        {
            //all textBoxes validated probider
            var text = sender as TextBox;
            if (text.Text == string.Empty || text.Text == " ")
            {
                text.Text = "-";
                text.ForeColor = Color.DarkGray;
                text.TextAlign = HorizontalAlignment.Center;
            }
        }

        private void TxtDesc_KeyPress(object sender, KeyPressEventArgs e)
        {
            var text = sender as TextBox;
            if (text.ForeColor == Color.DarkGray)
            {
                text.Clear();
                text.ForeColor = Color.Black;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.ShowDialog();
        }
    }
}
