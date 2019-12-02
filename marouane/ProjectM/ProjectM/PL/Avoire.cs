using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using ProjectM.BL;
using ProjectMarouane.DAL;
using System.Globalization;

namespace ProjectM.PL
{
    public partial class Avoire : MaterialForm
    {
        DataAccessLayer data = new DataAccessLayer();
        CLS_Avoire av = new CLS_Avoire();
        DataColumn [] dc = new DataColumn[6];
        public Avoire()
        {
            InitializeComponent();
            btnSubmit.Enabled = false;
            btnNew.Enabled = true;

        }

        private void TxtNumBO_Validated(object sender, EventArgs e)
        {
            try
            {
                dgv_Invoices.DataSource = av.getDetBuyAvoire(Convert.ToInt32(txtNumBO.Text));
            }
            catch
            {
                return;
            }
           

        }
        double prix;// this variable stock unit price for calacule price should be returned after avoir operation qteretourner*prix
        int Qte;// for compare qte in stock and qte returned
        private void Dgv_Invoices_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // insert values from datagridviw into textboxes
            txtNumAchat.Text = dgv_Invoices.CurrentRow.Cells[0].Value.ToString();
            txtNumPrd.Text = dgv_Invoices.CurrentRow.Cells[1].Value.ToString();
            txtNomPrd.Text = dgv_Invoices.CurrentRow.Cells[2].Value.ToString();
            txtCat.Text = dgv_Invoices.CurrentRow.Cells[3].Value.ToString();
            Qte = Convert.ToInt32(dgv_Invoices.CurrentRow.Cells[4].Value);
            prix = Convert.ToDouble(dgv_Invoices.CurrentRow.Cells[5].Value);


        }

        private void TxtQte_Validated(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtQte.Text) > Qte)
                {
                    MessageBox.Show("Vous n'avez pas ce quantity dans le stock ", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtQte.Clear();
                    txtQte.Focus();
                    return;
                }
                _ = txtQte.Text == "" ? txtPrix.Text = "" : txtPrix.Text = (Convert.ToDouble(txtQte.Text) * prix).ToString();
                validated();
            }
            catch
            {
                return;
            }
           
        }

        void validated()
        {
            // validated textBoxes for Insert into datagridiew
            if(txtNumAchat.Text!=string.Empty && txtNumPrd.Text!=string.Empty && txtNomPrd.Text != string.Empty && txtCat.Text != string.Empty
                 && txtQte.Text != string.Empty && txtPrix.Text != string.Empty)
            {
                dgv_avoiredetails.Rows.Add(txtNumAchat.Text, txtNumPrd.Text, txtNomPrd.Text, txtCat.Text, txtQte.Text, txtPrix.Text);
                txtNumAchat.Clear(); txtNumPrd.Clear(); txtNomPrd.Clear(); txtCat.Clear(); txtQte.Clear(); txtPrix.Clear();
            }
        }

        private void EffcerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //delete  row specifec from  dgv_avoiredetails
            dgv_avoiredetails.Rows.RemoveAt(dgv_avoiredetails.CurrentRow.Index);
        }

        private void EffacerToutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //delete from all rows dgv_avoiredetails
            dgv_avoiredetails.Rows.Clear();
        }

        private void ModifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Update item from dgvDettailsAv
            txtNumAchat.Text= dgv_avoiredetails.CurrentRow.Cells[0].Value.ToString(); 
            txtNumPrd.Text= dgv_avoiredetails.CurrentRow.Cells[1].Value.ToString(); 
            txtNomPrd.Text= dgv_avoiredetails.CurrentRow.Cells[2].Value.ToString();
            txtCat.Text= dgv_avoiredetails.CurrentRow.Cells[3].Value.ToString();
            txtQte.Text= dgv_avoiredetails.CurrentRow.Cells[4].Value.ToString();
            txtPrix.Text= dgv_avoiredetails.CurrentRow.Cells[5].Value.ToString();
            EffcerToolStripMenuItem_Click(sender, e);
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtNumAV.Text!= string.Empty && dgv_avoiredetails.RowCount > 0)
                {
                    av.AddAvoire(Convert.ToInt32(txtNumAV.Text), Convert.ToInt32(txtNumBO.Text), dateTimePicker1.Value);
                    for (int i = 0; i < dgv_avoiredetails.RowCount; i++)
                    {
                        av.AddAvoireDet(Convert.ToInt32(txtNumAV.Text), 
                            Convert.ToInt32(dgv_avoiredetails.Rows[i].Cells[1].Value),
                            Convert.ToInt32(dgv_avoiredetails.Rows[i].Cells[4].Value),
                            Convert.ToDouble(dgv_avoiredetails.Rows[i].Cells[5].Value));
                    }

                    MessageBox.Show("Vous avez ajouter cette avoire avec succée ", "Avoire", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                btnSubmit.Enabled = false;
                btnNew.Enabled = true;
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            try
            {
                txtNumAV.Text = av.GetAvId().Rows[0][0].ToString();
                btnSubmit.Enabled = true;
                btnNew.Enabled = false;
            }
            catch
            {
                return;
            }
           
        }

        private void TxtNumBO_KeyPress(object sender, KeyPressEventArgs e)
        {

            // for NumBuyingOrder and Qte
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtPrix_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)&& e.KeyChar!=Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator))
            {
                e.Handled = true;
            }
        }
    }
}
