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
            CargarProductos();
            MostrarVentas();
        }

        private void CargarProductos()
        {
            VentasController controller = new VentasController();

            cmbProductos.DataSource = controller.ObtenerProductos();

            cmbProductos.DisplayMember = "Nombre";
            cmbProductos.ValueMember = "Id";
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

        private void btnVentas_Click(object sender, EventArgs e)
        {
            VentasController controller = new VentasController();


            if (!int.TryParse(txtCantidad.Text, out int cantidad))
            {
                MessageBox.Show("Error: La cantidad debe ser un número entero sin letras.");
                txtCantidad.Focus();
                return;
            }

            int idProducto = Convert.ToInt32(cmbProductos.SelectedValue);

                bool resultado = controller.RegistrarVenta(idProducto, cantidad);

                if (resultado)
                {
                    MessageBox.Show("Venta registrada");

                    MostrarVentas();

                    txtCantidad.Clear();
                }

        }

        private void gtxtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            VentasController controller = new VentasController();

            dgvVentas.DataSource = controller.BuscarVentas(gtxtBuscar.Text);
        }

        private void gunabtnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void VentasForm_Load(object sender, EventArgs e)
        {

        }
    }
}
