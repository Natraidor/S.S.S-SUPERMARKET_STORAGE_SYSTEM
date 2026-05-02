using System;
using System.Windows.Forms;
using System.Drawing;
using S.S.S.controllers;


namespace S.S.S
{
    public partial class VentasForm : System.Windows.Forms.Form
    {
        public VentasForm()
        {
            InitializeComponent();
            MostrarVentas();
        }

        private void MostrarVentas()
        {
            VentasController objetoController = new VentasController();

            
            dgvVentas.DataSource = objetoController.ListarVentasDetalladas();

            
            dgvVentas.Columns["Id"].HeaderText = "N° Venta";
            dgvVentas.Columns["Precio"].DefaultCellStyle.Format = "C2"; 
            dgvVentas.Columns["Total"].DefaultCellStyle.Format = "C2";
        }

        private void lbltitulo_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbltitulo_Click_1(object sender, EventArgs e)
        {

        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gtxtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvProductos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
