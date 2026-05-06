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
using S.S.S.views;

namespace S.S.S.views
{
    public partial class CategoriasForms : Form
    {

        CategoriaController controller = new CategoriaController();
        int idSeleccionado = 0;

        public CategoriasForms()
        {
            InitializeComponent();
            CargarCategorias();
            ConfigurarPanelEdicion(false);
        }

        private bool EsTextoValido(string nombre, string descripcion)
        {
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(descripcion))
            {
                MessageBox.Show("Completa todos los campos");
                return false;
            }

            if (nombre.Any(char.IsDigit) /*|| descripcion.Any(char.IsDigit)*/)
            {
                MessageBox.Show("Los campos no pueden contener números");
                return false;
            }

            return true;
        }

        private void CargarCategorias()
        {

            try
            {
                DataTable datos = controller.MostrarCategorias();

                dgvCategorias.DataSource = datos;
                dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvCategorias.ReadOnly = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorías: " + ex.Message, "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ConfigurarPanelEdicion(bool visible)
        {
            panelEdicion.Visible = visible;
        }


        private void dgvCategorias_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;

                DataGridViewRow fila = dgvCategorias.Rows[e.RowIndex];

                idSeleccionado = Convert.ToInt32(fila.Cells["id"].Value);
                txtNombreEdit.Text = fila.Cells["nombre"].Value.ToString();
                txtDescEdit.Text = fila.Cells["descripcion"].Value.ToString();

                ConfigurarPanelEdicion(true); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void FormCategorias_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Entró al form");
            CargarCategorias();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!EsTextoValido(txtNombreCat.Text, txtDescCat.Text)) return;

            controller.AgregarCategoria(txtNombreCat.Text, txtDescCat.Text);

            txtNombreCat.Clear();
            txtDescCat.Clear();

            CargarCategorias();
        }



        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado > 0)
            {
                var confirm = MessageBox.Show("¿Seguro que deseas eliminar?", "Confirmar", MessageBoxButtons.YesNo);

                if (confirm == DialogResult.Yes)
                {
                    controller.EliminarCategoria(idSeleccionado);

                    txtNombreCat.Clear();
                    txtDescCat.Clear();
                    idSeleccionado = 0;

                    CargarCategorias();
                }
            }
            else
            {
                MessageBox.Show("Selecciona una categoría primero");
            }
        }


        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)

        {

            MessageBox.Show("Click detectado");
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvCategorias.Rows[e.RowIndex];

                idSeleccionado = Convert.ToInt32(fila.Cells["id"].Value);
                txtNombreCat.Text = fila.Cells["nombre"].Value.ToString();
                txtDescCat.Text = fila.Cells["descripcion"].Value.ToString();

                MessageBox.Show("ID seleccionado: " + idSeleccionado);


                if (dgvCategorias.Columns[e.ColumnIndex].Name == "Editar")
                {

                    MessageBox.Show("Edita los datos arriba y presiona ACTUALIZAR");
                }

                if (dgvCategorias.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    var confirm = MessageBox.Show("¿Seguro que deseas eliminar?", "Confirmar", MessageBoxButtons.YesNo);

                    if (confirm == DialogResult.Yes)
                    {
                        controller.EliminarCategoria(idSeleccionado);
                        CargarCategorias();
                    }
                }
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (idSeleccionado > 0)
            {
                if (!EsTextoValido(txtNombreCat.Text, txtDescCat.Text)) return;

                controller.EditarCategoria(idSeleccionado, txtNombreCat.Text, txtDescCat.Text);

                MessageBox.Show("Actualizado correctamente");

                txtNombreCat.Clear();
                txtDescCat.Clear();
                idSeleccionado = 0;

                CargarCategorias();
            }
            else
            {
                MessageBox.Show("Selecciona una categoría primero");
            }
        }

        private void CategoriasForms_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click_2(object sender, EventArgs e)
        {
            if (!EsTextoValido(txtNombreCat.Text, txtDescCat.Text)) return;

            controller.AgregarCategoria(txtNombreCat.Text, txtDescCat.Text);

            MessageBox.Show("Categoría agregada correctamente.", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtNombreCat.Clear();
            txtDescCat.Clear();
            CargarCategorias();
        }

        private void btnActualizar_Click_2(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Selecciona una categoría primero.", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!EsTextoValido(txtNombreEdit.Text, txtDescEdit.Text)) return;

            controller.EditarCategoria(idSeleccionado, txtNombreEdit.Text, txtDescEdit.Text);

            MessageBox.Show("Categoría actualizada correctamente.", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

            idSeleccionado = 0;
            ConfigurarPanelEdicion(false);
            CargarCategorias();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Selecciona una categoría primero.", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "¿Seguro que deseas eliminar esta categoría?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                controller.EliminarCategoria(idSeleccionado);

                MessageBox.Show("Categoría eliminada correctamente.", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                idSeleccionado = 0;
                ConfigurarPanelEdicion(false);
                CargarCategorias();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ConfigurarPanelEdicion(false);
            idSeleccionado = 0;
        }
    }
}