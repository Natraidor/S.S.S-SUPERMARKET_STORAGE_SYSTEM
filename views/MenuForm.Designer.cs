namespace S.S.S.views
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.appPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.btnTablero = new Guna.UI2.WinForms.Guna2Button();
            this.btnProductos = new Guna.UI2.WinForms.Guna2Button();
            this.btnAgregarProductos = new Guna.UI2.WinForms.Guna2Button();
            this.btnVentas = new Guna.UI2.WinForms.Guna2Button();
            this.btnCategorias = new Guna.UI2.WinForms.Guna2Button();
            this.btnSalir = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.menuPanel.SuspendLayout();
            this.appPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(75)))), ((int)(((byte)(160)))));
            this.menuPanel.Controls.Add(this.btnSalir);
            this.menuPanel.Controls.Add(this.btnCategorias);
            this.menuPanel.Controls.Add(this.btnVentas);
            this.menuPanel.Controls.Add(this.btnAgregarProductos);
            this.menuPanel.Controls.Add(this.btnProductos);
            this.menuPanel.Controls.Add(this.btnTablero);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(205, 547);
            this.menuPanel.TabIndex = 1;
            // 
            // appPanel
            // 
            this.appPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.appPanel.Controls.Add(this.guna2HtmlLabel3);
            this.appPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appPanel.Location = new System.Drawing.Point(205, 0);
            this.appPanel.Name = "appPanel";
            this.appPanel.Size = new System.Drawing.Size(777, 547);
            this.appPanel.TabIndex = 2;
            // 
            // btnTablero
            // 
            this.btnTablero.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTablero.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTablero.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTablero.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTablero.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTablero.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(75)))), ((int)(((byte)(160)))));
            this.btnTablero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnTablero.ForeColor = System.Drawing.Color.White;
            this.btnTablero.Location = new System.Drawing.Point(0, 0);
            this.btnTablero.Name = "btnTablero";
            this.btnTablero.Size = new System.Drawing.Size(205, 60);
            this.btnTablero.TabIndex = 1;
            this.btnTablero.Text = "Tablero";
            this.btnTablero.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTablero.Click += new System.EventHandler(this.btnTablero_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProductos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProductos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProductos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(75)))), ((int)(((byte)(160)))));
            this.btnProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnProductos.ForeColor = System.Drawing.Color.White;
            this.btnProductos.Location = new System.Drawing.Point(0, 60);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(205, 66);
            this.btnProductos.TabIndex = 2;
            this.btnProductos.Text = "Productos";
            this.btnProductos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnAgregarProductos
            // 
            this.btnAgregarProductos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarProductos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarProductos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgregarProductos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgregarProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarProductos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(75)))), ((int)(((byte)(160)))));
            this.btnAgregarProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnAgregarProductos.ForeColor = System.Drawing.Color.White;
            this.btnAgregarProductos.Location = new System.Drawing.Point(0, 126);
            this.btnAgregarProductos.Name = "btnAgregarProductos";
            this.btnAgregarProductos.Size = new System.Drawing.Size(205, 66);
            this.btnAgregarProductos.TabIndex = 3;
            this.btnAgregarProductos.Text = "Agregar Productos";
            this.btnAgregarProductos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAgregarProductos.Click += new System.EventHandler(this.btnAgregarProductos_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVentas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVentas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVentas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVentas.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(75)))), ((int)(((byte)(160)))));
            this.btnVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnVentas.ForeColor = System.Drawing.Color.White;
            this.btnVentas.Location = new System.Drawing.Point(0, 192);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(205, 66);
            this.btnVentas.TabIndex = 4;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnCategorias
            // 
            this.btnCategorias.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCategorias.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCategorias.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCategorias.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCategorias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategorias.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(75)))), ((int)(((byte)(160)))));
            this.btnCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnCategorias.ForeColor = System.Drawing.Color.White;
            this.btnCategorias.Location = new System.Drawing.Point(0, 258);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(205, 66);
            this.btnCategorias.TabIndex = 5;
            this.btnCategorias.Text = "Categorias";
            this.btnCategorias.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSalir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSalir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSalir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalir.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(75)))), ((int)(((byte)(160)))));
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(0, 481);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(205, 66);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(272, 254);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(247, 41);
            this.guna2HtmlLabel3.TabIndex = 25;
            this.guna2HtmlLabel3.Text = "¡BIENVENIDO!";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 547);
            this.Controls.Add(this.appPanel);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuPanel.ResumeLayout(false);
            this.appPanel.ResumeLayout(false);
            this.appPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel menuPanel;
        private Guna.UI2.WinForms.Guna2Panel appPanel;
        private Guna.UI2.WinForms.Guna2Button btnTablero;
        private Guna.UI2.WinForms.Guna2Button btnCategorias;
        private Guna.UI2.WinForms.Guna2Button btnVentas;
        private Guna.UI2.WinForms.Guna2Button btnAgregarProductos;
        private Guna.UI2.WinForms.Guna2Button btnProductos;
        private Guna.UI2.WinForms.Guna2Button btnSalir;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
    }
}