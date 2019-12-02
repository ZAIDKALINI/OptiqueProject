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
using ProjectMarouane.DAL;
using System.Globalization;

namespace ProjectM.PL
{
    public partial class ServiceMontage :MaterialForm
    {
        DataColumn [] dc = new DataColumn[5];
        DataTable dt = new DataTable();
        BL.CLS_ServeiceMontage sr = new BL.CLS_ServeiceMontage();
        public ServiceMontage()
        {
            InitializeComponent();
            try
            {
                dc[0] = new DataColumn("N° de Vente");
                dc[1] = new DataColumn("Désignation");
                dc[2] = new DataColumn("Quantité");
                dc[3] = new DataColumn("Prix unitaire");
                dc[4] = new DataColumn("Prix total");
                dt.Columns.AddRange(dc);
                dgv_detaills.DataSource = dt;
                btn_add.Enabled = false;
                btn_new.Enabled = true;
                dgv_Invoices.DataSource = sr.getOrderDService();
            }
            catch
            {
                return;
            }
           

        }

        private void MaterialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }

        private void MaterialRaisedButton1_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (dgv_detaills.RowCount > 0)
                {
                    //Add service montage
                    sr.AddServiceMontage(Convert.ToInt32(txtNumS.Text), txtNomSo.Text, dateTimePicker1.Value, txtTele.Text);
                    //Add Details Service montage
                    for (int i = 0; i < dgv_detaills.RowCount; i++)
                    {
                        sr.AddDetails_service(Convert.ToInt32(txtNumS.Text), Convert.ToInt32(dgv_detaills.Rows[i].Cells[0].Value),
                        Convert.ToInt32(dgv_detaills.Rows[i].Cells[2].Value), Convert.ToDouble(dgv_detaills.Rows[i].Cells[3].Value), Convert.ToDouble(dgv_detaills.Rows[i].Cells[4].Value));
                    }
                    MessageBox.Show("Votre service ajouter avec succes", "Service", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    dgv_Invoices.DataSource = sr.getOrderDService();
                }
               
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MaterialSingleLineTextField3_Validated(object sender, EventArgs e)
        {

            validated();

        }
        void validated()
        {
            // add service details in datagridview
            try
            {
                if (txtQte.Text != string.Empty && txtPrixUn.Text != string.Empty && txtPrixTotal.Text != string.Empty)
                {
                    dt.Rows.Add(txt_NumOs.Text, txtDes.Text, txtQte.Text, txtPrixUn.Text, txtPrixTotal.Text);

                    txt_NumOs.Clear(); txtDes.Clear(); txtQte.Clear(); txtPrixUn.Clear(); txtPrixTotal.Clear();

                    dgv_detaills.DataSource = dt;
                }
            }
            catch
            {
                return;
            }
        }

        private void TxtIdp_Validated(object sender, EventArgs e)
        {
            try
            {
                DataTable dtable = new DataTable();
                dtable = sr.getProdForServiceMontage(Convert.ToInt32(txt_NumOs.Text));
                txtDes.Text = dtable.Rows[0][0].ToString();
                txtQte.Text = dtable.Rows[0][1].ToString();
            }
            catch
            {
                return;
            }
           

        }

        private void Btn_new_Click(object sender, EventArgs e)
        {
            try
            {
                txtNumS.Text = sr.getNumService().ToString();
                btn_add.Enabled = true;
                btn_new.Enabled = false;
            }
            catch
            {
                return;
            }
          
        }

        void clear()
        {
            txtDes.Clear();
            txtNomSo.Clear();
            txtNumS.Clear();
            txtPrixTotal.Clear();
            txtPrixUn.Clear();
            txtQte.Clear();
            txtTele.Clear();
            txt_NumOs.Clear();
            dt.Rows.Clear();
            dateTimePicker1.ResetText();
            

        }

        private void TxtPrixUn_TextChanged(object sender, EventArgs e)
        {
            try
            {

                _ = txtPrixUn.Text != string.Empty ? txtPrixTotal.Text = (Convert.ToInt32(txtPrixUn.Text) * Convert.ToInt32(txtQte.Text)).ToString()
               : txtPrixTotal.Text="" ;
            }
            catch
            {
                return;
            }
           
        }

        private void TxtPrixTotal_TextChanged(object sender, EventArgs e)
        {
            try
            {

                _ = txtPrixTotal.Text != string.Empty ? txtPrixUn.Text = (Convert.ToInt32(txtPrixTotal.Text) / Convert.ToInt32(txtQte.Text)).ToString()
               : txtPrixTotal.Text = "";
            }
            catch
            {
                return;
            }
        }

        private void TxtPrixUn_Validated(object sender, EventArgs e)
        {
            validated();
        }

        private void TxtPrixTotal_Validated(object sender, EventArgs e)
        {
            validated();
        }

        private void Txt_NumOs_KeyPress(object sender, KeyPressEventArgs e)
        {
            // controle the digite 
            if(e.KeyChar==(char)Keys.Enter || e.KeyChar== (char)Keys.Tab)
            {
                txtPrixUn.Focus();
            }
            if (! char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtPrixTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                validated();
            }
        }
    }
}
