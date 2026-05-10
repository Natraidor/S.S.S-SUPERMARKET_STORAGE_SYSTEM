using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using S.S.S.controllers;
using S.S.S.views;


namespace S.S.S
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            txtPass.UseSystemPasswordChar = true;   
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginController loginCon = new LoginController();
            bool loginExitoso = loginCon.AccederLogin(txtUser.Text, txtPass.Text);

            if (loginExitoso)
            {
                
                //ESTO ME SIRVE PARA OTRO DIA TENGO QUE GUARDAR EL USUARIO LOGUEADO EN UNA VARIABLE GLOBAL O ALGO ASI PARA PODER USARLO EN OTROS FORMULARIOS despues lo ocupare
                string user = txtUser.Text;
                MessageBox.Show("Login exitoso. Bienvenido " + txtUser.Text);
                this.Hide();
                Menu menuForm = new Menu();
                menuForm.Show();

                //TableroForm ShowTableroForm = new TableroForm();
                //ShowTableroForm.Show();

                //Inicio inicioForm = new Inicio();
                //inicioForm.Show();

            }
            else
            {
                MessageBox.Show("Login fallido. Verifique sus credenciales.");
            }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = !txtPass.UseSystemPasswordChar;
        }
    }
}