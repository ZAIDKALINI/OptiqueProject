using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ProjectMarouane.BL
{
    class CLS_Prod
    {
        DAL.DataAccessLayer data = new DAL.DataAccessLayer();
        public CLS_Prod()
        {

        }
        public void AddProduct(int IdProduct, string ProductName,
                          int IdCat, string ProductDesc, int Qte)
        {
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@IdProduct", SqlDbType.Int);
            param[0].Value = IdProduct;
            param[1] = new SqlParameter("@ProductName", SqlDbType.NVarChar, 250);
            param[1].Value = ProductName;
            param[2] = new SqlParameter("@IdCat", SqlDbType.Int);
            param[2].Value = IdCat;
            param[3] = new SqlParameter("@ProductDesc", SqlDbType.NVarChar, 250);
            param[3].Value = ProductDesc;
            param[4] = new SqlParameter("@QteStock", SqlDbType.Int);
            param[4].Value = Qte;
            param[5] = new SqlParameter("@UniteBuyPrice", SqlDbType.VarChar,50);
            param[5].Value = 0;

            data.ExcuteCommand("AddProd", param);

        }
        public void EditQteProduct(int IdProduct, int Qte)
        {
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@IdProduct", SqlDbType.Int);
            param[0].Value = IdProduct;

            param[1] = new SqlParameter("@Qte", SqlDbType.Int);
            param[1].Value = Qte;
            data.ExcuteCommand("EditQteProduct", param);
        }
        public void EditProduct(int IdProduct, string ProductName,
                          int IdCat, string ProductDesc,int Qte)
        {
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@IdProduct", SqlDbType.Int);
            param[0].Value = IdProduct;
            param[1] = new SqlParameter("@ProductName", SqlDbType.NVarChar, 250);
            param[1].Value = ProductName;
            param[2] = new SqlParameter("@IdCat", SqlDbType.Int);
            param[2].Value = IdCat;
            param[3] = new SqlParameter("@ProductDesc", SqlDbType.NVarChar, 250);
            param[3].Value = ProductDesc;
            param[4] = new SqlParameter("@QteStock", SqlDbType.Int);
            param[4].Value = Qte;
            param[5] = new SqlParameter("@UniteBuyPrice", SqlDbType.VarChar, 50);
            param[5].Value = 0;
            data.ExcuteCommand("EditProd", param);
        }
        public void DeleteProduct(int IdProduct)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@IdProduct", SqlDbType.Int);
            param[0].Value = IdProduct;
            data.ExcuteCommand("EditProd", param);
        }
        public DataTable GetAllCat()
        {

            return data.GetData("GetAllCat", null);
        }
        public DataTable GetAllProduct()
        {

            return data.GetData("GetAllProduct", null);
        }
        public void AddSaleOrder(int @NumOS, string @DescOS, DateTime @SaleDate, int @IdClt, string Vente,
            string @Cnss, string @SaleType, string Total, double Advanced)
        {
            SqlParameter[] param = new SqlParameter[9];

            param[0] = new SqlParameter("@NumOS", SqlDbType.Int);
            param[0].Value = @NumOS;
            param[1] = new SqlParameter("@DescOS", SqlDbType.NVarChar, 250);
            param[1].Value = @DescOS;
            param[2] = new SqlParameter("@SaleDate", SqlDbType.Date);
            param[2].Value = @SaleDate;
            param[3] = new SqlParameter("@IdClt", SqlDbType.Int);
            param[3].Value = @IdClt;
            param[4] = new SqlParameter("@Vente", SqlDbType.NVarChar, 60);
            param[4].Value =   Vente;
            param[5] = new SqlParameter("@Cnss", SqlDbType.NVarChar, 10);
            param[5].Value = @Cnss;
            param[6] = new SqlParameter("@SaleType", SqlDbType.NVarChar, 20);
            param[6].Value = @SaleType;
            param[7] = new SqlParameter("@Total", SqlDbType.NVarChar, 300);
            param[7].Value = Total;
            param[8] = new SqlParameter("@Advanced", SqlDbType.NVarChar, 10);
            param[8].Value = Advanced;

            data.ExcuteCommand("AddSaleOrder", param);
        }

        public void AddDetailsOrder(int NumOS, int IdProduct, int QteProduct,double UnitSalePrice, double TotalPrice)
        {
            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@NumOS", SqlDbType.Int);
            param[0].Value = @NumOS;
            param[1] = new SqlParameter("@IdProduct", SqlDbType.Int);
            param[1].Value = IdProduct;
            param[2] = new SqlParameter("@QteProduct", SqlDbType.Int);
            param[2].Value = QteProduct;
            param[3] = new SqlParameter("@UnitSalePrice", SqlDbType.NVarChar, 10);
            param[3].Value = UnitSalePrice;
            param[4] = new SqlParameter("@TotalPrice", SqlDbType.NVarChar, 10);
            param[4].Value = TotalPrice;


            data.ExcuteCommand("AddDetailsOS", param);
        }
        public void ModifyQte(int IdProduct, int Qte)
        {
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@IdProduct", SqlDbType.Int);
            param[0].Value = IdProduct;
            param[1] = new SqlParameter("@QteStock", SqlDbType.Int);
            param[1].Value = Qte;
            data.ExcuteCommand("ModifyQte", param);
        }
        public DataTable GetInvoices()
        {
            return data.GetData("GetInvoices", null);
        }
        public DataTable GetInvoices(string search)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@search", SqlDbType.NVarChar, 300);
            param[0].Value = search;
            return data.GetData("GetSpecificInv", param);
        }

        public DataTable GetInvoices(DateTime from, DateTime to)
        {
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@from", SqlDbType.Date);
            param[0].Value = from;
            param[1] = new SqlParameter("@to", SqlDbType.Date);
            param[1].Value = to;
            return data.GetData("GetInvByDate", param);
        }
        public void EditInv(int numInv, double price)
        {
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@numInv", SqlDbType.Int);
            param[0].Value = numInv;
            param[1] = new SqlParameter("@price", SqlDbType.VarChar,10);
            param[1].Value = price;
            data.ExcuteCommand("EditInv", param);
        }
        public void EditInv(int numInv, string vente)
        {
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@numInv", SqlDbType.Int);
            param[0].Value = numInv;
            param[1] = new SqlParameter("@vente", SqlDbType.VarChar, 50);
            param[1].Value = vente;
            data.ExcuteCommand("EditInvoice2", param);
        }
        public void DeleteSaleOrder(int numSale)
        {
            
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@numSale", SqlDbType.Int);
            param[0].Value = numSale;
            data.ExcuteCommand("DeleteSaleOrder", param);
        }
        public void EditQte(int IdProduct, int Qte)
        {
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@IdProduct", SqlDbType.Int);
            param[0].Value = IdProduct;
            param[1] = new SqlParameter("@QteStock", SqlDbType.Int);
            param[1].Value = Qte;
            data.ExcuteCommand("EditQte", param);
        }
    }
}
