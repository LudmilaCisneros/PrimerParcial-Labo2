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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btnHacerCompra = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxNombreCte = new System.Windows.Forms.TextBox();
            this.lblNombreCte = new System.Windows.Forms.Label();
            this.cboxMedioDePago = new System.Windows.Forms.ComboBox();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dtgvStock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvStock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvStock.BackgroundColor = System.Drawing.Color.LightGray;
            this.dtgvStock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvStock.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvStock.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtgvStock.Location = new System.Drawing.Point(548, 40);
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
            this.dtgvCarrito.BackgroundColor = System.Drawing.Color.LightGray;
            this.dtgvCarrito.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvCarrito.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvCarrito.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtgvCarrito.Location = new System.Drawing.Point(28, 40);
            this.dtgvCarrito.Name = "dtgvCarrito";
            this.dtgvCarrito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvCarrito.Size = new System.Drawing.Size(260, 328);
            this.dtgvCarrito.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(385, 216);
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
            this.pictureBoxFlecha.Location = new System.Drawing.Point(334, 88);
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
            this.checkBoxSimpsons.Location = new System.Drawing.Point(361, 315);
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
            this.lblTextTotal.Location = new System.Drawing.Point(328, 353);
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
            this.lblTotal.Location = new System.Drawing.Point(436, 358);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(36, 26);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "$0";
            // 
            // btnCalcularTotal
            // 
            this.btnCalcularTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularTotal.Location = new System.Drawing.Point(384, 264);
            this.btnCalcularTotal.Name = "btnCalcularTotal";
            this.btnCalcularTotal.Size = new System.Drawing.Size(75, 23);
            this.btnCalcularTotal.TabIndex = 9;
            this.btnCalcularTotal.Text = "Calcular";
            this.btnCalcularTotal.UseVisualStyleBackColor = true;
            this.btnCalcularTotal.Click += new System.EventHandler(this.btnCalcularTotal_Click);
            // 
            // btnHacerCompra
            // 
            this.btnHacerCompra.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHacerCompra.Location = new System.Drawing.Point(441, 422);
            this.btnHacerCompra.Name = "btnHacerCompra";
            this.btnHacerCompra.Size = new System.Drawing.Size(75, 23);
            this.btnHacerCompra.TabIndex = 10;
            this.btnHacerCompra.Text = "Finalizar";
            this.btnHacerCompra.UseVisualStyleBackColor = true;
            this.btnHacerCompra.Click += new System.EventHandler(this.btnHacerCompra_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.Location = new System.Drawing.Point(28, 374);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(75, 23);
            this.btnQuitar.TabIndex = 11;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(307, 422);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.Red;
            this.lblUser.Location = new System.Drawing.Point(356, 28);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(116, 28);
            this.lblUser.TabIndex = 13;
            this.lblUser.Text = "Vendedor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(367, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Vendedor: ";
            // 
            // txtBoxNombreCte
            // 
            this.txtBoxNombreCte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNombreCte.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtBoxNombreCte.Location = new System.Drawing.Point(55, 422);
            this.txtBoxNombreCte.Name = "txtBoxNombreCte";
            this.txtBoxNombreCte.Size = new System.Drawing.Size(219, 20);
            this.txtBoxNombreCte.TabIndex = 15;
            // 
            // lblNombreCte
            // 
            this.lblNombreCte.AutoSize = true;
            this.lblNombreCte.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreCte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCte.Location = new System.Drawing.Point(52, 406);
            this.lblNombreCte.Name = "lblNombreCte";
            this.lblNombreCte.Size = new System.Drawing.Size(183, 13);
            this.lblNombreCte.TabIndex = 16;
            this.lblNombreCte.Text = "INGRESE NOMBRE CLIENTE: ";
            // 
            // cboxMedioDePago
            // 
            this.cboxMedioDePago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxMedioDePago.FormattingEnabled = true;
            this.cboxMedioDePago.Location = new System.Drawing.Point(625, 389);
            this.cboxMedioDePago.Name = "cboxMedioDePago";
            this.cboxMedioDePago.Size = new System.Drawing.Size(121, 21);
            this.cboxMedioDePago.TabIndex = 17;
            this.cboxMedioDePago.Text = "Medio de pago";
            // 
            // FormCompra
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(880, 457);
            this.Controls.Add(this.cboxMedioDePago);
            this.Controls.Add(this.lblNombreCte);
            this.Controls.Add(this.txtBoxNombreCte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnHacerCompra);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
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
        private System.Windows.Forms.Button btnHacerCompra;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxNombreCte;
        private System.Windows.Forms.Label lblNombreCte;
        private System.Windows.Forms.ComboBox cboxMedioDePago;
    }
}