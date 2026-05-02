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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new CategoriasForms());
            //Application.Run(new TableroForm());
            Application.Run(new LoginForm());
            //Application.Run(new MenuForm());
            //Application.Run(new AgregarProductos());
            //Application.Run(new MainForm());

        }
    }
}