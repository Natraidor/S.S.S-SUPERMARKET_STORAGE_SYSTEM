using S.S.S.data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace S.S.S.models
{
    public class UsuarioModel : Conexion
    {
        public bool ValidarLogin(string user, string pass) {

            string hashPass = HasheoContraseña.HashSHA256(pass);

            using (var connection = AbrirConextion())
            {
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"SELECT id, username, rol 
                                           FROM Usuarios 
                                           WHERE username = @user 
                                           AND passwordUser = @pass";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", hashPass);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        Sesion.Id = Convert.ToInt32(reader["id"]);
                        Sesion.Username = reader["username"].ToString();
                        Sesion.Rol = reader["rol"].ToString();
                        return true;
                    }
                    return false;
                }
            }
        }

        public bool CrearUsuario(string username, string password, string email)
        {
            try
            {
                using (var connection = AbrirConextion())
                {
                 
                    using (var cmdCheck = new SqlCommand())
                    {
                        cmdCheck.Connection = connection;
                        cmdCheck.CommandText = "SELECT COUNT(*) FROM Usuarios WHERE username = @username";
                        cmdCheck.Parameters.AddWithValue("@username", username);
                        int existe = Convert.ToInt32(cmdCheck.ExecuteScalar());

                        if (existe > 0)
                        {
                            MessageBox.Show("Ese nombre de usuario ya existe.", "Validación",
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                    }

                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = @"INSERT INTO Usuarios (username, passwordUser, email, rol) 
                                        VALUES (@username, @password, @email, 'usuario')";
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", HasheoContraseña.HashSHA256(password));
                        command.Parameters.AddWithValue("@email", email);
                        command.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear usuario: " + ex.Message);
                return false;
            }
        }

        public bool ExistenUsuarios()
        {
            using (var connection = AbrirConextion())
            {
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT COUNT(*) FROM Usuarios";
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        public bool CrearPrimerAdmin(string username, string password, string email)
        {
            try
            {
                using (var connection = AbrirConextion())
                {
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = @"INSERT INTO Usuarios (username, passwordUser, email, rol) 
                                        VALUES (@username, @password, @email, 'admin')";
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", HasheoContraseña.HashSHA256(password));
                        command.Parameters.AddWithValue("@email", email);
                        command.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear admin: " + ex.Message);
                return false;
            }
        }
    }
}
