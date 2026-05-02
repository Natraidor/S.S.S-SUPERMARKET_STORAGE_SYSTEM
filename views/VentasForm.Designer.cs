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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentasForm));
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblbuscar = new System.Windows.Forms.Label();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.gtxtBuscar = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunabtnBuscar = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(277, 14);
            this.lbltitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(77, 30);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Ventas";
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
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToDeleteRows = false;
            this.dgvVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVentas.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVentas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVentas.GridColor = System.Drawing.SystemColors.WindowText;
            this.dgvVentas.Location = new System.Drawing.Point(57, 98);
            this.dgvVentas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.RowHeadersWidth = 51;
            this.dgvVentas.RowTemplate.Height = 30;
            this.dgvVentas.Size = new System.Drawing.Size(509, 174);
            this.dgvVentas.TabIndex = 4;
            this.dgvVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick_1);
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
            this.gtxtBuscar.Size = new System.Drawing.Size(364, 21);
            this.gtxtBuscar.TabIndex = 5;
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
            this.gunabtnBuscar.Location = new System.Drawing.Point(500, 54);
            this.gunabtnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.gunabtnBuscar.Name = "gunabtnBuscar";
            this.gunabtnBuscar.Size = new System.Drawing.Size(89, 21);
            this.gunabtnBuscar.TabIndex = 6;
            this.gunabtnBuscar.Text = "Buscar";
            // 
            // VentasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(122)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(620, 342);
            this.Controls.Add(this.gunabtnBuscar);
            this.Controls.Add(this.gtxtBuscar);
            this.Controls.Add(this.dgvVentas);
            this.Controls.Add(this.lblbuscar);
            this.Controls.Add(this.lbltitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VentasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbltitulo;
        private Label lblbuscar;
        private DataGridView dgvVentas;
        private Guna.UI2.WinForms.Guna2TextBox gtxtBuscar;
        private Guna.UI2.WinForms.Guna2Button gunabtnBuscar;
    }
}
