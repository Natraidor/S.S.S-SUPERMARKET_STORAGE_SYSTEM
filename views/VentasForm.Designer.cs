using System.Windows.Forms;
using System.Drawing;
namespace S.S.S
{
    partial class VentasForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentasForm));
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblbuscar = new System.Windows.Forms.Label();
            this.gtxtBuscar = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunabtnBuscar = new Guna.UI2.WinForms.Guna2Button();
            this.cmbProductos = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnVentas = new Guna.UI2.WinForms.Guna2Button();
            this.txtCantidad = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(114, 9);
            this.lbltitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(318, 30);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Registro de salida de productos";
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblbuscar.Location = new System.Drawing.Point(16, 54);
            this.lblbuscar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(112, 19);
            this.lblbuscar.TabIndex = 1;
            this.lblbuscar.Text = "Buscar producto:";
            // 
            // gtxtBuscar
            // 
            this.gtxtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gtxtBuscar.BorderRadius = 7;
            this.gtxtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxtBuscar.DefaultText = "";
            this.gtxtBuscar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtxtBuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtxtBuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtBuscar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtBuscar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxtBuscar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gtxtBuscar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxtBuscar.IconLeft = ((System.Drawing.Image)(resources.GetObject("gtxtBuscar.IconLeft")));
            this.gtxtBuscar.Location = new System.Drawing.Point(130, 54);
            this.gtxtBuscar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gtxtBuscar.Name = "gtxtBuscar";
            this.gtxtBuscar.PlaceholderText = "";
            this.gtxtBuscar.SelectedText = "";
            this.gtxtBuscar.Size = new System.Drawing.Size(290, 21);
            this.gtxtBuscar.TabIndex = 5;
            this.gtxtBuscar.TextChanged += new System.EventHandler(this.gtxtBuscar_TextChanged_1);
            // 
            // gunabtnBuscar
            // 
            this.gunabtnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunabtnBuscar.BorderRadius = 7;
            this.gunabtnBuscar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gunabtnBuscar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gunabtnBuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gunabtnBuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gunabtnBuscar.FillColor = System.Drawing.Color.White;
            this.gunabtnBuscar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunabtnBuscar.ForeColor = System.Drawing.Color.Black;
            this.gunabtnBuscar.Location = new System.Drawing.Point(426, 54);
            this.gunabtnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.gunabtnBuscar.Name = "gunabtnBuscar";
            this.gunabtnBuscar.Size = new System.Drawing.Size(89, 21);
            this.gunabtnBuscar.TabIndex = 6;
            this.gunabtnBuscar.Text = "Buscar";
            this.gunabtnBuscar.Click += new System.EventHandler(this.gunabtnBuscar_Click);
            // 
            // cmbProductos
            // 
            this.cmbProductos.BackColor = System.Drawing.Color.Transparent;
            this.cmbProductos.BorderRadius = 10;
            this.cmbProductos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductos.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbProductos.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbProductos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbProductos.ItemHeight = 30;
            this.cmbProductos.Location = new System.Drawing.Point(20, 95);
            this.cmbProductos.Name = "cmbProductos";
            this.cmbProductos.Size = new System.Drawing.Size(164, 36);
            this.cmbProductos.TabIndex = 7;
            // 
            // btnVentas
            // 
            this.btnVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVentas.BackColor = System.Drawing.Color.Transparent;
            this.btnVentas.BorderRadius = 10;
            this.btnVentas.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVentas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVentas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVentas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVentas.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.btnVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnVentas.ForeColor = System.Drawing.Color.White;
            this.btnVentas.Location = new System.Drawing.Point(364, 95);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(151, 36);
            this.btnVentas.TabIndex = 8;
            this.btnVentas.Text = "Vender producto";
            this.btnVentas.UseTransparentBackground = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.BorderRadius = 10;
            this.txtCantidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCantidad.DefaultText = "";
            this.txtCantidad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCantidad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCantidad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCantidad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCantidad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCantidad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCantidad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCantidad.Location = new System.Drawing.Point(190, 95);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.PlaceholderText = "Cantidad a vender";
            this.txtCantidad.SelectedText = "";
            this.txtCantidad.Size = new System.Drawing.Size(168, 36);
            this.txtCantidad.TabIndex = 10;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvVentas
            // 
            this.dgvVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVentas.BackgroundColor = System.Drawing.Color.White;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Location = new System.Drawing.Point(20, 151);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.Size = new System.Drawing.Size(495, 198);
            this.dgvVentas.TabIndex = 11;
            // 
            // VentasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(122)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(546, 386);
            this.Controls.Add(this.dgvVentas);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.btnVentas);
            this.Controls.Add(this.cmbProductos);
            this.Controls.Add(this.gunabtnBuscar);
            this.Controls.Add(this.gtxtBuscar);
            this.Controls.Add(this.lblbuscar);
            this.Controls.Add(this.lbltitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VentasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.VentasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbltitulo;
        private Label lblbuscar;
        private Guna.UI2.WinForms.Guna2TextBox gtxtBuscar;
        private Guna.UI2.WinForms.Guna2Button gunabtnBuscar;
        private Guna.UI2.WinForms.Guna2ComboBox cmbProductos;
        private Guna.UI2.WinForms.Guna2Button btnVentas;
        private Guna.UI2.WinForms.Guna2TextBox txtCantidad;
        private DataGridView dgvVentas;
    }
}
