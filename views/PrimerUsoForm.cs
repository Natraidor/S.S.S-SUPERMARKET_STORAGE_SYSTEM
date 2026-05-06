using S.S.S.controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S.S.S.views
{
    public partial class PrimerUsoForm : Form
    {
        public PrimerUsoForm()
        {
            InitializeComponent();
            MessageBox.Show("Bienvenido a S.S.S., tal parece no existe usuario creado en el sistema, profavor cree un usuario para ingresar.");
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||string.IsNullOrWhiteSpace(txtPassword.Text) ||string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Completa todos los campos.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtPassword.Text != txtConfirmalPassword.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtPassword.Text.Length < 6)
            {
                MessageBox.Show("La contraseña debe tener al menos 6 caracteres.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoginController controller = new LoginController();
            bool ok = controller.CrearPrimerAdmin(txtUsername.Text, txtPassword.Text, txtEmail.Text);

            if (ok)
            {
                MessageBox.Show("¡Administrador creado correctamente!\nAhora puedes iniciar sesión.",
                                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoginForm login = new LoginForm();
                login.Show();
                this.Close();
            }
        }
    }
    
}
