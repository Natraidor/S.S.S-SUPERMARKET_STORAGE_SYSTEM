using System;
using System.Data.SqlClient;
using S.S.S.data;

namespace S.S.S.models
{
    public class TableroModel : Conexion
    {
        public int ObtenerTotalProductos()
        {
            using (var connection = AbrirConextion())
            {
                string query = "SELECT COUNT(*) FROM dbo.Productos";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }

        public decimal ObtenerTotalVentas()
        {
            using (var connection = AbrirConextion())
            {
                string query = "SELECT ISNULL(SUM(total), 0) FROM dbo.Ventas";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    return Convert.ToDecimal(command.ExecuteScalar());
                }
            }
        }
    }
}