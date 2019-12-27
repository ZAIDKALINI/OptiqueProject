using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ProjectMarouane.DAL;
using System.Globalization;

namespace ProjectM.BL
{
    class Manager
    {
        DataAccessLayer data = new DataAccessLayer();
        public DataTable getBusinessNumber (DateTime from, DateTime to)
        {
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@from", SqlDbType.Date);
            param[0].Value = from;
            param[1] = new SqlParameter("@To", SqlDbType.Date);
            param[1].Value = to;

            return data.GetData("getBusinessNumber", param);

        }
        public DataTable GetSaleNumber(DateTime from, DateTime to)
        {
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@from", SqlDbType.Date);
            param[0].Value = from;
            param[1] = new SqlParameter("@To", SqlDbType.Date);
            param[1].Value = to;

            return data.GetData("GetSaleNumber", param);


        }
        public DataTable GetTotalByOrderByDate(DateTime from, DateTime to)
        {
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@from", SqlDbType.Date);
            param[0].Value = from;
            param[1] = new SqlParameter("@To", SqlDbType.Date);
            param[1].Value = to;

            return data.GetData("GetTotalByOrderByDate", param);


        }

        public DataTable getTotalCltByDate (DateTime from, DateTime to)
        {
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@from", SqlDbType.Date);
            param[0].Value = from;
            param[1] = new SqlParameter("@To", SqlDbType.Date);
            param[1].Value = to;

            return data.GetData("getTotalCltByDate", param);


        }

        public DataTable getTotalBuyingProduct(DateTime from, DateTime to)
        {
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@from", SqlDbType.Date);
            param[0].Value = from;
            param[1] = new SqlParameter("@To", SqlDbType.Date);
            param[1].Value = to;

            return data.GetData("getTotalBuyingProduct", param);


        }
        public DataTable GetTotalAvByDate(DateTime from, DateTime to)
        {
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@from", SqlDbType.Date);
            param[0].Value = from;
            param[1] = new SqlParameter("@To", SqlDbType.Date);
            param[1].Value = to;

            return data.GetData("GetTotalAvByDate", param);

        }
        public DataTable DetailsProductSale(DateTime from, DateTime to)
        {
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@from", SqlDbType.Date);
            param[0].Value = from;
            param[1] = new SqlParameter("@To", SqlDbType.Date);
            param[1].Value = to;

            return data.GetData("DetailsProductSale", param);

        }
        public DataTable DetailsProductBuying(DateTime from, DateTime to)
        {
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@from", SqlDbType.Date);
            param[0].Value = from;
            param[1] = new SqlParameter("@To", SqlDbType.Date);
            param[1].Value = to;

            return data.GetData("DetailsProductBuying", param);

        }
        public DataTable getDetailsAvoire(DateTime from, DateTime to)
        {
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@from", SqlDbType.Date);
            param[0].Value = from;
            param[1] = new SqlParameter("@To", SqlDbType.Date);
            param[1].Value = to;

            return data.GetData("getDetailsAvoire", param);

        }
        public DataTable GetDepenseMens(DateTime from, DateTime to)
        {
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@from", SqlDbType.Date);
            param[0].Value = from;
            param[1] = new SqlParameter("@to", SqlDbType.Date);
            param[1].Value = to;

            return data.GetData("GetDepenseMens", param);

        }
        /// <summary>
        /// Get just number from any string
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public double getDecimal (string text)
        {
            var Array = text.Where(c => char.IsDigit(c) || c.ToString() == CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator).ToArray();
            string str = null;
            for (int i=0; i < Array.Length; i++)
            {
                str += Array[i];
            }
            return Convert.ToDouble(str);
        }
    }
}
