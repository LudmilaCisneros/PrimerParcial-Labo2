namespace Formularios
{
    partial class FormCompra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCompra));
            this.dtgvStock = new System.Windows.Forms.DataGridView();
            this.dtgvCarrito = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblCarrito = new System.Windows.Forms.Label();
            this.lblProductos = new System.Windows.Forms.Label();
            this.pictureBoxFlecha = new System.Windows.Forms.PictureBox();
            this.checkBoxSimpsons = new System.Windows.Forms.CheckBox();
            this.lblTextTotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCalcularTotal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCarrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlecha)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvStock
            // 
            this.dtgvStock.AllowDrop = true;
            this.dtgvStock.AllowUserToAddRows = false;
            this.dtgvStock.AllowUserToDeleteRows = false;
            this.dtgvStock.AllowUserToResizeColumns = false;
            this.dtgvStock.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dtgvStock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvStock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvStock.BackgroundColor = System.Drawing.Color.Maroon;
            this.dtgvStock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgvStock.Location = new System.Drawing.Point(526, 45);
            this.dtgvStock.MultiSelect = false;
            this.dtgvStock.Name = "dtgvStock";
            this.dtgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvStock.ShowEditingIcon = false;
            this.dtgvStock.Size = new System.Drawing.Size(258, 328);
            this.dtgvStock.TabIndex = 0;
            this.dtgvStock.VirtualMode = true;
            this.dtgvStock.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dtgvStock_DataBindingComplete);
            // 
            // dtgvCarrito
            // 
            this.dtgvCarrito.BackgroundColor = System.Drawing.Color.Maroon;
            this.dtgvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCarrito.Location = new System.Drawing.Point(48, 45);
            this.dtgvCarrito.Name = "dtgvCarrito";
            this.dtgvCarrito.Size = new System.Drawing.Size(260, 328);
            this.dtgvCarrito.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(385, 244);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblCarrito
            // 
            this.lblCarrito.AutoSize = true;
            this.lblCarrito.BackColor = System.Drawing.Color.Transparent;
            this.lblCarrito.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrito.Location = new System.Drawing.Point(122, 9);
            this.lblCarrito.Name = "lblCarrito";
            this.lblCarrito.Size = new System.Drawing.Size(109, 28);
            this.lblCarrito.TabIndex = 3;
            this.lblCarrito.Text = "CARRITO";
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.BackColor = System.Drawing.Color.Transparent;
            this.lblProductos.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductos.Location = new System.Drawing.Point(565, 9);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(148, 28);
            this.lblProductos.TabIndex = 4;
            this.lblProductos.Text = "PRODUCTOS";
            // 
            // pictureBoxFlecha
            // 
            this.pictureBoxFlecha.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxFlecha.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxFlecha.BackgroundImage")));
            this.pictureBoxFlecha.Location = new System.Drawing.Point(336, 125);
            this.pictureBoxFlecha.Name = "pictureBoxFlecha";
            this.pictureBoxFlecha.Size = new System.Drawing.Size(173, 113);
            this.pictureBoxFlecha.TabIndex = 5;
            this.pictureBoxFlecha.TabStop = false;
            // 
            // checkBoxSimpsons
            // 
            this.checkBoxSimpsons.AutoSize = true;
            this.checkBoxSimpsons.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxSimpsons.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSimpsons.Location = new System.Drawing.Point(48, 392);
            this.checkBoxSimpsons.Name = "checkBoxSimpsons";
            this.checkBoxSimpsons.Size = new System.Drawing.Size(143, 23);
            this.checkBoxSimpsons.TabIndex = 6;
            this.checkBoxSimpsons.Text = "Familia Simpsons";
            this.checkBoxSimpsons.UseVisualStyleBackColor = false;
            this.checkBoxSimpsons.CheckedChanged += new System.EventHandler(this.checkBoxSimpsons_CheckedChanged);
            // 
            // lblTextTotal
            // 
            this.lblTextTotal.AutoSize = true;
            this.lblTextTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTextTotal.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextTotal.Location = new System.Drawing.Point(316, 401);
            this.lblTextTotal.Name = "lblTextTotal";
            this.lblTextTotal.Size = new System.Drawing.Size(102, 31);
            this.lblTextTotal.TabIndex = 7;
            this.lblTextTotal.Text = "TOTAL:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Maroon;
            this.lblTotal.Location = new System.Drawing.Point(424, 406);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(36, 26);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "$0";
            // 
            // btnCalcularTotal
            // 
            this.btnCalcularTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularTotal.Location = new System.Drawing.Point(385, 294);
            this.btnCalcularTotal.Name = "btnCalcularTotal";
            this.btnCalcularTotal.Size = new System.Drawing.Size(75, 23);
            this.btnCalcularTotal.TabIndex = 9;
            this.btnCalcularTotal.Text = "Calcular";
            this.btnCalcularTotal.UseVisualStyleBackColor = true;
            this.btnCalcularTotal.Click += new System.EventHandler(this.btnCalcularTotal_Click);
            // 
            // FormCompra
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(880, 457);
            this.Controls.Add(this.btnCalcularTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTextTotal);
            this.Controls.Add(this.checkBoxSimpsons);
            this.Controls.Add(this.pictureBoxFlecha);
            this.Controls.Add(this.lblProductos);
            this.Controls.Add(this.lblCarrito);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dtgvCarrito);
            this.Controls.Add(this.dtgvStock);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(228, 305, 228, 305);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCompra";
            this.Load += new System.EventHandler(this.FormCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCarrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlecha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvStock;
        private System.Windows.Forms.DataGridView dtgvCarrito;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblCarrito;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.PictureBox pictureBoxFlecha;
        private System.Windows.Forms.CheckBox checkBoxSimpsons;
        private System.Windows.Forms.Label lblTextTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCalcularTotal;
    }
}