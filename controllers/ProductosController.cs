using S.S.S.data;
using S.S.S.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S.S.S.controllers
{
    internal class ProductosController
    {
        private Conexion conexion = new Conexion();

        public List<ProductosModel> ListarProductos()
        {
            List<ProductosModel> lista = new List<ProductosModel>();

            
            string sql = @"SELECT p.id, p.nombre, p.precio, c.nombre as categoria 
                           FROM Productos p
                           INNER JOIN Categorias c ON p.id_categoria = c.id";

            SqlConnection con = conexion.AbrirConextion();
            SqlCommand cmd = new SqlCommand(sql, con);

            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new ProductosModel
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        Nombre = reader["nombre"].ToString(),
                        Precio = Convert.ToDecimal(reader["precio"]),
                        Categoria = reader["categoria"].ToString()
                    });
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error al listar productos: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion(con);
            }

            return lista;
        }
    }
}
