using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace S.S.S.data
{
    public class Conexion
    {
        private string cadenaConexion = "Server=DESKTOP-13D1T0N\\SQLEXPRESS04; Database=SSS; Integrated Security=True;";


        public SqlConnection AbrirConextion()
        {
            SqlConnection conectar = new SqlConnection(cadenaConexion);
            try
            {
                if (conectar.State == System.Data.ConnectionState.Closed)
                {
                    conectar.Open();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error al abrir la conexión: " + ex.Message);
            }
            return conectar;
        }


        public void CerrarConexion(SqlConnection conexionActiva)
        {
            if (conexionActiva != null && conexionActiva.State == System.Data.ConnectionState.Open)
            {
                conexionActiva.Close();
                conexionActiva.Dispose(); 
            }
        }
    }

}
