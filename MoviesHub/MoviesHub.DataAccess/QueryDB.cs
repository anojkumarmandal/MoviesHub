using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesHub.DataAccess
{
    public class QueryDB
    {
        private string connStr;
        private DataTable resultAdapter;
        private int resultNonQuery;

        public QueryDB(string connStr)
        {
            this.connStr = connStr;
        }

        public DataTable ExecuteAdapter(string query)
        {
            try
            {
                using (var connection = new SqlConnection(connStr))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            resultAdapter = new DataTable();
                            adapter.Fill(resultAdapter);
                        }
                    }
                }
            }
            catch(Exception ex)
            {

            }
            return resultAdapter;
        }

        public int ExecuteNonQuery(string query)
        {
            try
            {
                using (var connection = new SqlConnection(connStr))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch(Exception ex)
            {

            }
            return resultNonQuery;
        }
    }
}
