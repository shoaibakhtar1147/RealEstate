using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace RealStateManagment.DAL
{
    class DB
    {
        public static DataTable SelectTableWithSP(string spName, SqlParameter[] prm)
        {
            string constring = @"Data Source=SHOAIB-PC\SQLEXPRESS;Database=RealEstate;integrated security=true";
            try
            {
                SqlConnection cn = new SqlConnection(constring);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = spName;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                if (prm != null)
                {
                    cmd.Parameters.AddRange(prm);
                }
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adt.Fill(ds);
                DataTable dt = ds.Tables[0];
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static int ExecuteNonQueryWithSP(string spName, SqlParameter[] prm)
        {
            string constring = @"Data Source=SHOAIB-PC\SQLEXPRESS;Database=RealEstate;integrated security=true";
            //SqlConnection con = new SqlConnection();
            SqlConnection cn = new SqlConnection(constring);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = spName;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                cmd.Parameters.AddRange(prm);
                cn.Open();
                int rowaffected = cmd.ExecuteNonQuery();
                cn.Close();
                return rowaffected;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}
