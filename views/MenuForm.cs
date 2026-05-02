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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void AbrirFormularioEnPanel(object formularioHijo) {

            if (this.appPanel.Controls.Count > 0) {
            
                this.appPanel.Controls.RemoveAt(0);
            }

            Form fh = formularioHijo as Form;

            fh.TopLevel = false;

            fh.FormBorderStyle = FormBorderStyle.None;

            fh.Dock = DockStyle.Fill;

            this.appPanel.Controls.Add(fh);

            this.appPanel.Tag = fh;

            fh.Show();
        }

        private void btnTablero_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new TableroForm());
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new ProductosForm());
        }

        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new AgregarProductos());
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new VentasForm());
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new CategoriasForms());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
