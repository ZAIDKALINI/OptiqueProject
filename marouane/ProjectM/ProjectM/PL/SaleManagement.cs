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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions;
using ProjectM.PL;


namespace ProjectMarouane.PL
{
    public partial class SaleManagement : Form
    {
        BL.CLS_Prod prd = new BL.CLS_Prod();
        DataTable dt = new DataTable();
        
        public SaleManagement()
        {
            try
            {
                InitializeComponent();
                FillData();
                CalculeTotaleFacture();
                //
            }
            catch
            {
                return;
            }




        }
        void CalculeTotaleFacture()
        {
            try
            {
                if (dgv_Invoices.Rows.Count > 0)
                {
                    txtFactureE.Text = (from DataGridViewRow r in dgv_Invoices.Rows
                                        where r.Cells[7].FormattedValue.ToString() != string.Empty 
                                        select Convert.ToDouble(r.Cells[8].FormattedValue)).Sum().ToString();

                
                   


                    totalTousFact.Text = (from DataGridViewRow r in dgv_Invoices.Rows
                                          where r.Cells[7].FormattedValue.ToString() != string.Empty
                                          select Convert.ToDouble(r.Cells[7].FormattedValue)).Sum().ToString();

                    txtNonEff.Text = (Convert.ToDouble(totalTousFact.Text) - Convert.ToDouble(txtFactureE.Text)).ToString();

                }
                else
                {
                    txtFactureE.Text = "0";
                }
            }
            catch
            {
                return;
            }
     

        }
        void totleVente()
        {
            ttlVente.Text = dgv_Invoices.Rows.Count.ToString();
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            Sale sale= new Sale();
            sale.ShowDialog();
            ActualizerToolStripMenuItem_Click(sender, e);
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            dgv_Invoices.DataSource = prd.GetInvoices(Search.Text);
            totleVente();
        }

        private void ValueChanged(object sender, EventArgs e)
        {
            //date time picker get invoice by date
            dgv_Invoices.DataSource = prd.GetInvoices(from.Value, to.Value);
            totleVente();
            totalTousFact.Clear();
            CalculeTotaleFacture();
        }

        private void SaleManagement_Load(object sender, EventArgs e)
        {
            ttlVente.Text = dt.Rows.Count.ToString();
        }
        //numero facture pour current row affecter in dgv_Click
        int numOs;
        private void TxtPayer_Validated(object sender, EventArgs e)
        {
            try
            {
                int ind = dgv_Invoices.CurrentRow.Index;
                
                prd.EditInv(Convert.ToInt32(dgv_Invoices.CurrentRow.Cells[0].Value), Convert.ToDouble(txtPayer.Text.Replace('.', ',')));
                dt.Clear();
                dt = prd.GetInvoices();
                dgv_Invoices.DataSource = dt;
                txtRs.Text = (Convert.ToDouble(dgv_Invoices.CurrentRow.Cells[7].Value.ToString().Replace('.',',')) - Convert.ToDouble(dgv_Invoices.CurrentRow.Cells[8].Value.ToString().Replace('.', ','))).ToString();
                dgv_Invoices.CurrentRow.Selected = true;
                if (txtRs.Text == "0")
                {
                    prd.EditInv(numOs, "Effactuer");
                    FillData();
                }


            }
            catch
            {
               
                if(txtRs.Text!=string.Empty && txtPayer.Text != string.Empty)
                if (Convert.ToDouble(txtPayer.Text.Replace('.',',')) > Convert.ToDouble(txtRs.Text.Replace('.',',')))
                {
                    MessageBox.Show("Vous avez dépasser total de facture","Alerte",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                return;
            }
            
        }

        private void TxtPayer_TextChanged(object sender, EventArgs e)
        {

        }
        void FillData()
        {
            dt.Clear();
            dt = prd.GetInvoices();
            dgv_Invoices.DataSource = dt;
        }
      
        private void Dgv_Invoices_MouseClick(object sender, MouseEventArgs e)
        {
            txtPayer.Text = "0";
            try
            {
                //calcul rest
               
                txtRs.Text = (Convert.ToDouble(dgv_Invoices.CurrentRow.Cells[7].Value.ToString().Replace('.', ',')) - Convert.ToDouble(dgv_Invoices.CurrentRow.Cells[8].Value.ToString().Replace('.', ','))).ToString();
                numOs = Convert.ToInt32(dgv_Invoices.CurrentRow.Cells[0].Value);
                //get num sale order for effactuer vente
            }
            catch
            {
             
               // txtRs.Text = dgv_Invoices.CurrentRow.Cells[8].Value.ToString();
                return;
            }
        }

        private void TxtPayer_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
                if (e.KeyChar == (char)Keys.Enter)
                {
                   // TxtPayer_Validated(sender, (EventArgs)e);
                    dgv_Invoices.Focus();
                }
            }
            catch
            {
                return;
            }
           
        }
        DAL.DataAccessLayer data = new DAL.DataAccessLayer();
        BL.CLS_Prod prod = new BL.CLS_Prod();
        private void BtnRemove_Click(object sender, EventArgs e)
        {
            Confirmation cfr = new Confirmation();
            SqlDataAdapter adapter;
            DataTable d = new DataTable();
            if (cfr.ShowDialog() == DialogResult.OK)
            {
                adapter = new SqlDataAdapter("select IdProduct, QteProduct from DetailsOS_tb where NumOS =" + Convert.ToInt32(dgv_Invoices.CurrentRow.Cells[0].Value) + "", data.cn);
                adapter.Fill(d);
                for (int i = 0; i < d.Rows.Count; i++)
                {



                    int idProd = Convert.ToInt32(d.Rows[i][0]);
                    int qte = Convert.ToInt32(d.Rows[i][1]);
                    prod.EditQte(idProd, qte);

                }
                prd.DeleteSaleOrder(Convert.ToInt32(dgv_Invoices.CurrentRow.Cells[0].Value));
                MessageBox.Show("Vous avez effacé cette facture avec succés", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillData();
                ttlVente.Text = dt.Rows.Count.ToString();
                ////

            }
            else
            {
                MessageBox.Show("Vous avez anunler la supression", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
         void Actualizer()
        {
            //FillData();
            //ttlVente.Text = dt.Rows.Count.ToString();
            //CalculeTotaleFacture();
        }
        private void ActualizerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FillData();
            ttlVente.Text = dt.Rows.Count.ToString();
            CalculeTotaleFacture();

        }

        private void Dgv_Invoices_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
           
        }
       
        private void Dgv_Invoices_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {

               Program.i= Convert.ToInt32(dgv_Invoices.CurrentRow.Cells[0].Value);
                ProjectM.PL.View frm = new ProjectM.PL.View();
                frm.Show();


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
        DataTable getSource(int numO)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@NumOS", SqlDbType.Int);
            param[0].Value = numO;
            return data.GetData("PrintOrder", param);
        }
        private void BtnPrintAll_Click(object sender, EventArgs e)
        {
           

        }

        private void AjouterUneVenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sale sale = new Sale();
            sale.ShowDialog();
           
            CalculeTotaleFacture();
        }

        private void SuprimerUneVenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Confirmation cfr = new Confirmation();
            SqlDataAdapter adapter;
            DataTable d = new DataTable();
            try
            {
                if (cfr.ShowDialog() == DialogResult.OK)
                {
                    adapter = new SqlDataAdapter("select IdProduct, QteProduct from DetailsOS_tb where NumOS =" + Convert.ToInt32(dgv_Invoices.CurrentRow.Cells[0].Value) + "", data.cn);
                    adapter.Fill(d);
                    for (int i = 0; i < d.Rows.Count; i++)
                    {



                        int idProd = Convert.ToInt32(d.Rows[i][0]);
                        int qte = Convert.ToInt32(d.Rows[i][1]);
                        prod.EditQte(idProd, qte);

                    }
                    prd.DeleteSaleOrder(Convert.ToInt32(dgv_Invoices.CurrentRow.Cells[0].Value));
                    MessageBox.Show("Vous avez effacé cette facture avec succés", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FillData();
                    ttlVente.Text = dt.Rows.Count.ToString();
                    CalculeTotaleFacture();
                    CalculeTotaleFacture();

                    ////

                }
              
            }
            catch
            {
                return;
            }
           
        }

        private void QuitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ActualizerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ActualizerToolStripMenuItem_Click(sender, e);
        }

        private void Dgv_Invoices_MouseClick_1(object sender, MouseEventArgs e)
        {
            txtPayer.Text = "0";
            try
            {
                //calcul rest
              
                txtRs.Text = (Convert.ToDouble(dgv_Invoices.CurrentRow.Cells[7].Value.ToString().Replace('.', ',')) - Convert.ToDouble(dgv_Invoices.CurrentRow.Cells[8].Value.ToString().Replace('.', ','))).ToString();
                numOs = Convert.ToInt32(dgv_Invoices.CurrentRow.Cells[0].Value);
                //get num sale order for effactuer vente
            }
            catch
            {

                // txtRs.Text = dgv_Invoices.CurrentRow.Cells[8].Value.ToString();
                return;
            }
        }

        private void Dgv_Invoices_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            try
            {

                Program.i = Convert.ToInt32(dgv_Invoices.CurrentRow.Cells[0].Value);
                ProjectM.PL.View frm = new ProjectM.PL.View();
                frm.Show();


            }
            catch
            {
                return;
            }
        }

        private void Panel8_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
