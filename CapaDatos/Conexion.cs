using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion
    {
        public static string Cn = "Data Source=LAPTOP-8BP0N8Q5;Initial Catalog = Dbventas; Integrated Security = True";

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(Cn);
        }
    }
}
