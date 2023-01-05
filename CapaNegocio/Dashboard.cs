using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class Dashboard : Conexion
    {
        
        public struct IngresosPorFechas
        {
            //public string Date { get; set; }
            //public decimal TotalImporte { get; set; }
        }
        /*
        // Campos y propiedades
        private DateTime fechaInicio;
        private DateTime fechaFinal;
        private int numeroDias;

        public int NumClientes { get; private set; }
        public int NumProveedores { get; private set; }
        public int NumArticulos { get; private set; }
        public List<KeyValuePair<string, int>> ListaMejoresProductos{ get; private set;}
        public List<KeyValuePair<string, int>> ListaPeoresProductos { get; private set; }
        public List<IngresosPorFechas> ListaIngresoBruto { get; private set; }
        public int TotalVentas { get; private set; }
        public decimal TotalIngresos { get; private set; }
        public decimal TotalGanancias { get; private set; }
        */
        /*
        // Constructor vacio
        public Dashboard() { }
        // Metodos privados
        private void ObtenerNumeroProductos()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    // Obtenemos el numero total de clientes
                    command.CommandText = "select count(Idcliente) from Cliente";
                    NumClientes = (int)command.ExecuteScalar();
                    // Obtenemos el numero total de proveedores
                    command.CommandText = "select count(Idproveedor) from Proveedor";
                    NumProveedores = (int)command.ExecuteScalar();
                    // Obtenemos el numero total de articulos
                    command.CommandText = "select count(Idarticulo) from Articulo";
                    NumArticulos = (int)command.ExecuteScalar();
                    // Obtenemos el numero total de ventas
                    command.CommandText = "select count(Idventa) from Venta where Fecha between @primerfecha and @segundafecha";
                    command.Parameters.Add("@primerfecha", System.Data.SqlDbType.Date).Value = fechaInicio;
                    command.Parameters.Add("@segundafecha", System.Data.SqlDbType.Date).Value = fechaFinal;
                    TotalVentas = (int)command.ExecuteScalar();
                }
            }
            
        }
        private void ObtenerAnalisisVentas()
        {
            ListaIngresoBruto = new List<IngresosPorFechas>();
            TotalGanancias = 0;
            TotalIngresos = 0;

            using(var connection  = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"select Fecha, sum(Igv)
                                           from Venta
                                           where Fecha between @primerfecha and @segundafecha
                                           group by Fecha";
                    command.Parameters.Add("@primerfecha", System.Data.SqlDbType.Date).Value = fechaInicio;
                    command.Parameters.Add("@segundafecha", System.Data.SqlDbType.Date).Value = fechaFinal;
                    var lector = command.ExecuteReader();
                    var resultadoTabla = new List<KeyValuePair<DateTime, decimal>>();
                    while (lector.Read())
                    {
                        resultadoTabla.Add(new KeyValuePair<DateTime, decimal>((DateTime)lector[0],(decimal)lector[1]));
                        TotalIngresos += (decimal)lector[0];
                    }
                    TotalGanancias = TotalIngresos * 0.2m; //20%
                    lector.Close();

                    // Agrupar por horas
                    if (numeroDias <= 1)
                    {

                    }
                }
                
            }
            
        }
        */
    }
}
