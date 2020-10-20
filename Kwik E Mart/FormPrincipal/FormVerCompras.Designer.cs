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
            this.dtgvVerDetalleCompras.Location = new System.Drawing.Point(293, 109);
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
            this.dtgvVerCompras.Location = new System.Drawing.Point(12, 109);
            this.dtgvVerCompras.MultiSelect = false;
            this.dtgvVerCompras.Name = "dtgvVerCompras";
            this.dtgvVerCompras.ReadOnly = true;
            this.dtgvVerCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvVerCompras.Size = new System.Drawing.Size(275, 196);
            this.dtgvVerCompras.TabIndex = 1;
            // 
            // btnVerProductos
            // 
            this.btnVerProductos.Location = new System.Drawing.Point(149, 311);
            this.btnVerProductos.Name = "btnVerProductos";
            this.btnVerProductos.Size = new System.Drawing.Size(120, 34);
            this.btnVerProductos.TabIndex = 2;
            this.btnVerProductos.Text = "Ver productos";
            this.btnVerProductos.UseVisualStyleBackColor = true;
            this.btnVerProductos.Click += new System.EventHandler(this.btnVerProductos_Click);
            // 
            // FormVerCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(588, 450);
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

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvVerDetalleCompras;
        private System.Windows.Forms.DataGridView dtgvVerCompras;
        private System.Windows.Forms.Button btnVerProductos;
    }
}