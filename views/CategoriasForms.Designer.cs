namespace S.S.S.views
{
    partial class CategoriasForms
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
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2ShadowPanel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.txtDescCat = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNombreCat = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2ShadowPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.FillColor = System.Drawing.SystemColors.HotTrack;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(-17, 1);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowDepth = 0;
            this.guna2ShadowPanel1.ShadowShift = 0;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(377, 561);
            this.guna2ShadowPanel1.TabIndex = 23;
            // 
            // guna2ShadowPanel2
            // 
            this.guna2ShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel2.Controls.Add(this.label3);
            this.guna2ShadowPanel2.Controls.Add(this.label2);
            this.guna2ShadowPanel2.Controls.Add(this.label1);
            this.guna2ShadowPanel2.Controls.Add(this.btnActualizar);
            this.guna2ShadowPanel2.Controls.Add(this.btnAgregar);
            this.guna2ShadowPanel2.Controls.Add(this.dgvCategorias);
            this.guna2ShadowPanel2.Controls.Add(this.txtDescCat);
            this.guna2ShadowPanel2.Controls.Add(this.txtNombreCat);
            this.guna2ShadowPanel2.Controls.Add(this.guna2HtmlLabel3);
            this.guna2ShadowPanel2.FillColor = System.Drawing.Color.RoyalBlue;
            this.guna2ShadowPanel2.Location = new System.Drawing.Point(356, 1);
            this.guna2ShadowPanel2.Name = "guna2ShadowPanel2";
            this.guna2ShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel2.ShadowDepth = 0;
            this.guna2ShadowPanel2.ShadowShift = 0;
            this.guna2ShadowPanel2.Size = new System.Drawing.Size(711, 561);
            this.guna2ShadowPanel2.TabIndex = 24;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnActualizar.Location = new System.Drawing.Point(558, 263);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(141, 43);
            this.btnActualizar.TabIndex = 29;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnAgregar.Location = new System.Drawing.Point(391, 263);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(150, 43);
            this.btnAgregar.TabIndex = 28;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Location = new System.Drawing.Point(27, 355);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.RowHeadersWidth = 51;
            this.dgvCategorias.RowTemplate.Height = 24;
            this.dgvCategorias.Size = new System.Drawing.Size(672, 169);
            this.dgvCategorias.TabIndex = 27;
            this.dgvCategorias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategorias_CellContentClick);
            // 
            // txtDescCat
            // 
            this.txtDescCat.BorderColor = System.Drawing.Color.Black;
            this.txtDescCat.BorderRadius = 10;
            this.txtDescCat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescCat.DefaultText = "";
            this.txtDescCat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDescCat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDescCat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescCat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescCat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDescCat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescCat.Location = new System.Drawing.Point(391, 152);
            this.txtDescCat.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtDescCat.Name = "txtDescCat";
            this.txtDescCat.PlaceholderText = "";
            this.txtDescCat.SelectedText = "";
            this.txtDescCat.Size = new System.Drawing.Size(286, 49);
            this.txtDescCat.TabIndex = 26;
            // 
            // txtNombreCat
            // 
            this.txtNombreCat.BorderColor = System.Drawing.Color.Black;
            this.txtNombreCat.BorderRadius = 10;
            this.txtNombreCat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreCat.DefaultText = "";
            this.txtNombreCat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombreCat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombreCat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreCat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreCat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNombreCat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreCat.Location = new System.Drawing.Point(54, 152);
            this.txtNombreCat.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtNombreCat.Name = "txtNombreCat";
            this.txtNombreCat.PlaceholderText = "";
            this.txtNombreCat.SelectedText = "";
            this.txtNombreCat.Size = new System.Drawing.Size(286, 49);
            this.txtNombreCat.TabIndex = 25;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(391, 111);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(131, 31);
            this.guna2HtmlLabel3.TabIndex = 24;
            this.guna2HtmlLabel3.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(266, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 39);
            this.label1.TabIndex = 30;
            this.label1.Text = "Categorias";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(49, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 29);
            this.label2.TabIndex = 31;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(386, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 29);
            this.label3.TabIndex = 32;
            this.label3.Text = "Descripcion";
            // 
            // CategoriasForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.guna2ShadowPanel2);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Name = "CategoriasForms";
            this.Text = "Categorias";
            this.guna2ShadowPanel2.ResumeLayout(false);
            this.guna2ShadowPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private Guna.UI2.WinForms.Guna2TextBox txtDescCat;
        private Guna.UI2.WinForms.Guna2TextBox txtNombreCat;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}