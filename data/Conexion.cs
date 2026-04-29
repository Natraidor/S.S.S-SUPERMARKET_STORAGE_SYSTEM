using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
//Creado por nataren
//En esta parte del programa se llama cadena de conexion, esta cadena es para la base de datos, lo dejare explicado en comentarios para que entiendan
namespace S.S.S.data
{
    public class Conexion
    {
        //Se crea un private string llamado cadenaConexion, esta cadena sirve para guardar la informacion de la conexion a la base de datos.
        //en Server="" se pone el nombre del servidor que lo sacamos del SQL Server management studio, en Database="" se pone el nombre de la base de datos a la que queremos conectarnos, en este caso se llama SSS.
        private string cadenaConexion = "Server=localhost;Initial Catalog=SSS;Integrated Security=True;";
        //sqlConnection es una clase que representa una sesion unica con la base de datos 
        //y protected es un modificador de acceso que permite que la variable conectar sea accesible dentro de la clase Conexion y en las clases que hereden de Conexion, pero no desde fuera de estas clases.
        protected SqlConnection conectar = new SqlConnection();


        //En este metodo AbrirConexion buscamos que a la hora de que algo salga mal, el programa no se caiga
        public SqlConnection AbrirConextion()
        {
            try {
            
                conectar.ConnectionString = cadenaConexion;
                if (conectar.State == System.Data.ConnectionState.Closed)
                {
                    conectar.Open();
                }
            } 
            catch (Exception ex){ 
            
                Console.WriteLine("Error al abrir la conexión: " + ex.Message);
            }
            return conectar;
        }

        public void CerrarConexion()
        {
            try
            {
                if (conectar.State == System.Data.ConnectionState.Open)
                {
                    conectar.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cerrar la conexión: " + ex.Message);
            }
        }
    }

}
