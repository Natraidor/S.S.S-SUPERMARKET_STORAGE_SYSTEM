using S.S.S.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace S.S.S.models
{
    public class UsuarioModel : Conexion
    {
        public bool ValidarLogin(string user, string pass) {

            using (var connection = AbrirConextion())
            {
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Usuarios WHERE username = @user AND passwordUser = @pass";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);

                    SqlDataReader reader = command.ExecuteReader();
                    return reader.HasRows;
                }
            }
        }
    }
}
