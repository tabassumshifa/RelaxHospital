using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RelaxHospital
{
    static class DataAccess
    {
        public static bool ExecuteQuery(String query)
        {
            try
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=laptop-o5jsbm3v;Initial Catalog=relax;Integrated Security=True;Encrypt=False";
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
        public static DataTable GetData(String query)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=laptop-o5jsbm3v;Initial Catalog=relax;Integrated Security=True;Encrypt=False";
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = query;///select id, full name---> 2 col data only
                
                SqlDataAdapter adp = new SqlDataAdapter(cmd);///convertion
                DataSet ds = new DataSet();///sql data set
                adp.Fill(ds);
                
                DataTable dt = ds.Tables[0];
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
