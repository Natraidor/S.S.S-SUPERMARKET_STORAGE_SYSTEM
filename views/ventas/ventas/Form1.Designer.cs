namespace ventas
{
    partial class Form1
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lbltitulo = new Label();
            lblbuscar = new Label();
            dgvProductos = new DataGridView();
            colNombre = new DataGridViewTextBoxColumn();
            colCategoria = new DataGridViewTextBoxColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            colStock = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            gtxtBuscar = new Guna.UI2.WinForms.Guna2TextBox();
            gunabtnBuscar = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // lbltitulo
            // 
            lbltitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbltitulo.AutoSize = true;
            lbltitulo.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltitulo.Location = new Point(369, 22);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(98, 38);
            lbltitulo.TabIndex = 0;
            lbltitulo.Text = "Ventas";
            lbltitulo.Click += lbltitulo_Click_1;
            // 
            // lblbuscar
            // 
            lblbuscar.AutoSize = true;
            lblbuscar.Font = new Font("Segoe UI", 10.5F);
            lblbuscar.Location = new Point(22, 83);
            lblbuscar.Name = "lblbuscar";
            lblbuscar.Size = new Size(146, 25);
            lblbuscar.TabIndex = 1;
            lblbuscar.Text = "Buscar producto:";
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProductos.BackgroundColor = SystemColors.ControlLight;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { colNombre, colCategoria, colPrecio, colStock, colEstado });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvProductos.DefaultCellStyle = dataGridViewCellStyle4;
            dgvProductos.GridColor = SystemColors.WindowText;
            dgvProductos.Location = new Point(76, 150);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.RowTemplate.Height = 30;
            dgvProductos.Size = new Size(679, 268);
            dgvProductos.TabIndex = 4;
            dgvProductos.CellContentClick += dgvProductos_CellContentClick;
            // 
            // colNombre
            // 
            colNombre.HeaderText = "Nombre";
            colNombre.MinimumWidth = 6;
            colNombre.Name = "colNombre";
            colNombre.Width = 125;
            // 
            // colCategoria
            // 
            colCategoria.HeaderText = "Categoría";
            colCategoria.MinimumWidth = 6;
            colCategoria.Name = "colCategoria";
            colCategoria.Width = 125;
            // 
            // colPrecio
            // 
            colPrecio.HeaderText = "Precio";
            colPrecio.MinimumWidth = 6;
            colPrecio.Name = "colPrecio";
            colPrecio.Width = 125;
            // 
            // colStock
            // 
            colStock.HeaderText = "Stock";
            colStock.MinimumWidth = 6;
            colStock.Name = "colStock";
            colStock.Width = 125;
            // 
            // colEstado
            // 
            colEstado.HeaderText = "Estado";
            colEstado.MinimumWidth = 6;
            colEstado.Name = "colEstado";
            colEstado.Width = 125;
            // 
            // gtxtBuscar
            // 
            gtxtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gtxtBuscar.BorderRadius = 7;
            gtxtBuscar.CustomizableEdges = customizableEdges5;
            gtxtBuscar.DefaultText = "";
            gtxtBuscar.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            gtxtBuscar.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            gtxtBuscar.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            gtxtBuscar.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            gtxtBuscar.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            gtxtBuscar.Font = new Font("Segoe UI", 10F);
            gtxtBuscar.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            gtxtBuscar.IconLeft = (Image)resources.GetObject("gtxtBuscar.IconLeft");
            gtxtBuscar.Location = new Point(174, 83);
            gtxtBuscar.Margin = new Padding(3, 5, 3, 5);
            gtxtBuscar.Name = "gtxtBuscar";
            gtxtBuscar.PlaceholderText = "";
            gtxtBuscar.SelectedText = "";
            gtxtBuscar.ShadowDecoration.CustomizableEdges = customizableEdges6;
            gtxtBuscar.Size = new Size(486, 32);
            gtxtBuscar.TabIndex = 5;
            gtxtBuscar.TextChanged += gtxtBuscar_TextChanged;
            // 
            // gunabtnBuscar
            // 
            gunabtnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            gunabtnBuscar.BorderRadius = 7;
            gunabtnBuscar.CustomizableEdges = customizableEdges7;
            gunabtnBuscar.DisabledState.BorderColor = Color.DarkGray;
            gunabtnBuscar.DisabledState.CustomBorderColor = Color.DarkGray;
            gunabtnBuscar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            gunabtnBuscar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            gunabtnBuscar.FillColor = Color.White;
            gunabtnBuscar.Font = new Font("Segoe UI", 10F);
            gunabtnBuscar.ForeColor = Color.Black;
            gunabtnBuscar.Location = new Point(666, 83);
            gunabtnBuscar.Name = "gunabtnBuscar";
            gunabtnBuscar.ShadowDecoration.CustomizableEdges = customizableEdges8;
            gunabtnBuscar.Size = new Size(119, 32);
            gunabtnBuscar.TabIndex = 6;
            gunabtnBuscar.Text = "Buscar";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(827, 526);
            Controls.Add(gunabtnBuscar);
            Controls.Add(gtxtBuscar);
            Controls.Add(dgvProductos);
            Controls.Add(lblbuscar);
            Controls.Add(lbltitulo);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltitulo;
        private Label lblbuscar;
        private DataGridView dgvProductos;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colCategoria;
        private DataGridViewTextBoxColumn colPrecio;
        private DataGridViewTextBoxColumn colStock;
        private DataGridViewTextBoxColumn colEstado;
        private Guna.UI2.WinForms.Guna2TextBox gtxtBuscar;
        private Guna.UI2.WinForms.Guna2Button gunabtnBuscar;
    }
}
