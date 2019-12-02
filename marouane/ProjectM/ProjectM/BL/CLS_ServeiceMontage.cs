using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ProjectMarouane.DAL;

namespace ProjectM.BL
{
    class CLS_ServeiceMontage
    {
        DataAccessLayer Data = new DataAccessLayer();
        public void AddServiceMontage(int IdMontage, string nomMontage, DateTime Date_de_service, string Tele)
        {
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@IdMontage", SqlDbType.Int);
            param[0].Value = IdMontage;

            param[1] = new SqlParameter("@nomMontage", SqlDbType.VarChar,100);
            param[1].Value = nomMontage;

            param[2] = new SqlParameter("@Date_de_service", SqlDbType.Date);
            param[2].Value = Date_de_service;

            param[3] = new SqlParameter("@Tele", SqlDbType.VarChar,14);
            param[3].Value = Tele;

            Data.ExcuteCommand("AddServiceMontage", param);

        }
        public void EditServiceMontage(int IdMontage, string nomMontage, DateTime Date_de_service, string Tele)
        {
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@IdMontage", SqlDbType.Int);
            param[0].Value = IdMontage;

            param[1] = new SqlParameter("@nomMontage", SqlDbType.VarChar, 100);
            param[1].Value = nomMontage;

            param[2] = new SqlParameter("@Date_de_service", SqlDbType.Date);
            param[2].Value = Date_de_service;

            param[3] = new SqlParameter("@Tele", SqlDbType.VarChar, 14);
            param[3].Value = Tele;

            Data.ExcuteCommand("EditServiceMontage", param);
        }

        public void DeleteServiceMontage(int IdMontage)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@IdMontage", SqlDbType.Int);
            param[0].Value = IdMontage;
            Data.ExcuteCommand("DeleteServiceMontage", param);
        }

        public void AddDetails_service(int IdMontage, int NumOS, int Qte, double UnitePrice, double Total)
        {
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@IdMontage", SqlDbType.Int);
            param[0].Value = IdMontage;

            param[1] = new SqlParameter("@NumOS", SqlDbType.Int);
            param[1].Value = NumOS;

            param[2] = new SqlParameter("@Qte", SqlDbType.Int);
            param[2].Value = Qte;

            param[3] = new SqlParameter("@UnitePrice", SqlDbType.VarChar, 50);
            param[3].Value = UnitePrice;

            param[4] = new SqlParameter("@Total", SqlDbType.VarChar, 50);
            param[4].Value = Total;

            Data.ExcuteCommand("AddDetails_service", param);

        }
        public void EditDetails_service(int IdMontage, int NumOS, int Qte, double UnitePrice, double Total)
        {
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@IdMontage", SqlDbType.Int);
            param[0].Value = IdMontage;

            param[1] = new SqlParameter("@NumOS", SqlDbType.Int);
            param[1].Value = NumOS;

            param[2] = new SqlParameter("@Qte", SqlDbType.Int);
            param[2].Value = Qte;

            param[3] = new SqlParameter("@UnitePrice", SqlDbType.VarChar, 50);
            param[3].Value = UnitePrice;

            param[4] = new SqlParameter("@Total", SqlDbType.VarChar, 50);
            param[4].Value = Total;
            Data.ExcuteCommand("EditDetails_service", param);
        }
        public void DeleteDetServiceMontage(int IdMontage)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@IdMontage", SqlDbType.Int);
            param[0].Value = IdMontage;
            Data.ExcuteCommand("DeleteDetServiceMontage", param);
        }
        public DataTable getProdForServiceMontage (int numos)
        {
            // get designation and quantity glass for sale order set on parameter
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@NumOS", SqlDbType.Int);
            param[0].Value = numos;
            return Data.GetData("getProdForServiceMontage", param);
        }
        public int getNumService()
        {
            // get Last idserviceMontage + 1
           
            return Convert.ToInt32(Data.GetData("getNumService", null).Rows[0][0]);
        }
        public DataTable getOrderDService()
        {
            // return Service Order with some details
          
            return Data.GetData("getOrderDService", null);
        }
    }
}
