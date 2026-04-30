using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using S.S.S.controllers;

namespace S.S.S.views
{
    public partial class TableroForm : Form
    {
        TableroController controlador = new TableroController();

        public TableroForm()
        {
            InitializeComponent();
        }

        private void TableroForm_Load(object sender, EventArgs e)
        {
            CargarDatosTablero();
        }

        private void CargarDatosTablero()
        {
            // 📦 Total productos
            LbTotaldeProductos.Text = controlador.MostrarTotalProductos().ToString();

            // 💰 Total ventas
            LbTotaldeVentas.Text = "$" + controlador.MostrarTotalVentas().ToString("0.00");
        }

        private void LbTotaldeVentas_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}