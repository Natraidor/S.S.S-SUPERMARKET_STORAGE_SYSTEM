namespace S.S.S.views
{
    partial class TableroForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LbTotaldeVentas = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LbTotaldeProductos = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(226, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tablero";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(14, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total de ventas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(14, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total de productos";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.LbTotaldeVentas);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(229, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 120);
            this.panel1.TabIndex = 3;
            // 
            // LbTotaldeVentas
            // 
            this.LbTotaldeVentas.AutoSize = true;
            this.LbTotaldeVentas.Font = new System.Drawing.Font("Segoe UI", 28F);
            this.LbTotaldeVentas.ForeColor = System.Drawing.Color.Black;
            this.LbTotaldeVentas.Location = new System.Drawing.Point(56, 33);
            this.LbTotaldeVentas.Name = "LbTotaldeVentas";
            this.LbTotaldeVentas.Size = new System.Drawing.Size(42, 51);
            this.LbTotaldeVentas.TabIndex = 5;
            this.LbTotaldeVentas.Text = "0";
            this.LbTotaldeVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LbTotaldeVentas.Click += new System.EventHandler(this.LbTotaldeVentas_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.LbTotaldeProductos);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(229, 180);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 120);
            this.panel2.TabIndex = 4;
            // 
            // LbTotaldeProductos
            // 
            this.LbTotaldeProductos.AutoSize = true;
            this.LbTotaldeProductos.Font = new System.Drawing.Font("Segoe UI", 28F);
            this.LbTotaldeProductos.ForeColor = System.Drawing.Color.Black;
            this.LbTotaldeProductos.Location = new System.Drawing.Point(57, 34);
            this.LbTotaldeProductos.Name = "LbTotaldeProductos";
            this.LbTotaldeProductos.Size = new System.Drawing.Size(42, 51);
            this.LbTotaldeProductos.TabIndex = 5;
            this.LbTotaldeProductos.Text = "0";
            this.LbTotaldeProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TableroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(130)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(651, 339);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "TableroForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TableroForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LbTotaldeVentas;
        private System.Windows.Forms.Label LbTotaldeProductos;
    }
}