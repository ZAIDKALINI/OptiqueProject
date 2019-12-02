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

namespace ProjectM.PL
{
    public partial class Depenses_mensuelles : MaterialForm
    {
        BL.CLS_Depense dep = new BL.CLS_Depense();
        public Depenses_mensuelles()
        {
            InitializeComponent();
            txtN_Immo.Enabled = false;
            txt_Desc.Enabled = false;
            txt_Desc_Dep.Enabled = false;
            txtN_Dep.Enabled = false;
            try
            {
                cb_Choix_Dep.DataSource = dep.GetAllDep();
                cb_Choix_Dep.DisplayMember = "Lebelle";
                cb_Choix_Dep.ValueMember = "Id_dep";
                txtN_Dep.Text = cb_Choix_Dep.SelectedValue.ToString();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

    

        private void Btn_Sub_Immo_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Sub_Dep_Click(object sender, EventArgs e)
        {
            if (Cb_New_Dep.Checked)
            {
                dep.AddDep(Convert.ToInt32(txtN_Dep.Text), txt_Desc_Dep.Text, dp_Dep.Value);
            }
            dep.AddDepDet(Convert.ToInt32(txtN_Dep.Text), Convert.ToDouble(txt_Prix_Dep.Text));
            txt_Prix_Dep.Clear();
            txt_Desc_Dep.Clear();
            MessageBox.Show("Votre opération est effactuer", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Cb_New_Dep_CheckedChanged(object sender, EventArgs e)
        {
            if (Cb_New_Dep.Checked)
            {
                txt_Desc_Dep.Enabled = true;
                txtN_Dep.Enabled = true;
                cb_Choix_Dep.Enabled = false;
                txtN_Dep.Text = dep.GetIdDep().Rows[0][0].ToString();
            }
            else
            {
                txt_Desc_Dep.Enabled = false;
                txtN_Dep.Enabled = false;
                cb_Choix_Dep.Enabled = true;
                txtN_Dep.Text = cb_Choix_Dep.SelectedValue.ToString();
            }
        }

        private void Cb_New_Immo_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_New_Immo.Checked)
            {
                txtN_Immo.Enabled = true;
                txt_Desc.Enabled = true;
            }
            else
            {
                txtN_Immo.Enabled = false;
                txt_Desc.Enabled = false;
            }
           
        }

        private void Cb_Choix_Dep_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Cb_Choix_Dep_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtN_Dep.Text = cb_Choix_Dep.SelectedValue.ToString();
        }
    }
}
