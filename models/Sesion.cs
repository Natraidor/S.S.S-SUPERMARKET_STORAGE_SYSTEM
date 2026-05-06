using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S.S.S.models
{
    internal class Sesion
    {
        public static int Id { get; set; }
        public static string Username { get; set; }
        public static string Rol { get; set; } 

        public static bool EsAdmin => Rol == "admin";

        public static void Cerrar()
        {
            Id = 0;
            Username = null;
            Rol = null;
        }
    }
}
