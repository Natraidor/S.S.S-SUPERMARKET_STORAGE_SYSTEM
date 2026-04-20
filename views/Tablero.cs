using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Windows.Forms;

namespace S.S.S.views
{
    public partial class Tablero : Form
    {
        public Tablero()
        {
            InitializeComponent();
        }

        private void Tablero_Load(object sender, EventArgs e)
        {
            lblTotalProductos.Text = "0";
            lblTotalVentas.Text = "0";
        }

        public void ActualizarTablero(int totalProductos, int totalVentas)
        {
            lblTotalProductos.Text = totalProductos.ToString();
            lblTotalVentas.Text = totalVentas.ToString();
        }

        private void btnTablero_Click(object sender, EventArgs e)
        {
            // Si ya estás en el tablero, este botón no necesita hacer nada por ahora
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aquí irá la vista de Productos");
        }

        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aquí irá la vista de Agregar Productos");
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aquí irá la vista de Ventas");
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aquí irá la vista de Categorías");
        }
    }
}