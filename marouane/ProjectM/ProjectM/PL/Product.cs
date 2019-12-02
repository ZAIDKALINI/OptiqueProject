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
using System.Globalization;
using MaterialSkin.Controls;

namespace ProjectMarouane.PL
{
    public partial class Product : MaterialForm
    {
       
        BL.CLS_Prod prd = new BL.CLS_Prod();
        DAL.DataAccessLayer data = new DAL.DataAccessLayer();
        
       
        public Product()
        {
            InitializeComponent();
            try
            {
                cbCat.DataSource = prd.GetAllCat();
                cbCat.DisplayMember = "DescCat";
                cbCat.ValueMember = "IdCat";
                txtId.Text = data.GetData("getIDPRod", null).Rows[0][0].ToString();
            }
            catch
            {
                return;
            }
           

        }
       
        private void Btn_add_Click(object sender, EventArgs e)
        {
            
         
            if (txtNomP.Text == string.Empty || txtNomP.ForeColor == Color.Red)
            {
                txtNomP.Text = "Entrez Nom de produit !!";
                txtNomP.ForeColor = Color.Red;
                return;
            }
          

            try
            {
                prd.AddProduct(Convert.ToInt32(txtId.Text), txtNomP.Text,Convert.ToInt32(cbCat.SelectedValue), txtdes.Text, 0);
                MessageBox.Show("Vous avez ajouter votre produit avec succés", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Information);
             
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

   

        private void changed(object sender, EventArgs e)
        {
            
            //var text = sender as MaterialSingleLineTextField;
            
            //text.ForeColor = Color.Black;
        }

        private void TxtQte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsSeparator(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
               
            }
        }

        private void CbCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Qte(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Category ct = new Category();
            ct.ShowDialog();
        }
    }
}
