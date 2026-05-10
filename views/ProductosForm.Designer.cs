namespace S.S.S.views
{
    partial class ProductosForm
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
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.panelEdicion = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2PictureBox();
            this.cmbCategoriaEdit = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnActualizar = new Guna.UI2.WinForms.Guna2Button();
            this.txtStockEdit = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPrecioEdit = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNombreEdit = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.panelEdicion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(275, 60);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(143, 35);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Productos";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.BorderRadius = 10;
            this.btnEliminar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEliminar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEliminar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(66, 296);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(180, 45);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseTransparentBackground = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(94, 145);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(485, 247);
            this.dgvProductos.TabIndex = 3;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick_1);
            // 
            // panelEdicion
            // 
            this.panelEdicion.BorderRadius = 10;
            this.panelEdicion.Controls.Add(this.btnCancelar);
            this.panelEdicion.Controls.Add(this.cmbCategoriaEdit);
            this.panelEdicion.Controls.Add(this.btnEliminar);
            this.panelEdicion.Controls.Add(this.btnActualizar);
            this.panelEdicion.Controls.Add(this.txtStockEdit);
            this.panelEdicion.Controls.Add(this.txtPrecioEdit);
            this.panelEdicion.Controls.Add(this.txtNombreEdit);
            this.panelEdicion.Location = new System.Drawing.Point(108, 51);
            this.panelEdicion.Name = "panelEdicion";
            this.panelEdicion.Size = new System.Drawing.Size(495, 365);
            this.panelEdicion.TabIndex = 5;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FillColor = System.Drawing.Color.Black;
            this.btnCancelar.Image = global::S.S.S.Properties.Resources.U_Turn_to_Left;
            this.btnCancelar.ImageRotate = 0F;
            this.btnCancelar.Location = new System.Drawing.Point(11, 11);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(31, 33);
            this.btnCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.UseTransparentBackground = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cmbCategoriaEdit
            // 
            this.cmbCategoriaEdit.BackColor = System.Drawing.Color.Transparent;
            this.cmbCategoriaEdit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCategoriaEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoriaEdit.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCategoriaEdit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCategoriaEdit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCategoriaEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbCategoriaEdit.ItemHeight = 30;
            this.cmbCategoriaEdit.Location = new System.Drawing.Point(66, 170);
            this.cmbCategoriaEdit.Name = "cmbCategoriaEdit";
            this.cmbCategoriaEdit.Size = new System.Drawing.Size(216, 36);
            this.cmbCategoriaEdit.TabIndex = 8;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnActualizar.BorderRadius = 10;
            this.btnActualizar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnActualizar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnActualizar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnActualizar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnActualizar.FillColor = System.Drawing.SystemColors.HotTrack;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(266, 296);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(180, 45);
            this.btnActualizar.TabIndex = 6;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseTransparentBackground = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtStockEdit
            // 
            this.txtStockEdit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStockEdit.DefaultText = "";
            this.txtStockEdit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtStockEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtStockEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStockEdit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStockEdit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStockEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtStockEdit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStockEdit.Location = new System.Drawing.Point(66, 235);
            this.txtStockEdit.Name = "txtStockEdit";
            this.txtStockEdit.PlaceholderText = "";
            this.txtStockEdit.SelectedText = "";
            this.txtStockEdit.Size = new System.Drawing.Size(97, 36);
            this.txtStockEdit.TabIndex = 3;
            // 
            // txtPrecioEdit
            // 
            this.txtPrecioEdit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecioEdit.DefaultText = "";
            this.txtPrecioEdit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrecioEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrecioEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrecioEdit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrecioEdit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrecioEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrecioEdit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrecioEdit.Location = new System.Drawing.Point(66, 118);
            this.txtPrecioEdit.Name = "txtPrecioEdit";
            this.txtPrecioEdit.PlaceholderText = "";
            this.txtPrecioEdit.SelectedText = "";
            this.txtPrecioEdit.Size = new System.Drawing.Size(380, 36);
            this.txtPrecioEdit.TabIndex = 1;
            // 
            // txtNombreEdit
            // 
            this.txtNombreEdit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreEdit.DefaultText = "";
            this.txtNombreEdit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombreEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombreEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreEdit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreEdit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombreEdit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreEdit.Location = new System.Drawing.Point(66, 61);
            this.txtNombreEdit.Name = "txtNombreEdit";
            this.txtNombreEdit.PlaceholderText = "";
            this.txtNombreEdit.SelectedText = "";
            this.txtNombreEdit.Size = new System.Drawing.Size(380, 36);
            this.txtNombreEdit.TabIndex = 0;
            // 
            // ProductosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(122)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(694, 450);
            this.Controls.Add(this.panelEdicion);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ProductosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.panelEdicion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvProductos;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelEdicion;
        private Guna.UI2.WinForms.Guna2Button btnActualizar;
        private Guna.UI2.WinForms.Guna2TextBox txtStockEdit;
        private Guna.UI2.WinForms.Guna2TextBox txtPrecioEdit;
        private Guna.UI2.WinForms.Guna2TextBox txtNombreEdit;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCategoriaEdit;
        private Guna.UI2.WinForms.Guna2PictureBox btnCancelar;
    }
}