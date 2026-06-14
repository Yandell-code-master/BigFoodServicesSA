namespace AplicacionEscritorio
{
    partial class ucCrearFactura
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblCedulaCliente = new System.Windows.Forms.Label();
            this.txtCedulaCliente = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.lblTipoPago = new System.Windows.Forms.Label();
            this.cmbTipoPago = new System.Windows.Forms.ComboBox();
            this.lblCondicion = new System.Windows.Forms.Label();
            this.cmbCondicion = new System.Windows.Forms.ComboBox();
            this.lblCodigoProducto = new System.Windows.Forms.Label();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.lblSubtotalTitulo = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTotalTitulo = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCrearFactura = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCedulaCliente
            // 
            this.lblCedulaCliente.AutoSize = true;
            this.lblCedulaCliente.ForeColor = System.Drawing.Color.Transparent;
            this.lblCedulaCliente.Location = new System.Drawing.Point(20, 20);
            this.lblCedulaCliente.Name = "lblCedulaCliente";
            this.lblCedulaCliente.Size = new System.Drawing.Size(43, 13);
            this.lblCedulaCliente.TabIndex = 0;
            this.lblCedulaCliente.Text = "Cédula:";
            // 
            // txtCedulaCliente
            // 
            this.txtCedulaCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.txtCedulaCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCedulaCliente.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCedulaCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(225)))), ((int)(((byte)(208)))));
            this.txtCedulaCliente.Location = new System.Drawing.Point(90, 18);
            this.txtCedulaCliente.Name = "txtCedulaCliente";
            this.txtCedulaCliente.Size = new System.Drawing.Size(160, 27);
            this.txtCedulaCliente.TabIndex = 1;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnBuscarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarCliente.FlatAppearance.BorderSize = 0;
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBuscarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(197)))), ((int)(((byte)(171)))));
            this.btnBuscarCliente.Location = new System.Drawing.Point(260, 17);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(90, 28);
            this.btnBuscarCliente.TabIndex = 2;
            this.btnBuscarCliente.Text = "🔍  Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.ForeColor = System.Drawing.Color.Transparent;
            this.lblNombreCliente.Location = new System.Drawing.Point(370, 20);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(47, 13);
            this.lblNombreCliente.TabIndex = 3;
            this.lblNombreCliente.Text = "Nombre:";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.txtNombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreCliente.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtNombreCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(225)))), ((int)(((byte)(208)))));
            this.txtNombreCliente.Location = new System.Drawing.Point(440, 18);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(280, 27);
            this.txtNombreCliente.TabIndex = 4;
            // 
            // lblTipoPago
            // 
            this.lblTipoPago.AutoSize = true;
            this.lblTipoPago.ForeColor = System.Drawing.Color.Transparent;
            this.lblTipoPago.Location = new System.Drawing.Point(20, 60);
            this.lblTipoPago.Name = "lblTipoPago";
            this.lblTipoPago.Size = new System.Drawing.Size(59, 13);
            this.lblTipoPago.TabIndex = 5;
            this.lblTipoPago.Text = "Tipo Pago:";
            // 
            // cmbTipoPago
            // 
            this.cmbTipoPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.cmbTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipoPago.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbTipoPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(225)))), ((int)(((byte)(208)))));
            this.cmbTipoPago.Location = new System.Drawing.Point(90, 58);
            this.cmbTipoPago.Name = "cmbTipoPago";
            this.cmbTipoPago.Size = new System.Drawing.Size(160, 28);
            this.cmbTipoPago.TabIndex = 6;
            // 
            // lblCondicion
            // 
            this.lblCondicion.AutoSize = true;
            this.lblCondicion.ForeColor = System.Drawing.Color.Transparent;
            this.lblCondicion.Location = new System.Drawing.Point(270, 60);
            this.lblCondicion.Name = "lblCondicion";
            this.lblCondicion.Size = new System.Drawing.Size(57, 13);
            this.lblCondicion.TabIndex = 7;
            this.lblCondicion.Text = "Condición:";
            // 
            // cmbCondicion
            // 
            this.cmbCondicion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.cmbCondicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCondicion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCondicion.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbCondicion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(225)))), ((int)(((byte)(208)))));
            this.cmbCondicion.Location = new System.Drawing.Point(350, 58);
            this.cmbCondicion.Name = "cmbCondicion";
            this.cmbCondicion.Size = new System.Drawing.Size(160, 28);
            this.cmbCondicion.TabIndex = 8;
            // 
            // lblCodigoProducto
            // 
            this.lblCodigoProducto.AutoSize = true;
            this.lblCodigoProducto.ForeColor = System.Drawing.Color.Transparent;
            this.lblCodigoProducto.Location = new System.Drawing.Point(20, 105);
            this.lblCodigoProducto.Name = "lblCodigoProducto";
            this.lblCodigoProducto.Size = new System.Drawing.Size(43, 13);
            this.lblCodigoProducto.TabIndex = 9;
            this.lblCodigoProducto.Text = "Código:";
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.txtCodigoProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoProducto.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCodigoProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(225)))), ((int)(((byte)(208)))));
            this.txtCodigoProducto.Location = new System.Drawing.Point(90, 103);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(100, 27);
            this.txtCodigoProducto.TabIndex = 10;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.ForeColor = System.Drawing.Color.Transparent;
            this.lblCantidad.Location = new System.Drawing.Point(205, 105);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 13);
            this.lblCantidad.TabIndex = 11;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidad.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(225)))), ((int)(((byte)(208)))));
            this.txtCantidad.Location = new System.Drawing.Point(275, 103);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(80, 27);
            this.txtCantidad.TabIndex = 12;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnAgregarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarProducto.FlatAppearance.BorderSize = 0;
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAgregarProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(197)))), ((int)(((byte)(171)))));
            this.btnAgregarProducto.Location = new System.Drawing.Point(370, 101);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(120, 30);
            this.btnAgregarProducto.TabIndex = 13;
            this.btnAgregarProducto.Text = "➕ Producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dgvDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetalle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDetalle.Location = new System.Drawing.Point(20, 145);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.RowHeadersVisible = false;
            this.dgvDetalle.Size = new System.Drawing.Size(775, 128);
            this.dgvDetalle.TabIndex = 14;
            // 
            // lblSubtotalTitulo
            // 
            this.lblSubtotalTitulo.AutoSize = true;
            this.lblSubtotalTitulo.ForeColor = System.Drawing.Color.Transparent;
            this.lblSubtotalTitulo.Location = new System.Drawing.Point(20, 309);
            this.lblSubtotalTitulo.Name = "lblSubtotalTitulo";
            this.lblSubtotalTitulo.Size = new System.Drawing.Size(49, 13);
            this.lblSubtotalTitulo.TabIndex = 15;
            this.lblSubtotalTitulo.Text = "Subtotal:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.ForeColor = System.Drawing.Color.Transparent;
            this.lblSubtotal.Location = new System.Drawing.Point(75, 303);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(28, 13);
            this.lblSubtotal.TabIndex = 16;
            this.lblSubtotal.Text = "0.00";
            // 
            // lblTotalTitulo
            // 
            this.lblTotalTitulo.AutoSize = true;
            this.lblTotalTitulo.ForeColor = System.Drawing.Color.Transparent;
            this.lblTotalTitulo.Location = new System.Drawing.Point(169, 309);
            this.lblTotalTitulo.Name = "lblTotalTitulo";
            this.lblTotalTitulo.Size = new System.Drawing.Size(34, 13);
            this.lblTotalTitulo.TabIndex = 17;
            this.lblTotalTitulo.Text = "Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.Transparent;
            this.lblTotal.Location = new System.Drawing.Point(209, 303);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(37, 19);
            this.lblTotal.TabIndex = 18;
            this.lblTotal.Text = "0.00";
            // 
            // btnCrearFactura
            // 
            this.btnCrearFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btnCrearFactura.FlatAppearance.BorderSize = 0;
            this.btnCrearFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearFactura.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCrearFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.btnCrearFactura.Location = new System.Drawing.Point(405, 289);
            this.btnCrearFactura.Name = "btnCrearFactura";
            this.btnCrearFactura.Size = new System.Drawing.Size(184, 72);
            this.btnCrearFactura.TabIndex = 19;
            this.btnCrearFactura.Text = "💾 Crear Factura";
            this.btnCrearFactura.UseVisualStyleBackColor = false;
            this.btnCrearFactura.Click += new System.EventHandler(this.btnCrearFactura_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(197)))), ((int)(((byte)(171)))));
            this.btnCancelar.Location = new System.Drawing.Point(611, 289);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(184, 72);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // ucCrearFactura
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.Controls.Add(this.lblCedulaCliente);
            this.Controls.Add(this.txtCedulaCliente);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.lblTipoPago);
            this.Controls.Add(this.cmbTipoPago);
            this.Controls.Add(this.lblCondicion);
            this.Controls.Add(this.cmbCondicion);
            this.Controls.Add(this.lblCodigoProducto);
            this.Controls.Add(this.txtCodigoProducto);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.dgvDetalle);
            this.Controls.Add(this.lblSubtotalTitulo);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblTotalTitulo);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnCrearFactura);
            this.Controls.Add(this.btnCancelar);
            this.Name = "ucCrearFactura";
            this.Size = new System.Drawing.Size(1073, 639);
            this.Load += new System.EventHandler(this.ucCrearFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblCedulaCliente;
        private System.Windows.Forms.TextBox txtCedulaCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label lblTipoPago;
        private System.Windows.Forms.ComboBox cmbTipoPago;
        private System.Windows.Forms.Label lblCondicion;
        private System.Windows.Forms.ComboBox cmbCondicion;
        private System.Windows.Forms.Label lblCodigoProducto;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.Label lblSubtotalTitulo;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTotalTitulo;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCrearFactura;
        private System.Windows.Forms.Button btnCancelar;
    }
}