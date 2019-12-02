using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectMarouane.DAL;
using System.Data.SqlClient;
using System.Data;

namespace ProjectM.BL
{
    class CLS_Buying_Order
    {
        DataAccessLayer data = new DataAccessLayer();
        public CLS_Buying_Order()
        {

        }
        public void addDetBuying(int NumOB, int IdProduct, int QteProduct, double TotalHT, double TVA, double TTC)
        {
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@NumOB", SqlDbType.Int);
            param[0].Value = NumOB;

            param[1] = new SqlParameter("@IdProduct", SqlDbType.Int);
            param[1].Value = IdProduct;
                 
            param[2] = new SqlParameter("@QteProduct", SqlDbType.Int);
            param[2].Value = QteProduct;

            param[3] = new SqlParameter("@TotalHT", SqlDbType.NVarChar, 50);
            param[3].Value = TotalHT;

            param[4] = new SqlParameter("@TVA", SqlDbType.NVarChar, 50);
            param[4].Value = TVA;

            param[5] = new SqlParameter("@TTC", SqlDbType.NVarChar, 50);
            param[5].Value = TTC;

            data.GetData("AddDOB", param);
        }

        public void ModifyBuyingDet(int NumOB, int IdProduct, int QteProduct, double TotalHT, double TVA, double TTC)
        {
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@NumOB", SqlDbType.Int);
            param[0].Value = NumOB;

            param[1] = new SqlParameter("@IdProduct", SqlDbType.Int);
            param[1].Value = IdProduct;

            param[2] = new SqlParameter("@QteProduct", SqlDbType.Int);
            param[2].Value = QteProduct;

            param[3] = new SqlParameter("@TotalHT", SqlDbType.NVarChar, 50);
            param[3].Value = TotalHT;

            param[4] = new SqlParameter("@TVA", SqlDbType.NVarChar, 50);
            param[4].Value = TVA;

            param[5] = new SqlParameter("@TTC", SqlDbType.NVarChar, 50);
            param[5].Value = TTC;

            data.GetData("ModifyBuyingDet", param);
        }

        public void AddOrderBuying(int NumOB, string DescOB, DateTime DateOB, int IdProvider, string BuyingType)
        {
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@NumOB", SqlDbType.Int);
            param[0].Value = NumOB;

            param[1] = new SqlParameter("@DescOB", SqlDbType.NVarChar, 250);
            param[1].Value = DescOB;

            param[2] = new SqlParameter("@DateOB", SqlDbType.Date);
            param[2].Value = DateOB;

            param[3] = new SqlParameter("@IdProvider", SqlDbType.Int);
            param[3].Value = IdProvider;

            param[4] = new SqlParameter("@BuyingType", SqlDbType.NVarChar, 250);
            param[4].Value = BuyingType;

          

            data.GetData("AddOrderBuying", param);
        }

        public void ModifyOrderBuying(int NumOB, string DescOB, DateTime DateOB, int IdProvider, string BuyingType)
        {
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@NumOB", SqlDbType.Int);
            param[0].Value = NumOB;

            param[1] = new SqlParameter("@DescOB", SqlDbType.NVarChar, 250);
            param[1].Value = DescOB;

            param[2] = new SqlParameter("@DateOB", SqlDbType.Date);
            param[2].Value = DateOB;

            param[3] = new SqlParameter("@IdProvider", SqlDbType.Int);
            param[3].Value = IdProvider;

            param[4] = new SqlParameter("@BuyingType", SqlDbType.NVarChar, 250);
            param[4].Value = BuyingType;



            data.GetData("ModifyOrderBuying", param);
        }
        public void DeleteOrderBuying(int NumOB)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@NumOB", SqlDbType.Int);
            param[0].Value = NumOB;
            data.GetData("DeleteOrderBuying", param);
        }

     }
}
