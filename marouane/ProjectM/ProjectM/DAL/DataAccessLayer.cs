using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProjectMarouane.DAL
{
    class DataAccessLayer
    {
        public SqlConnection cn;
       public DataAccessLayer()
        {
            if(ProjectM.Properties.Resources.Authentification== "Windows")
            cn = new SqlConnection("Server="+ ProjectM.Properties.Resources.Server + ";DataBase =" + ProjectM.Properties.Resources.DataBase + ";integrated security = true");
        }
        public void Open()
        {
            if (cn.State != ConnectionState.Open)
            {
                cn.Open();
            }
        }
        public void Close()
        {
            if (cn.State != ConnectionState.Closed)
            {
                cn.Close();
            }
        }
        public DataTable GetData(string Stored_Procedure, SqlParameter []param)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = Stored_Procedure;
            cmd.CommandType = CommandType.StoredProcedure;
            
            cmd.Connection = cn;
            if (param != null)
            {
                cmd.Parameters.AddRange(param);
                
            }
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;


        }
        public void ExcuteCommand(string stored_Procedure, SqlParameter[] param)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = stored_Procedure;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddRange(param);
            cmd.Connection = cn;
            Open();
            cmd.ExecuteNonQuery();
            Close();
        }
    }
}
