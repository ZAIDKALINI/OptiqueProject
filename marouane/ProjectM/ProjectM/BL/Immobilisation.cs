using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProjectM.BL
{
    class Immobilisation
    {
        ProjectMarouane.DAL.DataAccessLayer data = new ProjectMarouane.DAL.DataAccessLayer();
        /// <summary>
        /// for add immoilisation
        /// </summary>
        /// <param name="Num_Imm"></param>
        /// <param name="Lebelle"></param>
        /// <param name="Date_Immo"></param>
        public void AddImmo(int Num_Imm, string Lebelle, DateTime Date_Immo )
        {
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@Num_Imm", Num_Imm);
            param[1] = new SqlParameter("@Lebelle", Lebelle);
            param[2] = new SqlParameter("@Date_Immo", Date_Immo);
            data.ExcuteCommand("AddImmo", param);

        }
        /// <summary>
        /// for add details immobilisation
        /// </summary>
        /// <param name="Num_Imm"></param>
        /// <param name="Prix"></param>
        public void AddImmoDet(int Num_Imm,Double Prix)
        {
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@Num_Imm", Num_Imm);
            param[1] = new SqlParameter("@Prix", Prix);
            
            data.ExcuteCommand("AddImmoDet", param);

        }
        /// <summary>
        /// get Immobilisation
        /// </summary>
        /// <param name="Num_Imm"></param>
        /// <param name="Prix"></param>
        /// <returns></returns>
        public DataTable GetImmo()
        {


            return data.GetData("GetImmo", null);

        }
        /// <summary>
        /// Get new id for new immobilsation
        /// </summary>
        /// <returns></returns>
        public DataTable GetIdImmo()
        {


            return data.GetData("GetIdImmo", null);

        }

    }
}
