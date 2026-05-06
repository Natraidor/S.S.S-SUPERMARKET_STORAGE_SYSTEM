using S.S.S.data;
using S.S.S.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S.S.S.controllers
{
    internal class ProductosController
    {
        private Conexion conexion = new Conexion();

        public List<ProductosModel> ListarProductos()
        {
            List<ProductosModel> lista = new List<ProductosModel>();


            string sql = @"SELECT p.id        AS Id, 
                      p.nombre    AS Nombre, 
                      p.precio    AS Precio, 
                      p.stock     AS Stock,
                      p.id_categoria AS IdCategoria,
                      c.nombre    AS Categoria 
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
                        IdCategoria = Convert.ToInt32(reader["IdCategoria"]),
                        Categoria = reader["categoria"].ToString(),
                        Stock = reader["stock"].ToString()
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

        public bool ActualizarProducto(int id, string nombre, decimal precio, int idCategoria, int stock)
        {
            try
            {
                using (SqlConnection con = conexion.AbrirConextion()) 
                {
                    string query = @"UPDATE Productos 
                     SET nombre = @nombre, 
                         precio = @precio, 
                         id_categoria = @idCategoria, 
                         stock = @stock 
                     WHERE id = @id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@precio", precio);
                    cmd.Parameters.AddWithValue("@idCategoria", idCategoria);
                    cmd.Parameters.AddWithValue("@stock", stock);
                    int filas = cmd.ExecuteNonQuery();
                    return filas > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
                return false;
            }
        }

        public bool EliminarProducto(int id)
        {
            try
            {
                using (SqlConnection con = conexion.AbrirConextion()) 
                {
                    string query = "DELETE FROM Productos WHERE id = @id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", id);
                    int filas = cmd.ExecuteNonQuery();
                    return filas > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
                return false;
            }
        }

        public bool AgregarProducto(string nombre, decimal precio, int idCategoria, int stock)
        {
            try
            {
                using (SqlConnection con = conexion.AbrirConextion())
                {
                    string query = @"INSERT INTO Productos (nombre, precio, id_categoria, stock) 
                             VALUES (@nombre, @precio, @idCategoria, @stock)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@precio", precio);
                    cmd.Parameters.AddWithValue("@idCategoria", idCategoria);
                    cmd.Parameters.AddWithValue("@stock", stock);
                    int filas = cmd.ExecuteNonQuery();
                    return filas > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar: " + ex.Message);
                return false;
            }
        }
    }
}
