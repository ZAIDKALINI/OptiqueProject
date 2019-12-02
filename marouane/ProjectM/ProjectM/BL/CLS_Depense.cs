using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ProjectM.BL
{
    class CLS_Depense
    {
      
        ProjectMarouane.DAL.DataAccessLayer data = new ProjectMarouane.DAL.DataAccessLayer();
        /// <summary>
        /// for add new depense_mensuel 
        /// </summary>
        /// <param name="Id_dep">Id depense</param>
        /// <param name="Lebelle">Description </param>
        /// <param name="Date_dep">Date de depence</param>
        public void AddDep (int Id_dep,string Lebelle, DateTime Date_dep)
        {
            SqlParameter [] param = new SqlParameter[3];
            param[0] = new SqlParameter("@Id_dep", Id_dep);
            param[1] = new SqlParameter("@Lebelle", Lebelle);
            param[2] = new SqlParameter("@Date_dep", Date_dep);
            data.ExcuteCommand("AddDep", param);


        }
        /// <summary>
        /// Add Depense details price for depense specific
        /// </summary>
        /// <param name="Id_dep">id depense</param>
        /// <param name="Price">Price depense</param>
        public void AddDepDet(int Id_dep, Double Price)
        {
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@id_Dep", Id_dep);
            param[1] = new SqlParameter("@Price", Price);
            
            data.ExcuteCommand("AddDepDet", param);


        }
        /// <summary>
        /// Get all depense_Mensuelle
        /// </summary>
        /// <returns></returns>
        public DataTable GetAllDep()
        {

            return data.GetData("GetAllDep", null);

        }
        /// <summary>
        /// Get New id for new item
        /// </summary>
        /// <returns></returns>
        public DataTable GetIdDep()
        {

            return data.GetData("GetIdDep", null);

        }
    }
}
