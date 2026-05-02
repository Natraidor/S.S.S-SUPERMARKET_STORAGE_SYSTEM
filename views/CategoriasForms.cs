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
        }

        // Método auxiliar para validar campos
        private bool EsTextoValido(string nombre, string descripcion)
        {
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(descripcion))
            {
                MessageBox.Show("Completa todos los campos");
                return false;
            }

            if (nombre.Any(char.IsDigit) || descripcion.Any(char.IsDigit))
            {
                MessageBox.Show("Los campos no pueden contener números");
                return false;
            }

            return true;
        }

        // 🔄 CARGAR DATOS
        private void CargarCategorias()
        {

            try
            {
                // 1. Intentamos obtener los datos
                DataTable datos = controller.MostrarCategorias();

                if (datos == null || datos.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron datos en la base de datos.");
                }

                dgvCategorias.DataSource = datos;

                // 2. Solo si hay datos o la tabla cargó bien, configuramos las columnas
                ConfigurarColumnasBotones();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorías: " + ex.Message, "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ConfigurarColumnasBotones(){
            // Botón Editar
            if (!dgvCategorias.Columns.Contains("Editar"))
            {

                DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
                btnEditar.HeaderText = "Editar";
                btnEditar.Name = "Editar";
                btnEditar.Text = "✏️";
                btnEditar.UseColumnTextForButtonValue = true;
                dgvCategorias.Columns.Add(btnEditar);
            }

            // Botón Eliminar
            if (!dgvCategorias.Columns.Contains("Eliminar"))
            {
                DataGridViewButtonColumn btnBorrar = new DataGridViewButtonColumn();
                btnBorrar.Name = "Eliminar";
                btnBorrar.HeaderText = "Eliminar";
                btnBorrar.Text = "🗑️";
                btnBorrar.UseColumnTextForButtonValue = true;
                dgvCategorias.Columns.Add(btnBorrar);
            }
        }

        // ▶️ LOAD DEL FORM
        private void FormCategorias_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Entró al form");
            CargarCategorias();
        }

        // ➕ AGREGAR
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!EsTextoValido(txtNombreCat.Text, txtDescCat.Text)) return;

            controller.AgregarCategoria(txtNombreCat.Text, txtDescCat.Text);

            txtNombreCat.Clear();
            txtDescCat.Clear();

            CargarCategorias();
        }

        //  ACTUALIZAR
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado > 0)
            {
                if (!EsTextoValido(txtNombreCat.Text, txtDescCat.Text)) return;

                controller.EditarCategoria(idSeleccionado, txtNombreCat.Text, txtDescCat.Text);

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

                // EDITAR
                if (dgvCategorias.Columns[e.ColumnIndex].Name == "Editar")
                {

                    MessageBox.Show("Edita los datos arriba y presiona ACTUALIZAR");
                }

                // ❌ ELIMINAR
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

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (!EsTextoValido(txtNombreCat.Text, txtDescCat.Text)) return;

            controller.AgregarCategoria(txtNombreCat.Text, txtDescCat.Text);

            CargarCategorias();

        }

        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvCategorias.Rows[e.RowIndex];

                idSeleccionado = Convert.ToInt32(fila.Cells["id"].Value);
                txtNombreCat.Text = fila.Cells["nombre"].Value.ToString();
                txtDescCat.Text = fila.Cells["descripcion"].Value.ToString();



                //  EDITAR
                if (dgvCategorias.Columns[e.ColumnIndex].Name == "Editar")
                {

                    MessageBox.Show("Edita los datos arriba y presiona ACTUALIZAR");
                }

                //  ELIMINAR
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
    }
}