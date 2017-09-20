using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Conectividad
    {
        private string cadenaConexion;

        public SqlConnection conectar()
        {
            cadenaConexion = "Data Source=CPX-FECPH8SCBVV; Initial Catalog = FinalNet; Integrated Security = True";
            SqlConnection con = new SqlConnection(cadenaConexion);
            try
            {
                if (con.State.Equals(ConnectionState.Closed)) con.Open();
                else con.Close();
                {

                }

            }
            catch (Exception)
            {

                throw;
            }

            return con;
        }
    }
}
