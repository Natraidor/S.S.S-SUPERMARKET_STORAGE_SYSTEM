using S.S.S.controllers;
using S.S.S.models;
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
    public partial class CrearUsuariosForm : Form
    {
        public CrearUsuariosForm()
        {
            InitializeComponent();

            if (!Sesion.EsAdmin)
            {
                MessageBox.Show("No tienes permisos para acceder aquí.", "Acceso denegado",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Load += (s, e) => this.Close();
            }
            txtPassword.UseSystemPasswordChar = true;
            txtConfirmalPassword.UseSystemPasswordChar = true;
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
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
                MessageBox.Show("La contraseña debe tener mínimo 6 caracteres.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
            {
                MessageBox.Show("Ingresa un email válido.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoginController controller = new LoginController();
            bool ok = controller.CrearUsuario(txtUsername.Text, txtPassword.Text, txtEmail.Text);

            if (ok)
            {
                MessageBox.Show($"Usuario '{txtUsername.Text}' creado correctamente.", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
        }

        private void LimpiarCampos()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirmalPassword.Clear();
            txtEmail.Clear();
            txtUsername.Focus();
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
            txtConfirmalPassword.UseSystemPasswordChar = !txtConfirmalPassword.UseSystemPasswordChar;
        }
    }
}
