using S.S.S.controllers;
using S.S.S.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S.S.S
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            LoginController loginController = new LoginController();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new CategoriasForms());
            //Application.Run(new TableroForm());
            //Application.Run(new LoginForm());
            //Application.Run(new MenuForm());
            //Application.Run(new AgregarProductos());
            //Application.Run(new MainForm());
            //Application.Run(new ProductosForm());

            if (!loginController.ExistenUsuarios()) {
            
                Application.Run(new PrimerUsoForm());

                if(loginController.ExistenUsuarios()== true)
                {
                    Application.Run(new LoginForm());
                }
            }
            else
            {
                Application.Run(new LoginForm());
            }

        }
    }
}