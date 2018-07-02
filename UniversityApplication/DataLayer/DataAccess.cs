using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApplication.DataLayer
{
  public class DataAccess:IDataAccess
    {
        static string connStr = "server=Grace-PC;integrated security=true;database=UBDB";
        public DataTable GetManyRowsCols(string sql, List<DbParameter> plist)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(connStr);
            try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand(sql, conn);
                foreach (SqlParameter p in plist)
                    cmd.Parameters.Add(p);
                da.SelectCommand = cmd;
                da.Fill(dt);
                
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public object GetSingleAnswer(string sql, List<DbParameter> plist)
        {
            object obj = null;
            SqlConnection conn = new SqlConnection(connStr);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                foreach (SqlParameter p in plist)
                    cmd.Parameters.Add(p);
                obj = cmd.ExecuteScalar();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return obj;
        }


        public int InsertUpdateDelete(string sql, List<DbParameter> plist)
        {
            int rows = 0;
            SqlConnection conn = new SqlConnection(connStr);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                foreach (SqlParameter p in plist)
                    cmd.Parameters.Add(p);
                rows = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return rows;
        }
    }
}
