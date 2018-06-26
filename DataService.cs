using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DBExample
{
    public class DataService: IDisposable
    {
        public void Dispose()
        {
            // this is where we would clean up
        }

        public void TestConnection()
        {
            string connectionString = ConfigurationManager.AppSettings["ConnectionString"];
            SqlConnection cn = new SqlConnection(connectionString);
            cn.Open();
            string sql = "SELECT * FROM actor";
            SqlCommand cmd = new SqlCommand(sql, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                
            }
            cn.Close();
        }

        public List<Actor> GetActors()
        {
            string connectionString = ConfigurationManager.AppSettings["ConnectionString"];
            List<Actor> result = new List<Actor>();
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                string sql = "SELECT * FROM actor";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            result.Add(new Actor()
                            {
                                Id = (int)dr["actor_id"],
                                FirstName = (string)dr["first_name"],
                                LastName = (string)dr["last_name"]
                            });
                        }
                    }
                }
                cn.Close();
            }
            return result;
        }
    }
}
