namespace Formularios
{
    partial class FormVerCompras
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
            this.dtgvVerDetalleCompras = new System.Windows.Forms.DataGridView();
            this.dtgvVerCompras = new System.Windows.Forms.DataGridView();
            this.btnVerProductos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblListaCompras = new System.Windows.Forms.Label();
            this.lblProductos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVerDetalleCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVerCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvVerDetalleCompras
            // 
            this.dtgvVerDetalleCompras.AllowUserToAddRows = false;
            this.dtgvVerDetalleCompras.AllowUserToDeleteRows = false;
            this.dtgvVerDetalleCompras.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgvVerDetalleCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvVerDetalleCompras.Location = new System.Drawing.Point(313, 46);
            this.dtgvVerDetalleCompras.Name = "dtgvVerDetalleCompras";
            this.dtgvVerDetalleCompras.ReadOnly = true;
            this.dtgvVerDetalleCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvVerDetalleCompras.ShowEditingIcon = false;
            this.dtgvVerDetalleCompras.Size = new System.Drawing.Size(283, 196);
            this.dtgvVerDetalleCompras.TabIndex = 0;
            this.dtgvVerDetalleCompras.TabStop = false;
            this.dtgvVerDetalleCompras.VirtualMode = true;
            // 
            // dtgvVerCompras
            // 
            this.dtgvVerCompras.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dtgvVerCompras.AllowUserToAddRows = false;
            this.dtgvVerCompras.AllowUserToDeleteRows = false;
            this.dtgvVerCompras.AllowUserToResizeColumns = false;
            this.dtgvVerCompras.AllowUserToResizeRows = false;
            this.dtgvVerCompras.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgvVerCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvVerCompras.Location = new System.Drawing.Point(12, 46);
            this.dtgvVerCompras.MultiSelect = false;
            this.dtgvVerCompras.Name = "dtgvVerCompras";
            this.dtgvVerCompras.ReadOnly = true;
            this.dtgvVerCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvVerCompras.Size = new System.Drawing.Size(275, 196);
            this.dtgvVerCompras.TabIndex = 1;
            // 
            // btnVerProductos
            // 
            this.btnVerProductos.Location = new System.Drawing.Point(130, 248);
            this.btnVerProductos.Name = "btnVerProductos";
            this.btnVerProductos.Size = new System.Drawing.Size(120, 34);
            this.btnVerProductos.TabIndex = 2;
            this.btnVerProductos.TabStop = false;
            this.btnVerProductos.Text = "Ver productos";
            this.btnVerProductos.UseVisualStyleBackColor = true;
            this.btnVerProductos.Click += new System.EventHandler(this.btnVerProductos_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(361, 249);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(120, 33);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblListaCompras
            // 
            this.lblListaCompras.AutoSize = true;
            this.lblListaCompras.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaCompras.Location = new System.Drawing.Point(72, 21);
            this.lblListaCompras.Name = "lblListaCompras";
            this.lblListaCompras.Size = new System.Drawing.Size(151, 22);
            this.lblListaCompras.TabIndex = 4;
            this.lblListaCompras.Text = "Lista de Compras";
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductos.Location = new System.Drawing.Point(402, 21);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(94, 22);
            this.lblProductos.TabIndex = 5;
            this.lblProductos.Text = "Productos";
            // 
            // FormVerCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(609, 289);
            this.Controls.Add(this.lblProductos);
            this.Controls.Add(this.lblListaCompras);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnVerProductos);
            this.Controls.Add(this.dtgvVerCompras);
            this.Controls.Add(this.dtgvVerDetalleCompras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormVerCompras";
            this.Text = "FormVerCompras";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVerDetalleCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVerCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvVerDetalleCompras;
        private System.Windows.Forms.DataGridView dtgvVerCompras;
        private System.Windows.Forms.Button btnVerProductos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblListaCompras;
        private System.Windows.Forms.Label lblProductos;
    }
}