using System;
using System.Data.SqlClient;
using System.Data;

namespace Pencil
{
    public class DB
    {

        SqlConnection con;
        string query;

        public DB(string query)//constructor with parameter
        {
            this.con = new SqlConnection("Data Source=SAMUNDRAK\\SQLEXPRESS;Initial Catalog=samundra;Integrated Security=True");
            this.query = query;


        }
        public bool ExecuteNonQuery()//insert,update,delete
        {
            try
            {
                this.con.Open();
                if (this.con.State == ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand(this.query,this.con);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return false;
        }
        public DataTable GetData()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    return ds.Tables[0];
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}
