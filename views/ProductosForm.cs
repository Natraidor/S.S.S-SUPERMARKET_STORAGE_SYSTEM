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
        public ProductosForm()
        {
            InitializeComponent();
            CargarGrillaProductos();
        }

        private void CargarGrillaProductos()
        {
            ProductosController controller = new ProductosController();

            
            dgvProductos.DataSource = controller.ListarProductos();

           
            ConfigurarColumnas();
        }

        private void ConfigurarColumnas()
        {
           
            dgvProductos.Columns["Id"].DefaultCellStyle.Format = "C2";
            dgvProductos.Columns["Nombre"].DefaultCellStyle.Format = "C2";
            dgvProductos.Columns["Precio"].DefaultCellStyle.Format = "C2";
            dgvProductos.Columns["Categoria"].DefaultCellStyle.Format = "C2";


            dgvProductos.Columns["Precio"].DefaultCellStyle.Format = "C2";
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
