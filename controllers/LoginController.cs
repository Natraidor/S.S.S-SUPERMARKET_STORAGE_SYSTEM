using S.S.S.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S.S.S.controllers
{
    public class LoginController
    {
        UsuarioModel objetoModelo = new UsuarioModel();

        public bool AccederLogin(string user, string pass)
        {
            return objetoModelo.ValidarLogin(user, pass);
        }
    }
}
