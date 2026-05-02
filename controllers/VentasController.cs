using S.S.S.data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S.S.S.models;

namespace S.S.S.controllers
{
    internal class VentasController
    {
        private Conexion conexion = new Conexion();

        public List<VentaModel> ListarVentasDetalladas()
        {
            List<VentaModel> lista = new List<VentaModel>();

            
            string sql = @"SELECT v.id, p.nombre as Producto, c.nombre as Categoria, 
                                   p.precio, v.cantidad, v.total
                            FROM Ventas v
                            INNER JOIN Productos p ON v.id_productos = p.id
                            INNER JOIN Categorias c ON p.id_categoria = c.id";

            SqlConnection con = conexion.AbrirConextion();
            SqlCommand cmd = new SqlCommand(sql, con);

            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new VentaModel 
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        Producto = reader["Producto"].ToString(),
                        Categoria = reader["Categoria"].ToString(),
                        Precio = Convert.ToDecimal(reader["precio"]),
                        Cantidad = Convert.ToInt32(reader["cantidad"]),
                        Total = Convert.ToDecimal(reader["total"])
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en Controller: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion(con);
            }

            return lista;
        }
    }
}
