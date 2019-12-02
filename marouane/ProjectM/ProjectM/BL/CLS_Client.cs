using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProjectM.BL
{
    class CLS_Client
    {
        ProjectMarouane.DAL.DataAccessLayer data = new ProjectMarouane.DAL.DataAccessLayer();
        public CLS_Client()
        {

        }
        public void AddClient(int IdClt, string NomClt, string Tele, string Email, string Age, DateTime date)
        {
            SqlParameter [] param = new SqlParameter[6];
            param[0] = new SqlParameter("@IdClt", SqlDbType.Int);
            param[0].Value = IdClt;

            param[1] = new SqlParameter("@NomClt", SqlDbType.NVarChar,60);
            param[1].Value = NomClt;

            param[2] = new SqlParameter("@Tele", SqlDbType.NVarChar, 100);
            param[2].Value = Tele;

            param[3] = new SqlParameter("@Email", SqlDbType.NVarChar, 100);
            param[3].Value = Email;

            param[4] = new SqlParameter("@Age", SqlDbType.VarChar,50);
            param[4].Value = Age;

            param[5] = new SqlParameter("@dateins", SqlDbType.Date);
            param[5].Value = date;

            data.ExcuteCommand("AddClient", param);
        }

        public void EditClient(int IdClt, string NomClt, string Tele, string Email, string Age, DateTime date)
        {
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@IdClt", SqlDbType.Int);
            param[0].Value = IdClt;

            param[1] = new SqlParameter("@NomClt", SqlDbType.NVarChar, 60);
            param[1].Value = NomClt;

            param[2] = new SqlParameter("@Tele", SqlDbType.NVarChar, 100);
            param[2].Value = Tele;

            param[3] = new SqlParameter("@Email", SqlDbType.NVarChar, 100);
            param[3].Value = Email;

            param[4] = new SqlParameter("@Age", SqlDbType.VarChar, 50);
            param[4].Value = Age;

            param[5] = new SqlParameter("@dateins", SqlDbType.Date);
            param[5].Value = date;

            data.ExcuteCommand("EditClient", param);
        }
        public void DeleteClient(int IdClt)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@IdClt", SqlDbType.Int);
            param[0].Value = IdClt;
            data.ExcuteCommand("DeleteClient", param);
        }

        public int getId()
        {
            int id = Convert.ToInt32(data.GetData("getId", null).Rows[0][0]);
            return id;
        }

        public DataTable GetAllClient()
        {
            return data.GetData("GetAllClient", null);
        }
        public DataTable SearchClt(string search)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@search", SqlDbType.NVarChar,100);
            param[0].Value = search;
            return data.GetData("SearchClt", null);
        }
        public void AddLeftSize(int IdClt, string SphVL, string SphVP, string CylVL, string CylVP, string AxeVL, string AxeVP, string Add, int NumOS)
        {
            SqlParameter[] param = new SqlParameter[9];
            param[0] = new SqlParameter("@IdClt", SqlDbType.Int);
            param[0].Value = IdClt;

            param[1] = new SqlParameter("@SphVL", SqlDbType.NVarChar, 50);
            param[1].Value = SphVL;

            param[2] = new SqlParameter("@SphVP", SqlDbType.NVarChar, 50);
            param[2].Value = SphVP;

            param[3] = new SqlParameter("@CylVL", SqlDbType.NVarChar, 50);
            param[3].Value = CylVL;

            param[4] = new SqlParameter("@CylVP", SqlDbType.NVarChar, 50);
            param[4].Value = CylVP;

            param[5] = new SqlParameter("@AxeVL", SqlDbType.NVarChar, 50);
            param[5].Value = AxeVL;

            param[6] = new SqlParameter("@AxeVP", SqlDbType.NVarChar, 50);
            param[6].Value = AxeVP;

            param[7] = new SqlParameter("@Add", SqlDbType.NVarChar, 50);
            param[7].Value = Add;

            param[8] = new SqlParameter("@NumOS", SqlDbType.Int);
            param[8].Value = NumOS;

            data.ExcuteCommand("AddLeftSize", param);

        }

        public void AddRighttSize(int IdClt, string SphVL, string SphVP, string CylVL, string CylVP, string AxeVL, string AxeVP, string Add,  int NumOS)
        {
            SqlParameter[] param = new SqlParameter[9];
            param[0] = new SqlParameter("@IdClt", SqlDbType.Int);
            param[0].Value = IdClt;

            param[1] = new SqlParameter("@SphVL", SqlDbType.NVarChar, 50);
            param[1].Value = SphVL;

            param[2] = new SqlParameter("@SphVP", SqlDbType.NVarChar, 50);
            param[2].Value = SphVP;

            param[3] = new SqlParameter("@CylVL", SqlDbType.NVarChar, 50);
            param[3].Value = CylVL;

            param[4] = new SqlParameter("@CylVP", SqlDbType.NVarChar, 50);
            param[4].Value = CylVP;

            param[5] = new SqlParameter("@AxeVL", SqlDbType.NVarChar, 50);
            param[5].Value = AxeVL;

            param[6] = new SqlParameter("@AxeVP", SqlDbType.NVarChar, 50);
            param[6].Value = AxeVP;

            param[7] = new SqlParameter("@Add", SqlDbType.NVarChar, 50);
            param[7].Value = Add;

            param[8] = new SqlParameter("@NumOS", SqlDbType.Int);
            param[8].Value = NumOS;

            data.ExcuteCommand("AddRighttSize", param);

        }


    }
}
