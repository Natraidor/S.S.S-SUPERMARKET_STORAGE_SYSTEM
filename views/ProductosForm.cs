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
    public partial class ProductosForm : Form
    {
        private int _idSeleccionado = -1;
        public ProductosForm()
        {
            InitializeComponent();
            CargarGrillaProductos();
            CargarComboCategorias();
            ConfigurarPanelEdicion(false);
        }


        private void CargarComboCategorias()
        {
            CategoriaController catController = new CategoriaController();
            DataTable categorias = catController.MostrarCategorias();

            cmbCategoriaEdit.DataSource = categorias;
            cmbCategoriaEdit.DisplayMember = "nombre"; 
            cmbCategoriaEdit.ValueMember = "id";     
            cmbCategoriaEdit.SelectedIndex = -1;       
        }

        private void CargarGrillaProductos()
        {
            ProductosController controller = new ProductosController();

            
            dgvProductos.DataSource = controller.ListarProductos();

           
            ConfigurarColumnas();
        }

        private void ConfigurarPanelEdicion(bool visible)
        {
            panelEdicion.Visible = visible; 
        }

        private void ConfigurarColumnas()
        {

            dgvProductos.Columns["Precio"].DefaultCellStyle.Format = "C2";
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.ReadOnly = true;

        }



        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_idSeleccionado == -1)
            {
                MessageBox.Show("Selecciona un producto de la tabla primero.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "¿Estás seguro de que deseas eliminar este producto?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                ProductosController controller = new ProductosController();
                bool ok = controller.EliminarProducto(_idSeleccionado);

                if (ok)
                {
                    MessageBox.Show("Producto eliminado correctamente.",
                                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGrillaProductos();
                    ConfigurarPanelEdicion(false);
                    _idSeleccionado = -1;
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (_idSeleccionado == -1)
            {
                MessageBox.Show("Selecciona un producto de la tabla primero.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validaciones básicas
            if (string.IsNullOrWhiteSpace(txtNombreEdit.Text) ||
                string.IsNullOrWhiteSpace(txtPrecioEdit.Text))
            {
                MessageBox.Show("El nombre y el precio son obligatorios.",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtPrecioEdit.Text, out decimal precio))
            {
                MessageBox.Show("El precio debe ser un número válido.",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtStockEdit.Text, out int stock))
            {
                MessageBox.Show("El stock debe ser un número entero.",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idCategoria = Convert.ToInt32(cmbCategoriaEdit.SelectedValue);

            ProductosController controller = new ProductosController();
            bool ok = controller.ActualizarProducto(_idSeleccionado, txtNombreEdit.Text,
                                                     precio, idCategoria, stock);
            if (ok)
            {
                MessageBox.Show("Producto actualizado correctamente.",
                                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGrillaProductos();          
                ConfigurarPanelEdicion(false);    
                _idSeleccionado = -1;
            }
        }

        private void dgvProductos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = dgvProductos.Rows[e.RowIndex];

            _idSeleccionado = Convert.ToInt32(fila.Cells["Id"].Value);
            txtNombreEdit.Text = fila.Cells["Nombre"].Value.ToString();
            txtPrecioEdit.Text = fila.Cells["Precio"].Value.ToString();
            cmbCategoriaEdit.SelectedValue = Convert.ToInt32(fila.Cells["IdCategoria"].Value);
            txtStockEdit.Text = fila.Cells["Stock"].Value.ToString();

            ConfigurarPanelEdicion(true);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ConfigurarPanelEdicion(false);
            _idSeleccionado = -1;
        }
    }
}
