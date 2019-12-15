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
    public partial class Gestion : Form
    {
        Manager manager = new Manager();
        public static DateTime from, to;
        public static string Btnsend;//for know how send the order for details
        public Gestion()
        {
            InitializeComponent();
        }

        private void Gestion_Load(object sender, EventArgs e)
        {
            
        }

        

      /// <summary>
      /// Value dateChanged
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>

        private void date(object sender, EventArgs e)
        {
            from = dtpFrom.Value;
            to = dtpTo.Value;
            // label Business number
            string BusNum = manager.getBusinessNumber(from, to).Rows[0][0].ToString();
            _ =BusNum !=string.Empty?lblBN.Text= BusNum+" DH": lblBN.Text = "0 DH";
            // label Sale number
            string SaleNum = manager.GetSaleNumber(from, to).Rows[0][0].ToString();
            _ = SaleNum != string.Empty ? lblNS.Text = SaleNum  : lblNS.Text = "0";
            //label Buy Number
            string BuyNum = manager.GetTotalByOrderByDate(from, to).Rows[0][0].ToString();
            _ = BuyNum != string.Empty ? lblBuyNum.Text = BuyNum : lblBuyNum.Text = "0";
            //label Count client 
            string CountClient = manager.getTotalCltByDate(from, to).Rows[0][0].ToString();
            _ = CountClient != string.Empty ? lblTtlClt.Text = CountClient : lblTtlClt.Text = "0";
            //label for calcule total price on Product saling between period 
            string Total = manager.getTotalBuyingProduct(from, to).Rows[0][0].ToString();
            _ = Total != string.Empty ? lblPriceSalingProduct.Text = Total + " DH" : lblPriceSalingProduct.Text = "0 DH";
            //label Count Avoire 
            string CountAv = manager.GetTotalAvByDate(from, to).Rows[0][0].ToString();
            _ = CountAv != string.Empty ? lblAvoire.Text = CountAv : lblAvoire.Text = "0";
            //label DepenseMensuel
            string Dep = manager.GetDepenseMens(from, to).Rows[0][0].ToString();
            _ = Dep != string.Empty ? lblDep.Text = Dep : lblDep.Text = "0";
            // Calcule Rest
            Reste();

        }
        /// <summary>
        /// Calcule Reste
        /// </summary>
        void Reste()
        {
            var res = manager.getDecimal(lblBN.Text) - manager.getDecimal(lblPriceSalingProduct.Text) - manager.getDecimal(lblDep.Text);
            lblRest.Text = res.ToString()+" DH";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Btnsend = "NombreAchat";
            Details det = new Details();
            det.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Btnsend = "Avoire";
            Details det = new Details();
            det.ShowDialog();
        }

        private void Btn_add_dep_Click(object sender, EventArgs e)
        {
            Depenses_mensuelles depenses = new Depenses_mensuelles();
            depenses.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Btnsend = "PrixProdVendu";
            Details det = new Details();
            det.ShowDialog();
        }
    }
}
