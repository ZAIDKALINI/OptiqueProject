using ProjectM.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectM.PL
{
    public partial class Details : Form
    {
     
        //Class manager
        Manager manager = new Manager();
        public Details()
        {
            InitializeComponent();
            try
            {
                if (Gestion.Btnsend == "PrixProdVendu")
                {
                    dgv.DataSource = manager.DetailsProductSale(Gestion.from, Gestion.to);
                    label2.Text = "Details des produits vendu entre :           " + Gestion.from.ToShortDateString() + " et " + Gestion.to.ToShortDateString();
                }


                else if (Gestion.Btnsend == "NombreAchat")
                {
                    dgv.DataSource = manager.DetailsProductBuying(Gestion.from, Gestion.to);
                    label2.Text = "Details des produits Acheté entre :          " + Gestion.from.ToShortDateString() + " et " + Gestion.to.ToShortDateString();
                }

                else if (Gestion.Btnsend == "Avoire")
                {
                    label2.Text = "Details des avoire entre :          " + Gestion.from.ToShortDateString() + " et " + Gestion.to.ToShortDateString();
                    dgv.DataSource = manager.getDetailsAvoire(Gestion.from, Gestion.to);
                }
            }
            catch
            {
                return;
            }
          
                

        }

        private void Label1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Label1_MouseHover(object sender, EventArgs e)
        {
            label1.BackColor = Color.FromArgb(100, Color.Black);
        }

        private void Label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
        }

       
    }
}
