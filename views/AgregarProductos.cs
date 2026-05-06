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
    public partial class AgregarProductos : Form
    {
        public AgregarProductos()
        {
            InitializeComponent();
            CargarComboCategorias();
        }

        private void CargarComboCategorias()
        {
            CategoriaController catController = new CategoriaController();
            DataTable categorias = catController.MostrarCategorias();

            cmbCategorias.DataSource = categorias;
            cmbCategorias.DisplayMember = "nombre";
            cmbCategorias.ValueMember = "id";
            cmbCategorias.SelectedIndex = -1;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out decimal precio))
            {
                MessageBox.Show("El precio debe ser un número válido.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtStock.Text, out int stock))
            {
                MessageBox.Show("El stock debe ser un número entero.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbCategorias.SelectedValue == null)
            {
                MessageBox.Show("Selecciona una categoría.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idCategoria = Convert.ToInt32(cmbCategorias.SelectedValue);

            ProductosController controller = new ProductosController();
            bool ok = controller.AgregarProducto(txtNombre.Text, precio, idCategoria, stock);

            if (ok)
            {
                MessageBox.Show("Producto agregado correctamente.", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombre.Text = "";
                txtPrecio.Text = "";
                txtStock.Text = "";
                cmbCategorias.SelectedIndex = -1;
            }
        }
    }
}
