using ProjectMarouane.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectM.BL
{
    class CLS_Avoire
    {
        DataAccessLayer data = new DataAccessLayer();
        public void AddAvoire(int Id, int NumOB, DateTime Dateavoir)
        {
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@Id", SqlDbType.Int);
            param[0].Value = Id;

            param[1] = new SqlParameter("@NumOB", SqlDbType.Int);
            param[1].Value = NumOB;

            param[2] = new SqlParameter("@Dateavoir", SqlDbType.Date);
            param[2].Value = Dateavoir;
            data.ExcuteCommand("AddAvoire", param);


        }

        public void EditAvoire(int Id, int NumOB, DateTime Dateavoir)
        {
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@Id", SqlDbType.Int);
            param[0].Value = Id;

            param[1] = new SqlParameter("@NumOB", SqlDbType.Int);
            param[1].Value = NumOB;

            param[2] = new SqlParameter("@Dateavoir", SqlDbType.Date);
            param[2].Value = Dateavoir;
            data.ExcuteCommand("EditAvoire", param);

        }
        public void DeleteAvoire(int Id)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Id", SqlDbType.Int);
            param[0].Value = Id;

            data.ExcuteCommand("DeleteAvoire", param);

        }

        public void AddAvoireDet(int Id, int Id_product, int Qte_retourner, double Prix )
        {
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@Id", SqlDbType.Int);
            param[0].Value = Id;

            param[1] = new SqlParameter("@Id_product", SqlDbType.Int);
            param[1].Value = Id_product;

            param[2] = new SqlParameter("@Qte_retourner", SqlDbType.Int);
            param[2].Value = Qte_retourner;

            param[3] = new SqlParameter("@Prix", SqlDbType.VarChar,50);
            param[3].Value = Prix;
            data.ExcuteCommand("AddAvoireDet", param);


        }
        public void EditAvoireDet(int Id, int Id_product, int Qte_retourner, double Prix)
        {
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@Id", SqlDbType.Int);
            param[0].Value = Id;

            param[1] = new SqlParameter("@Id_product", SqlDbType.Int);
            param[1].Value = Id_product;

            param[2] = new SqlParameter("@Qte_retourner", SqlDbType.Int);
            param[2].Value = Qte_retourner;

            param[3] = new SqlParameter("@Prix", SqlDbType.VarChar, 50);
            param[3].Value = Prix;
            data.ExcuteCommand("EditAvoireDet", param);


        }
        public DataTable getDetBuyAvoire(int NumOB)
        {
            //getDetails Avoire
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@NumOB", SqlDbType.Int);
            param[0].Value = NumOB;

           return data.GetData("getDetBuyAvoire", param);

        }
        public DataTable GetAvId()
        {            
            // get num avaoir concatect with year of system
            return data.GetData("GetAvId", null);
        }
    }
}
