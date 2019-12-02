using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Data.SqlClient;
using ProjectM.BL;

namespace ProjectMarouane.PL
{
    public partial class Sale : Form
    {
        DataTable dt = new DataTable();
        DataColumn [] dc=new DataColumn[5];
        DAL.DataAccessLayer data = new DAL.DataAccessLayer();
        BL.CLS_Prod prod = new BL.CLS_Prod();
        CLS_Client clt = new CLS_Client();
        public Sale()
        {
            InitializeComponent();
            //Make my own columns
            dc[0] = new DataColumn("Identifiant");
            dc[1] = new DataColumn("Libelle");
            dc[2] = new DataColumn("Prix total");
            dc[3] = new DataColumn("Quantity");
            dc[4] = new DataColumn("Prix unitaire");

            dt.Columns.AddRange(dc);
            dgv_detaills.DataSource = dt;
            btn_add.Enabled = false;
            btn_new.Enabled = true;
          
          
          
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //btn choix customer
            try
            {
                //bring customer in textbox;
                ListClients lstClt = new ListClients();
                lstClt.ShowDialog();
                
                txtNomC.Text = lstClt.dgv_lstClt.CurrentRow.Cells[1].Value.ToString();
                txtTele.Text = lstClt.dgv_lstClt.CurrentRow.Cells[2].Value.ToString();
                txtEmail.Text = lstClt.dgv_lstClt.CurrentRow.Cells[3].Value.ToString();
                txtAge.Text = lstClt.dgv_lstClt.CurrentRow.Cells[4].Value.ToString();
                GroupClt.Controls.Remove(lbl1);
                createLabel(114, 184, "*", Color.Green, lbl1);
                GroupClt.Controls.Add(lbl1);

            }
            catch
            {
                return;
            }


        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            //btn choix product
            try
            {
                //bring Product for sale id name and unit price
                lstProduct lst = new lstProduct();
                lst.ShowDialog();
                int ss = Convert.ToInt32(lst.dgv_lstPrd.CurrentRow.Cells[0].Value);
                for(int i = 0; i<dgv_detaills.Rows.Count;i++)
                if (Convert.ToInt32(dgv_detaills.Rows[i].Cells[0].Value) == ss)
                {
                    MessageBox.Show("Ce produit ce trouve déja dans la liste des ventes", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                txtIdP.Text = lst.dgv_lstPrd.CurrentRow.Cells[0].Value.ToString();   // id product
                txtNomP.Text = lst.dgv_lstPrd.CurrentRow.Cells[1].Value.ToString();  // Product name or lebele
                //txtPrixVU.Text= lst.dgv_lstPrd.CurrentRow.Cells[4].Value.ToString(); // unite sale price
                // 
                groupBox4.Controls.Remove(lbl3);
                createLabel(385, 202, "*", Color.Green,lbl3);
                groupBox4.Controls.Add(lbl3);
                lbl3.Show();

            }
            catch
            {
                return;
            }
           
            

        }

        private void TxtQteP_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // From total price to quantity
                if (txtPricetotal.Text != string.Empty )
                {
                    TxtPricetotal_TextChanged(sender, e);
                }
                else
                {
                    txtPricetotal.Clear();
                }
            }
            catch
            {
                return;
            }
            
        }

    

        private void TxtQteP_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Only numbers have right for write
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                if(txtPrixVU.Text!=string.Empty && txtPricetotal.Text!=string.Empty)
                txtAv.Focus();
            }
        }
        string sum;

        private void TxtAdvan_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            //Only numbers and decimal separator have right for write
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) &&  e.KeyChar.ToString()!= NumberFormatInfo.CurrentInfo.NumberDecimalSeparator)
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                DataTable d = new DataTable();
                adapter = new SqlDataAdapter("Select QteStock from Product_tb where IdProduct =" + txtIdP.Text + "", data.cn);
                adapter.Fill(d);
                int qte = Convert.ToInt32(d.Rows[0][0]) - Convert.ToInt32(txtQteP.Text);
                prod.ModifyQte(Convert.ToInt32(txtIdP.Text), qte);

                
                try
                {
                    

                    sum = (Convert.ToDouble(txtSum.Text) + Convert.ToDouble(txtPricetotal.Text)).ToString();
                    dt.Rows.Add(txtIdP.Text, txtNomP.Text, txtPrixVU.Text, txtQteP.Text, txtPricetotal.Text);
                    dgv_detaills.DataSource = dt;
                    foreach (Control c in groupBox4.Controls)
                    {
                        if (c is TextBox)
                        {
                            TextBox text = (TextBox)c;
                            text.Clear();
                        }
                    }
                    button2.Focus();
                    
                }
                catch
                {
                    return;
                }
                
            }
        }
        void effacer()
        {
            foreach (Control c in GroupClt.Controls)
            {
                if (c is TextBox)
                {
                    TextBox text = (TextBox)c;
                    text.Clear();
                }

            }
            foreach (Control c in groupBox2.Controls)
            {
                if (c is TextBox)
                {
                    TextBox text = (TextBox)c;
                    text.Clear();
                }

            }
            foreach (Control c in GroupPui.Controls)
            {
                if (c is TextBox)
                {
                    TextBox text = (TextBox)c;
                    text.Clear();
                }

            }
            foreach (Control c in groupBox4.Controls)
            {
                if (c is TextBox)
                {
                    TextBox text = (TextBox)c;

                    text.Clear();
                }
                if (c is DataGridView)
                {
                    dt.Rows.Clear();
                    dgv_detaills.DataSource = dt;
                }

            }
        }

        private void TxtAdvan_Validated(object sender, EventArgs e)
        {
            //remove quatity sold from Stock
            
        }

        private string GetMatricule(string number)
        {
            
            int cmp = 8-number.Length;
            string mt="";
            for(int i=0;i<cmp;i++)
            {
                mt += "0";
            }
            return mt + number;
        }
        private void Btn_new_Click(object sender, EventArgs e)
        {
            btn_add.Enabled = true;
            btn_new.Enabled = false;
            //prepare for write new sale
            dt.Rows.Clear();
            dgv_detaills.DataSource = dt;
            txtSum.Text = "0";
            txtAv.Text = "0";
            txtRes.Text="0";
            txtId.Text = clt.getId().ToString();
            btn_add.Enabled = true;
            btn_new.Enabled = false;
            rb_false.Checked = true;
            comboBox1.SelectedIndex = 0;
            //get number of order 
            txtNumOS.Text= GetMatricule(data.GetData("getLastIdOS", null).Rows[0][0].ToString());
            

        }
        SqlDataAdapter adapter;
        private void TxtQteP_Validated(object sender, EventArgs e)
        {
            try
            {
                DataTable d = new DataTable();
                adapter = new SqlDataAdapter("Select QteStock from Product_tb where IdProduct =" + txtIdP.Text + "", data.cn);
                adapter.Fill(d);
                if (txtQteP.Text != string.Empty && txtPrixVU.Text != string.Empty && txtPricetotal.Text != string.Empty)
                {
                   
                    dt.Rows.Add(txtIdP.Text, txtNomP.Text, txtPricetotal.Text, txtQteP.Text,txtPrixVU.Text); 


                    txtIdP.Clear(); txtNomP.Clear(); txtPrixVU.Clear(); txtQteP.Clear(); txtPricetotal.Clear();
                    d.Clear();
                    dgv_detaills.DataSource=dt;
                }
                    
                

                // calcul sum of details facutre

                txtSum.Text = (from DataGridViewRow r in dgv_detaills.Rows
                               where r.Cells[2].FormattedValue.ToString() != string.Empty
                               select Convert.ToDouble(r.Cells[2].FormattedValue)).Sum().ToString();
                if (txtAv.Text == "0")
                    txtRes.Text = txtSum.Text;
            }
            catch
            {
                return;
            }
          
        }
        
        void createLabel(int x, int y,string text,Color color, Label lbl)
        {
            if (lbl != null)
            {
                lbl.Text = text;
                lbl.ForeColor = color;
                lbl.Font = new Font("Arial", 12);
                lbl.Location = new Point(x, y);
                lbl.AutoSize = true;
            }
           
            
        }
        Label lbl1, lbl2, lbl3;
        private void Btn_add_Click(object sender, EventArgs e)
        {
            btn_add.Enabled = false;
            btn_new.Enabled = true;


            DataTable d = new DataTable();
            try
            {
               
                if (txtId.Text == string.Empty)
                {
                    lbl1 = new Label();
                    createLabel(114, 184, "* Choisissez-vous votre client",Color.Red,lbl1);
                    button1.Focus();
                    GroupClt.Controls.Add(lbl1);
                    lbl1.Show();
                    return;
                }
              
                if (dgv_detaills.RowCount==0)
                {
                    lbl3 = new Label();
                    createLabel(385, 202, "* Choisissez-vous votre produit", Color.Red,lbl3);
                    button2.Focus();
                    groupBox4.Controls.Add(lbl3);
                    lbl3.Show();
                    return;
                }
                //
                if (txtId.Text == clt.getId().ToString())
                {
                    clt.AddClient(Convert.ToInt32(txtId.Text), txtNomC.Text, txtTele.Text, txtEmail.Text, txtAge.Text,Convert.ToDateTime(dateTimePicker1.Value));
                }

                if (rb_false.Checked)
                {
                    if (txtRes.Text == "0")
                    {
                        prod.AddSaleOrder(Convert.ToInt16(txtNumOS.Text), txtDesc.Text, dateTimePicker1.Value, Convert.ToInt32(txtId.Text), "Effactuer", rb_false.Text,
                        comboBox1.Text.ToString(), txtSum.Text, Convert.ToDouble(txtAv.Text));
                    }
                    else if (txtRes.Text != "0")
                    {
                        prod.AddSaleOrder(Convert.ToInt16(txtNumOS.Text), txtDesc.Text, dateTimePicker1.Value, Convert.ToInt32(txtId.Text), "Non Effactuer", rb_false.Text,
                       comboBox1.Text.ToString(), txtSum.Text, Convert.ToDouble(txtAv.Text));
                    }

                }
                 
                                    
                if (rb_yes.Checked)
                {
                    if (txtRes.Text == "0")
                    {
                        prod.AddSaleOrder(Convert.ToInt32(txtNumOS.Text), txtDesc.Text, dateTimePicker1.Value, Convert.ToInt32(txtId.Text), "Effactuer", rb_yes.Text,
                  comboBox1.Text.ToString(), txtSum.Text, Convert.ToDouble(txtAv.Text));
                    }
                   else if( txtRes.Text != "0")
                    {
                        prod.AddSaleOrder(Convert.ToInt32(txtNumOS.Text), txtDesc.Text, dateTimePicker1.Value, Convert.ToInt32(txtId.Text), "Non Effactuer", rb_yes.Text,
                 comboBox1.Text.ToString(), txtSum.Text, Convert.ToDouble(txtAv.Text));
                    }

                   
                }
               
                for (int i = 0; i < dgv_detaills.Rows.Count; i++)
                {

                    adapter = new SqlDataAdapter("Select QteStock from Product_tb where IdProduct =" + Convert.ToInt32(dgv_detaills.Rows[i].Cells[0].Value) + "", data.cn);
                    adapter.Fill(d);
                    int qte = Convert.ToInt32(d.Rows[0][0]) - Convert.ToInt32(dgv_detaills.Rows[i].Cells[3].Value);
                    prod.ModifyQte(Convert.ToInt32(dgv_detaills.Rows[i].Cells[0].Value), qte);
                    d.Clear();
                }
                
                for (int i = 0; i < dgv_detaills.Rows.Count; i++)
                {
                    prod.AddDetailsOrder(Convert.ToInt32(txtNumOS.Text), Convert.ToInt32(dgv_detaills.Rows[i].Cells[0].Value),
                        Convert.ToInt32(dgv_detaills.Rows[i].Cells[3].Value), Convert.ToDouble(dgv_detaills.Rows[i].Cells[4].Value), Convert.ToDouble(dgv_detaills.Rows[i].Cells[2].Value));
                }
                dt.Rows.Clear();
                clt.AddLeftSize(Convert.ToInt32(txtId.Text), SphVLL.Text, SphVPL.Text, CylVLL.Text, CylVPL.Text, AxeVLL.Text, AxeVPL.Text, AddL.Text, Convert.ToInt32(txtNumOS.Text));
                clt.AddRighttSize(Convert.ToInt32(txtId.Text), SphVLR.Text, SphVPR.Text, CylVLR.Text, CylVPR.Text, AxeVLR.Text, AxeVPR.Text, AddR.Text, Convert.ToInt32(txtNumOS.Text));
                effacer();
                GroupClt.Controls.Remove(lbl1);
                groupBox2.Controls.Remove(lbl2);
                groupBox4.Controls.Remove(lbl3);
                MessageBox.Show("Vente est ajouté avec succées", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_add.Enabled = false;
                btn_new.Enabled = true;
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            


            
        }

        private void EffacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
          
           
            //delete row from dataGridView and DataTable "dataSource"
            int ind =dgv_detaills.CurrentRow.Index;
            dt.Rows.RemoveAt(ind);
            
           
          


        }

        private void Dgv_detaills_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            //Calcul Sum again Of invoice when row deleted from data
            txtSum.Text=(from DataGridViewRow r in dgv_detaills.Rows
             where r.Cells[2].FormattedValue.ToString() != string.Empty
             select Convert.ToDouble(r.Cells[2].FormattedValue)).Sum().ToString();
        }

        private void EffacerToutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable d = new DataTable();
            PL.Confirmation cfr = new Confirmation();
            cfr.lblConfirm.Text = "voulez-vous vraiment supprimer ce vende?";
            if (cfr.ShowDialog()== DialogResult.OK)
            {
               
                dt.Rows.Clear();
            }
               
            
        }

        private void ModifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                txtIdP.Text = dgv_detaills.CurrentRow.Cells[0].Value.ToString();
                txtNomP.Text = dgv_detaills.CurrentRow.Cells[1].Value.ToString();
                txtPrixVU.Text = dgv_detaills.CurrentRow.Cells[2].Value.ToString();
                txtQteP.Text = dgv_detaills.CurrentRow.Cells[3].Value.ToString();
                txtPricetotal.Text = dgv_detaills.CurrentRow.Cells[4].Value.ToString();
                
                int ind = dgv_detaills.CurrentRow.Index;
                dt.Rows.RemoveAt(ind);
               

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

  

        private void TxtAnnuler_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtAv_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtAv.Text == string.Empty)
                {
                    txtAv.Text = "0";
                }
                
                    double total, av;
                    total = Convert.ToDouble(txtSum.Text);
                    av = Convert.ToDouble(txtAv.Text);
                    txtRes.Text = (total - av).ToString();
                
               
            }
            catch
            {
                return;
            }
           
        }

        private void TxtSum_TextChanged(object sender, EventArgs e)
        {
            TxtAv_TextChanged(sender, e);
        }

       

        private void KeyPresstextBoxes(object sender, KeyPressEventArgs e)
        {
            try
            {
               
                    var text = sender as TextBox;
                    if (text.Text == "_")
                    {
                        text.Clear();
                        text.ForeColor = Color.Black;

                    }
                
             
            }
            catch
            {
                return;
            }
          
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Button1_Click(sender, e);
            foreach(Control c in GroupClt.Controls)
            {
                if(c is TextBox)
                {
                    var text = (TextBox)c;
                    text.ForeColor = Color.Black;
                    if (text.Text == "-")
                    {
                        text.ForeColor = Color.DarkGray;
                    }
                }
            }
        }

      

        private void Button3_Click_1(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Show();
        }

        private void TxtPrixVU_TextChanged(object sender, EventArgs e)
        {
            TxtQteP_TextChanged(sender, e);
        }

        private void VNLL_Validated(object sender, EventArgs e)
        {
            //make sure that textboxes is clear
            var text = sender as TextBox;
            if (text.Text == string.Empty || text.Text == " ")
            {
                text.Text = "-";
                text.ForeColor = Color.DarkGray;
                text.TextAlign = HorizontalAlignment.Center;
            }
           
        }

        private void Sizes_KeyPress(object sender, KeyPressEventArgs e)
        {
           // Change colorText when he start to write 
            var text = sender as TextBox;
            if (text.ForeColor == Color.DarkGray)
            {
                text.Clear();
                text.ForeColor = Color.Black;
            }
        }

        private void AddR_MouseClick(object sender, MouseEventArgs e)
        {
            // for delete contente of textboxes size when they have gray line
            var text = sender as TextBox;
            if (text.ForeColor == Color.DarkGray)
            {
                text.Clear();
            }
        }

        private void TxtPricetotal_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtQteP.Text != string.Empty)
                    txtPrixVU.Text = (Convert.ToDouble(txtPricetotal.Text) / Convert.ToInt32(txtQteP.Text)).ToString();
                else if (txtQteP.Text == string.Empty || txtPricetotal.Text == string.Empty)
                {
                    txtPrixVU.Clear();
                }
            }
            catch
            {
                return;
            }
           
        }

        private void TxtPricetotal_Validated(object sender, EventArgs e)
        {
            if (txtQteP.Text != string.Empty && txtPrixVU.Text != string.Empty && txtPricetotal.Text != string.Empty)
            {
                TxtQteP_Validated(sender, e);
            }
        }

        private void TxtPrixVU_Validated(object sender, EventArgs e)
        {
            if (txtQteP.Text != string.Empty && txtPrixVU.Text != string.Empty && txtPricetotal.Text != string.Empty)
            {
                TxtQteP_Validated(sender, e);
            }
        }

        private void ValidatedTextBoxes(object sender, EventArgs e)
        {
            var text = sender as TextBox;
            if (text.Text == "" || text.Text == " ")
            {
                text.Text = "-";
                text.ForeColor = Color.DarkGray;
            }
        }

        private void TxtDesc_Validated(object sender, EventArgs e)
        {
            if(txtDesc.Text != string.Empty)
            {
                groupBox2.Controls.Remove(lbl2);
                createLabel(116, 25, "*", Color.Green, lbl2);
                groupBox2.Controls.Add(lbl2);
            }
        }
    }
}
