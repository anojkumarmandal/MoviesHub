using System.Collections.Generic;
using System.Data.SqlClient;

namespace MoviesHub.Common
{
    public class UtilityMethods
    {
        public static bool TestConnection()
        {
            string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["moviesHubConnStr"].ConnectionString;
            try
            {
                using (var connection = new SqlConnection(connStr))
                {
                    connection.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        
    }
}
