using AguaFiel_App_v1;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class Conexion
    {
        private string connectionString = "Data Source=DANIEL\\SQLEXPRESS;Initial Catalog=RRHHAguaFiel;Integrated Security=True;";

        public DataTable ObtenerCargos()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT idCargoLogin, nombreCargo FROM CargosLogin";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public (string nombreCargo, string password) ObtenerCredenciales(int idCargoLogin)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT nombreCargo, password FROM CargosLogin WHERE idCargoLogin = @idCargoLogin";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@idCargoLogin", idCargoLogin);
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string nombreCargo = reader["nombreCargo"].ToString();
                            string password = reader["password"].ToString();
                            return (nombreCargo, password);
                        }
                        else
                        {
                            return (null, null);
                        }
                    }
                }
            }
        }

        public decimal ObtenerSueldo(int idCargoLogin)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT sueldo FROM CargosLogin WHERE idCargoLogin = @idCargoLogin";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@idCargoLogin", idCargoLogin);
                    con.Open();
                    object sueldo = cmd.ExecuteScalar();
                    return sueldo != null ? Convert.ToDecimal(sueldo) : 0;
                }
            }
        }
    }
}
