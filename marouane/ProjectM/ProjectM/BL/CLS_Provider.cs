using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProjectMarouane.BL
{
    class CLS_Provider
    {
        DAL.DataAccessLayer data = new DAL.DataAccessLayer();
        public CLS_Provider()
        {

        }
        public void AddProvider(int IdProvider,  string ProviderName, string Tele1, string Tele2,
                          string Tele3, string Tele4, string Email)
        {
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@IdProvider", SqlDbType.Int);
            param[0].Value = IdProvider;
            
            param[1] = new SqlParameter("@ProviderName", SqlDbType.NVarChar, 60);
            param[1].Value = ProviderName;
            param[2] = new SqlParameter("@Tele1", SqlDbType.NChar, 14);
            param[2].Value = Tele1;
            param[3] = new SqlParameter("@Tele2", SqlDbType.NChar, 14);
            param[3].Value = Tele2;
            param[4] = new SqlParameter("@Tele3", SqlDbType.NChar, 14);
            param[4].Value = Tele3;
            param[5] = new SqlParameter("@Tele4", SqlDbType.NChar, 14);
            param[5].Value = Tele4;
            param[6] = new SqlParameter("@Email", SqlDbType.NVarChar, 100);
            param[6].Value = Email;

            data.ExcuteCommand("AddProvider", param);

        }
        public void EditProvider(int IdProvider, string ProviderName, string Tele1, string Tele2,
                        string Tele3, string Tele4, string Email)
        {
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@IdProvider", SqlDbType.Int);
            param[0].Value = IdProvider;

            param[1] = new SqlParameter("@ProviderName", SqlDbType.NVarChar, 60);
            param[1].Value = ProviderName;
            param[2] = new SqlParameter("@Tele1", SqlDbType.NChar, 14);
            param[2].Value = Tele1;
            param[3] = new SqlParameter("@Tele2", SqlDbType.NChar, 14);
            param[3].Value = Tele2;
            param[4] = new SqlParameter("@Tele3", SqlDbType.NChar, 14);
            param[4].Value = Tele3;
            param[5] = new SqlParameter("@Tele4", SqlDbType.NChar, 14);
            param[5].Value = Tele4;
            param[6] = new SqlParameter("@Email", SqlDbType.NVarChar, 100);
            param[6].Value = Email;

            data.ExcuteCommand("EditProvider", param);

        }
        public void DeleteProvider(int IdProvider)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@IdProvider", SqlDbType.Int);
            param[0].Value = IdProvider;
            data.ExcuteCommand("DeleteProvider", param);
        }
    }
}
