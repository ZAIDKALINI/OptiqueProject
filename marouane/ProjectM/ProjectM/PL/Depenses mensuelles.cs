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
using ProjectMarouane.PL;

namespace ProjectM.PL
{
    public partial class Depenses_mensuelles : MaterialForm
    {
        BL.CLS_Depense dep = new BL.CLS_Depense();
        BL.Immobilisation immo = new BL.Immobilisation();
        public Depenses_mensuelles()
        {
            InitializeComponent();
            txtN_Immo.Enabled = false;
            txt_Desc.Enabled = false;
            txt_Desc_Dep.Enabled = false;
            txtN_Dep.Enabled = false;
            try
            {
                dgvViewImmo.DataSource = immo.GetViewImmoForMonth();
                //
                if (dep.GetAllDep().Rows.Count != 0)
                {
                    cb_Choix_Dep.DataSource = dep.GetAllDep();
                    cb_Choix_Dep.DisplayMember = "Lebelle";
                    cb_Choix_Dep.ValueMember = "Id_dep";
                    txtN_Dep.Text = cb_Choix_Dep.SelectedValue.ToString();
                }


                ///
                if (immo.GetImmo() != null)
                {
                    cb_Choix.DataSource = immo.GetImmo();
                    cb_Choix.DisplayMember = "Lebelle";
                    cb_Choix.ValueMember = "Num_Imm";
                    txtN_Immo.Text = cb_Choix.SelectedValue.ToString();
                }
               
                
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return;
            }
        }

    

        private void Btn_Sub_Immo_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_New_Immo.Checked)
                {
                    immo.AddImmo(Convert.ToInt32(txtN_Immo.Text), txt_Desc.Text, dp_Immo.Value);
                    immo.AddImmoDet(Convert.ToInt32(txtN_Immo.Text), Convert.ToDouble(txtPrix_Immo.Text), dp_Immo.Value);
                }
                else
                {
                    immo.AddImmoDet(Convert.ToInt32(cb_Choix.SelectedValue), Convert.ToDouble(txtPrix_Immo.Text), dp_Immo.Value);
                }
                
                txtPrix_Immo.Clear();
                txt_Desc.Clear();
                cb_New_Immo.Checked = false;
                MessageBox.Show("Votre opération est effactuer", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvViewImmo.DataSource = immo.GetViewImmoForMonth();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
           
        }

        private void Btn_Sub_Dep_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cb_New_Dep.Checked)
                {
                    dep.AddDep(Convert.ToInt32(txtN_Dep.Text), txt_Desc_Dep.Text, dp_Dep.Value);
                }
                dep.AddDepDet(Convert.ToInt32(txtN_Dep.Text), Convert.ToDouble(txt_Prix_Dep.Text), dp_Dep.Value);
                txt_Prix_Dep.Clear();
                txt_Desc_Dep.Clear();
                MessageBox.Show("Votre opération est effactuer", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cb_New_Dep.Checked = false;
                dgvViewDep.DataSource = dep.GetViewDepForMonth();
            }
            catch
            {
                return;
            }
           
        }

        private void Cb_New_Dep_CheckedChanged(object sender, EventArgs e)
        {
            try
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
            catch
            {
                return;
            }
         
        }

        private void Cb_New_Immo_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cb_New_Immo.Checked)
                {
                    txtN_Immo.Enabled = true;
                    txt_Desc.Enabled = true;
                    cb_Choix.Enabled = false;
                    txtN_Immo.Text = immo.GetIdImmo().Rows[0][0].ToString();
                }
                else
                {
                    txtN_Immo.Enabled = false;
                    txt_Desc.Enabled = false;
                    cb_Choix.Enabled = true;
                    txtN_Immo.Text = cb_Choix.SelectedValue.ToString();
                }
            }
            catch
            {
                return;
            }
         
           
        }

        private void Cb_Choix_Dep_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Cb_Choix_Dep_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtN_Dep.Text = cb_Choix_Dep.SelectedValue.ToString();
            }
            catch
            {
                return;
            }
        }

        private void Cb_Choix_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtN_Immo.Text = cb_Choix.SelectedValue.ToString();
            }
            catch
            {
                return;
            }
        }

        private void Label8_Click(object sender, EventArgs e)
        {
            try
            {
                Confirmation confirmation = new Confirmation();
                if (confirmation.ShowDialog() == DialogResult.OK)
                {
                    var id = Convert.ToInt32(dgvViewImmo.CurrentRow.Cells[0].Value);
                    immo.DeleteImmo(id);
                    dgvViewImmo.DataSource = immo.GetViewImmoForMonth();
                }
               
            }
            catch
            {
                return;
            }
         
        }

        private void Label8_MouseHover(object sender, EventArgs e)
        {
            label8.BackColor = Color.FromArgb(100, Color.Gray);
        }

        private void Label8_MouseLeave(object sender, EventArgs e)
        {
            label8.BackColor = Color.Transparent;
        }

        private void Label14_Click(object sender, EventArgs e)
        {
            try
            {
                Confirmation confirmation = new Confirmation();
                if (confirmation.ShowDialog() == DialogResult.OK)
                {
                    var id = Convert.ToInt32(dgvViewDep.CurrentRow.Cells[0].Value);
                    dep.DeleteDepense(id);
                    dgvViewDep.DataSource = dep.GetViewDepForMonth();
                }

            }
            catch
            {
                return;
            }
        }
    }
}
