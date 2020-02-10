using RealStateManagment.DAL;
using RealStateManagment.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealStateManagment.BL
{
    class ContractNoBL
    {
        public int ColonyId { get; set; }
        public int PlotId { get; set; }

        public DataTable CountContractNo()
        {
            string spName = "SP_ContractNo";
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@ColonyId", ColonyId);
            prm[1] = new SqlParameter("@PlotId", PlotId);
            return DB.SelectTableWithSP(spName, prm);
        }

        //public DataTable ContractNo(int Colony,int Plot,int Contract)
        //{
        //    return ($);
        //}
    }
}
