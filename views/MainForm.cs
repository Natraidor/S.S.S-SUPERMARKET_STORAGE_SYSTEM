using S.S.S.models;
using S.S.S.views;
using System;
using System.Windows.Forms;

namespace S.S.S
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            btnCrearUsuarios.Visible = Sesion.EsAdmin;
        }

        private void AbrirFormEnPanel(Form formHijo)
        {
            if (panelContenedor.Controls.Count > 0)
                panelContenedor.Controls.RemoveAt(0);

            formHijo.TopLevel = false;
            formHijo.Dock = DockStyle.Fill;
            formHijo.FormBorderStyle = FormBorderStyle.None;

            panelContenedor.Controls.Add(formHijo);
            panelContenedor.Tag = formHijo;

            formHijo.Show();
        }

      
        private void MainForm_Load(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new TableroForm());
        }

        private void btnTablero_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new TableroForm());
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
           AbrirFormEnPanel(new ProductosForm());
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new AgregarProductos());
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
                AbrirFormEnPanel(new VentasForm());
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
                        AbrirFormEnPanel(new CategoriasForms());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de que deseas salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LoginForm login = new LoginForm();
                login.Show();
                this.Close();
            }
        }

        private void btnCrearUsuarios_Click(object sender, EventArgs e)
        {
           AbrirFormEnPanel(new CrearUsuariosForm());
        }
    }
    }
    

