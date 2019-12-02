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
using MaterialSkin.Controls;

namespace ProjectMarouane.PL
{
    public partial class Category : MaterialForm
    {
        DAL.DataAccessLayer data = new DAL.DataAccessLayer();
        DataTable dt = new DataTable();
        BindingManagerBase bmb;
        SqlCommandBuilder cmdb;
        SqlDataAdapter adapter;
        public Category()
        {
            InitializeComponent();
            try
            {
                btn_add.Enabled = false;
                adapter = new SqlDataAdapter("select * from Category_tb", data.cn);
                adapter.Fill(dt);
                txtId.DataBindings.Add("Text", dt, "IdCat");
                txtDesc.DataBindings.Add("Text", dt, "DescCat");
                bmb = this.BindingContext[dt];
                dataGridView1.DataSource = dt;
                label3.Text = bmb.Position + 1 + "/" + bmb.Count;
            }
            catch
            {
                return;
            }

        }
        //last pos
        private void Button6_Click(object sender, EventArgs e)
        {
            bmb.Position = bmb.Count;
            label3.Text = bmb.Position+1+"/"+bmb.Count;
        }
        //next
        private void Button7_Click(object sender, EventArgs e)
        {
            bmb.Position++;
            label3.Text = bmb.Position+1 + "/" + bmb.Count;

        }
        //back
        private void Button8_Click(object sender, EventArgs e)
        {
            bmb.Position--;
            label3.Text = bmb.Position + 1 + "/" + bmb.Count;
        }
        //last pos
        private void Button5_Click(object sender, EventArgs e)
        {
            bmb.Position = 0;
            label3.Text = bmb.Position + 1 + "/" + bmb.Count;
        }
        //Clear boxes for add categories
        private void Btn_new_Click(object sender, EventArgs e)
        {
            //Get Last Id
          
            try
            {
                int ind = dataGridView1.Rows.Count - 1;
                bmb.AddNew();
                txtId.Text = (Convert.ToInt32(dataGridView1.Rows[ind].Cells[0].Value) + 1).ToString();
                btn_add.Enabled = true;
                btn_new.Enabled = false;
                label3.Text = bmb.Position + 1 + "/" + bmb.Count;
            }
            catch
            {
                txtId.Text = "1";
                return;
            }
          

        }
        //Add Category
        private void Btn_add_Click(object sender, EventArgs e)
        {
         
            if (txtDesc.Text != "")
            {
                bmb.EndCurrentEdit();
                cmdb = new SqlCommandBuilder(adapter);
                adapter.Update(dt);
                MessageBox.Show("Vous avez ajouté votre catégorie avec succés", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                label3.Text = bmb.Position + 1 + "/" + bmb.Count;
                btn_add.Enabled = false;
                btn_new.Enabled = true;
            }
            else
            {
                txtDesc.Focus();
            }
            
        }
        // Modify Category
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            bmb.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(adapter);
            adapter.Update(dt);
            MessageBox.Show("Vous avez modifié votre catégorie avec succés", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);
            label3.Text = bmb.Position + 1 + "/" + bmb.Count;
        }
        // Remove Category
        private void BtnRemove_Click(object sender, EventArgs e)
        {
            bmb.RemoveAt(bmb.Position);
            cmdb = new SqlCommandBuilder(adapter);
            adapter.Update(dt);
            MessageBox.Show("Vous avez suprimé votre catégorie avec succés", "Suprimer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            label3.Text = bmb.Position + 1 + "/" + bmb.Count;
        }

        private void DataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_new_Click_1(object sender, EventArgs e)
        {

        }
    }
}
