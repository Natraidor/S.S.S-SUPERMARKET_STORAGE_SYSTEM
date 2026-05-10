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
    internal class VentasController
    {
        private Conexion conexion = new Conexion();



        public List<ProductoVentaModel> ObtenerProductos()
        {
            List<ProductoVentaModel> lista = new List<ProductoVentaModel>();

            string sql = "SELECT id, nombre FROM Productos";

            SqlConnection con = conexion.AbrirConextion();

            try
            {
                SqlCommand cmd = new SqlCommand(sql, con);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new ProductoVentaModel
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        Nombre = reader["nombre"].ToString()
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conexion.CerrarConexion(con);
            }

            return lista;
        }


        public bool RegistrarVenta(int idProducto, int cantidad)
        {
            SqlConnection con = conexion.AbrirConextion();

            try
            {
                string sqlProducto = @"SELECT precio, stock 
                               FROM Productos 
                               WHERE id = @id";

                SqlCommand cmdProducto = new SqlCommand(sqlProducto, con);

                cmdProducto.Parameters.AddWithValue("@id", idProducto);

                SqlDataReader reader = cmdProducto.ExecuteReader();

                decimal precio = 0;
                int stock = 0;

                if (reader.Read())
                {
                    precio = Convert.ToDecimal(reader["precio"]);
                    stock = Convert.ToInt32(reader["stock"]);
                }

                reader.Close();

                if (cantidad > stock)
                {
                    MessageBox.Show("No hay suficiente stock");
                    return false;
                }

                decimal total = precio * cantidad;

                string sqlVenta = @"INSERT INTO Ventas(cantidad, total, id_productos)
                            VALUES(@cantidad, @total, @idProducto)";

                SqlCommand cmdVenta = new SqlCommand(sqlVenta, con);

                cmdVenta.Parameters.AddWithValue("@cantidad", cantidad);
                cmdVenta.Parameters.AddWithValue("@total", total);
                cmdVenta.Parameters.AddWithValue("@idProducto", idProducto);

                cmdVenta.ExecuteNonQuery();

                string sqlUpdate = @"UPDATE Productos
                             SET stock = stock - @cantidad
                             WHERE id = @idProducto";

                SqlCommand cmdUpdate = new SqlCommand(sqlUpdate, con);

                cmdUpdate.Parameters.AddWithValue("@cantidad", cantidad);
                cmdUpdate.Parameters.AddWithValue("@idProducto", idProducto);

                cmdUpdate.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                conexion.CerrarConexion(con);
            }
        }

        public List<VentaModel> BuscarVentas(string buscar)
        {
            List<VentaModel> lista = new List<VentaModel>();

            string sql = @"SELECT v.id,
                          p.nombre as Producto,
                          c.nombre as Categoria,
                          p.precio,
                          v.cantidad,
                          v.total
                   FROM Ventas v
                   INNER JOIN Productos p 
                        ON v.id_productos = p.id
                   INNER JOIN Categorias c 
                        ON p.id_categoria = c.id
                   WHERE p.nombre LIKE @buscar
                      OR c.nombre LIKE @buscar";

            SqlConnection con = conexion.AbrirConextion();

            try
            {
                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@buscar", "%" + buscar + "%");

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
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conexion.CerrarConexion(con);
            }

            return lista;
        }

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
                Console.WriteLine("Errord en Controller: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion(con);
            }

            return lista;
        }
    }
}
