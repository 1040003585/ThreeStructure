using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Models;
using System.Data.SqlClient;

namespace DBHelp
{
    public static class Helper
    {
        public static bool ExecuteNonQuery(string proName, SqlParameter[] paras)
        {
          
            string conStr = "Data Source=.;Initial Catalog=hd_wast_1;Integrated Security=True";
            SqlConnection con = new SqlConnection(conStr);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = proName;
                cmd.Parameters.AddRange(paras);

                //cmd.Parameters.Add("@bm", color.Bm);
                //cmd.Parameters.Add("@mc", color.Mc);
              
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception )
            {
                con.Close();
                return false;
            }
  
        }

        public static SqlDataReader ExecuteReader(string proName, SqlParameter[] paras)
        {
         
            string conStr = "Data Source=.;Initial Catalog=hd_wast_1;Integrated Security=True";
            SqlConnection con = new SqlConnection(conStr);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = proName;
                if (paras != null) { cmd.Parameters.AddRange(paras); }

                //cmd.Parameters.Add("@bm", color.Bm);
                //cmd.Parameters.Add("@mc", color.Mc);


                SqlDataReader db = cmd.ExecuteReader();
                return db;

            }
            catch (Exception)
            {
                con.Close();
                return null;//
            }
        }

    }
}