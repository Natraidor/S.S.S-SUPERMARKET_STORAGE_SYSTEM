using S.S.S.data;
using System;
using System.Data;
using System.Data.SqlClient;

namespace S.S.S.models
{
    public class CategoriasModel : Conexion
    {
        // 🔍 Obtener todas las categorías
        public DataTable ObtenerCategorias()
        {
            DataTable tabla = new DataTable();
            try
            {
                using (var connection = AbrirConextion())
                {
                    string query = "SELECT * FROM Categorias";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        adapter.Fill(tabla);
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error de base de datos: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general: " + ex.Message);
            }

            return tabla;
        }

        // ➕ Insertar categoría
        public void InsertarCategoria(string nombre, string descripcion)
        {
            using (var connection = AbrirConextion())
            {
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO Categorias (nombre, descripcion) VALUES (@nombre, @descripcion)";
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@descripcion", descripcion);

                    command.ExecuteNonQuery();
                }
            }
        }

        // ✏️ Actualizar categoría
        public void ActualizarCategoria(int id, string nombre, string descripcion)
        {
            using (var connection = AbrirConextion())
            {
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE Categorias SET nombre=@nombre, descripcion=@descripcion WHERE id=@id";
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@descripcion", descripcion);

                    command.ExecuteNonQuery();
                }
            }
        }

        // ❌ Eliminar categoría
        public void EliminarCategoria(int id)
        {
            using (var connection = AbrirConextion())
            {
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "DELETE FROM Categorias WHERE id=@id";
                    command.Parameters.AddWithValue("@id", id);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}