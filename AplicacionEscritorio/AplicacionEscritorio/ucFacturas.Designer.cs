using System.Drawing;
using System.Windows.Forms;

namespace AplicacionEscritorio
{
    partial class ucFacturas
    {
        private System.ComponentModel.IContainer components = null;


    protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnNuevaFactura = new System.Windows.Forms.Button();
            this.btnAnularFactura = new System.Windows.Forms.Button();
            this.btnPagarCuenta = new System.Windows.Forms.Button();
            this.dgvFacturas = new System.Windows.Forms.DataGridView();
            this.panelDetalle = new System.Windows.Forms.Panel();
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
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            this.panelDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Controls.Add(this.txtBuscar);
            this.panelTop.Controls.Add(this.btnBuscar);
            this.panelTop.Controls.Add(this.btnNuevaFactura);
            this.panelTop.Controls.Add(this.btnAnularFactura);
            this.panelTop.Controls.Add(this.btnPagarCuenta);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(150, 50);
            this.panelTop.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(225)))), ((int)(((byte)(208)))));
            this.lblTitle.Location = new System.Drawing.Point(16, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(180, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "🧾  Facturas";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(225)))), ((int)(((byte)(208)))));
            this.txtBuscar.Location = new System.Drawing.Point(200, 12);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(180, 27);
            this.txtBuscar.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(225)))), ((int)(((byte)(208)))));
            this.btnBuscar.Location = new System.Drawing.Point(386, 11);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(36, 28);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "🔍";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnNuevaFactura
            // 
            this.btnNuevaFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btnNuevaFactura.FlatAppearance.BorderSize = 0;
            this.btnNuevaFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaFactura.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNuevaFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.btnNuevaFactura.Location = new System.Drawing.Point(440, 10);
            this.btnNuevaFactura.Name = "btnNuevaFactura";
            this.btnNuevaFactura.Size = new System.Drawing.Size(100, 30);
            this.btnNuevaFactura.TabIndex = 3;
            this.btnNuevaFactura.Text = "➕ Nueva";
            this.btnNuevaFactura.UseVisualStyleBackColor = false;
            this.btnNuevaFactura.Click += new System.EventHandler(this.btnNuevaFactura_Click);
            // 
            // btnAnularFactura
            // 
            this.btnAnularFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnAnularFactura.FlatAppearance.BorderSize = 0;
            this.btnAnularFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnularFactura.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAnularFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(225)))), ((int)(((byte)(208)))));
            this.btnAnularFactura.Location = new System.Drawing.Point(550, 10);
            this.btnAnularFactura.Name = "btnAnularFactura";
            this.btnAnularFactura.Size = new System.Drawing.Size(95, 30);
            this.btnAnularFactura.TabIndex = 4;
            this.btnAnularFactura.Text = "❌ Anular";
            this.btnAnularFactura.UseVisualStyleBackColor = false;
            this.btnAnularFactura.Click += new System.EventHandler(this.btnAnularFactura_Click);
            // 
            // btnPagarCuenta
            // 
            this.btnPagarCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnPagarCuenta.FlatAppearance.BorderSize = 0;
            this.btnPagarCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagarCuenta.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPagarCuenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(225)))), ((int)(((byte)(208)))));
            this.btnPagarCuenta.Location = new System.Drawing.Point(655, 10);
            this.btnPagarCuenta.Name = "btnPagarCuenta";
            this.btnPagarCuenta.Size = new System.Drawing.Size(95, 30);
            this.btnPagarCuenta.TabIndex = 5;
            this.btnPagarCuenta.Text = "💰 Pagar";
            this.btnPagarCuenta.UseVisualStyleBackColor = false;
            this.btnPagarCuenta.Click += new System.EventHandler(this.btnPagarCuenta_Click);
            // 
            // dgvFacturas
            // 
            this.dgvFacturas.AllowUserToAddRows = false;
            this.dgvFacturas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.dgvFacturas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFacturas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dgvFacturas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFacturas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(197)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFacturas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFacturas.ColumnHeadersHeight = 36;
            this.dgvFacturas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFacturas.EnableHeadersVisualStyles = false;
            this.dgvFacturas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.dgvFacturas.Location = new System.Drawing.Point(0, 50);
            this.dgvFacturas.MultiSelect = false;
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.ReadOnly = true;
            this.dgvFacturas.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(225)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dgvFacturas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFacturas.RowTemplate.Height = 32;
            this.dgvFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFacturas.Size = new System.Drawing.Size(150, 0);
            this.dgvFacturas.TabIndex = 0;
            // 
            // panelDetalle
            // 
            this.panelDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panelDetalle.Controls.Add(this.lblCedulaCliente);
            this.panelDetalle.Controls.Add(this.txtCedulaCliente);
            this.panelDetalle.Controls.Add(this.btnBuscarCliente);
            this.panelDetalle.Controls.Add(this.lblNombreCliente);
            this.panelDetalle.Controls.Add(this.txtNombreCliente);
            this.panelDetalle.Controls.Add(this.lblTipoPago);
            this.panelDetalle.Controls.Add(this.cmbTipoPago);
            this.panelDetalle.Controls.Add(this.lblCondicion);
            this.panelDetalle.Controls.Add(this.cmbCondicion);
            this.panelDetalle.Controls.Add(this.lblCodigoProducto);
            this.panelDetalle.Controls.Add(this.txtCodigoProducto);
            this.panelDetalle.Controls.Add(this.lblCantidad);
            this.panelDetalle.Controls.Add(this.txtCantidad);
            this.panelDetalle.Controls.Add(this.btnAgregarProducto);
            this.panelDetalle.Controls.Add(this.dgvDetalle);
            this.panelDetalle.Controls.Add(this.lblSubtotalTitulo);
            this.panelDetalle.Controls.Add(this.lblSubtotal);
            this.panelDetalle.Controls.Add(this.lblTotalTitulo);
            this.panelDetalle.Controls.Add(this.lblTotal);
            this.panelDetalle.Controls.Add(this.btnCrearFactura);
            this.panelDetalle.Controls.Add(this.btnCancelar);
            this.panelDetalle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDetalle.Location = new System.Drawing.Point(0, -190);
            this.panelDetalle.Name = "panelDetalle";
            this.panelDetalle.Padding = new System.Windows.Forms.Padding(20);
            this.panelDetalle.Size = new System.Drawing.Size(150, 340);
            this.panelDetalle.TabIndex = 1;
            this.panelDetalle.Visible = false;
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
            this.txtCedulaCliente.Location = new System.Drawing.Point(90, 18);
            this.txtCedulaCliente.Name = "txtCedulaCliente";
            this.txtCedulaCliente.Size = new System.Drawing.Size(160, 20);
            this.txtCedulaCliente.TabIndex = 1;
            this.txtCedulaCliente.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCedulaCliente.ForeColor = System.Drawing.Color.FromArgb(237, 225, 208);
            this.txtCedulaCliente.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            this.txtCedulaCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.btnBuscarCliente.Text = "🔍  Gometa";
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
            this.txtNombreCliente.Location = new System.Drawing.Point(440, 18);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(280, 20);
            this.txtNombreCliente.TabIndex = 4;
            this.txtNombreCliente.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtNombreCliente.ForeColor = System.Drawing.Color.FromArgb(237, 225, 208);
            this.txtNombreCliente.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            this.txtNombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.cmbTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoPago.Location = new System.Drawing.Point(90, 58);
            this.cmbTipoPago.Name = "cmbTipoPago";
            this.cmbTipoPago.Size = new System.Drawing.Size(160, 21);
            this.cmbTipoPago.TabIndex = 6;
            this.cmbTipoPago.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbTipoPago.ForeColor = System.Drawing.Color.FromArgb(237, 225, 208);
            this.cmbTipoPago.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            this.cmbTipoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.cmbCondicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCondicion.Location = new System.Drawing.Point(350, 58);
            this.cmbCondicion.Name = "cmbCondicion";
            this.cmbCondicion.Size = new System.Drawing.Size(160, 21);
            this.cmbCondicion.TabIndex = 8;
            this.cmbCondicion.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbCondicion.ForeColor = System.Drawing.Color.FromArgb(237, 225, 208);
            this.cmbCondicion.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            this.cmbCondicion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.txtCodigoProducto.Location = new System.Drawing.Point(90, 103);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoProducto.TabIndex = 10;
            this.txtCodigoProducto.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCodigoProducto.ForeColor = System.Drawing.Color.FromArgb(237, 225, 208);
            this.txtCodigoProducto.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            this.txtCodigoProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.txtCantidad.Location = new System.Drawing.Point(275, 103);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(80, 20);
            this.txtCantidad.TabIndex = 12;
            this.txtCantidad.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCantidad.ForeColor = System.Drawing.Color.FromArgb(237, 225, 208);
            this.txtCantidad.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(370, 101);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(120, 30);
            this.btnAgregarProducto.TabIndex = 13;
            this.btnAgregarProducto.Text = "➕ Producto";
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            this.btnAgregarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnAgregarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarProducto.FlatAppearance.BorderSize = 0;
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAgregarProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(197)))), ((int)(((byte)(171)))));
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dgvDetalle.Location = new System.Drawing.Point(20, 145);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.RowHeadersVisible = false;
            this.dgvDetalle.Size = new System.Drawing.Size(700, 110);
            this.dgvDetalle.TabIndex = 14;
            this.dgvDetalle.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetalle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetalle.ColumnHeadersHeight = 36;
            this.dgvDetalle.EnableHeadersVisualStyles = false;
            this.dgvDetalle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.dgvDetalle.MultiSelect = false;
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.RowHeadersVisible = false;
            this.dgvDetalle.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDetalle.RowTemplate.Height = 32;
            this.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            // 
            // lblSubtotalTitulo
            // 
            this.lblCodigoProducto.AutoSize = true;
            this.lblSubtotalTitulo.ForeColor = System.Drawing.Color.Transparent;
            this.lblSubtotalTitulo.Location = new System.Drawing.Point(20, 270);
            this.lblSubtotalTitulo.Name = "lblSubtotalTitulo";
            this.lblSubtotalTitulo.TabIndex = 15;
            this.lblSubtotalTitulo.Text = "Subtotal:";
            // 
            // lblSubtotal
            // 
            this.lblCodigoProducto.AutoSize = true;
            this.lblSubtotal.ForeColor = System.Drawing.Color.Transparent;
            this.lblSubtotal.Location = new System.Drawing.Point(lblSubtotalTitulo.Right, 270);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.TabIndex = 16;
            this.lblSubtotal.Text = "0.00";
            // 
            // lblTotalTitulo
            // 
            this.lblCodigoProducto.AutoSize = true;
            this.lblTotalTitulo.ForeColor = System.Drawing.Color.Transparent;
            this.lblTotalTitulo.Location = new System.Drawing.Point(lblSubtotal.Right, 270);
            this.lblTotalTitulo.Name = "lblTotalTitulo";
            this.lblTotalTitulo.TabIndex = 17;
            this.lblTotalTitulo.Text = "Total:";
            // 
            // lblTotal
            // 
            this.lblCodigoProducto.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.Transparent;
            this.lblTotal.Location = new System.Drawing.Point(lblTotalTitulo.Right, 270);
            this.lblTotal.Name = "lblTotal";
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
            this.btnCrearFactura.Location = new System.Drawing.Point(450, 265);
            this.btnCrearFactura.Name = "btnCrearFactura";
            this.btnCrearFactura.Size = new System.Drawing.Size(140, 40);
            this.btnCrearFactura.TabIndex = 19;
            this.btnCrearFactura.Text = "💾 Crear Factura";
            this.btnCrearFactura.UseVisualStyleBackColor = false;
            this.btnCrearFactura.Click += new System.EventHandler(this.btnCrearFactura_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(610, 265);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 40);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(197)))), ((int)(((byte)(171)))));
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // ucFacturas
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Controls.Add(this.dgvFacturas);
            this.Controls.Add(this.panelDetalle);
            this.Controls.Add(this.panelTop);
            this.Name = "ucFacturas";
            this.Load += new System.EventHandler(this.ucFacturas_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            this.panelDetalle.ResumeLayout(false);
            this.panelDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        private Panel panelTop;
        private Label lblTitle;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private Button btnNuevaFactura;
        private Button btnAnularFactura;
        private Button btnPagarCuenta;

        private DataGridView dgvFacturas;

        private Panel panelDetalle;

        private Label lblCedulaCliente;
        private TextBox txtCedulaCliente;
        private Button btnBuscarCliente;

        private Label lblNombreCliente;
        private TextBox txtNombreCliente;

        private Label lblTipoPago;
        private ComboBox cmbTipoPago;

        private Label lblCondicion;
        private ComboBox cmbCondicion;

        private Label lblCodigoProducto;
        private TextBox txtCodigoProducto;

        private Label lblCantidad;
        private TextBox txtCantidad;

        private Button btnAgregarProducto;

        private DataGridView dgvDetalle;

        private Label lblSubtotalTitulo;
        private Label lblSubtotal;

        private Label lblTotalTitulo;
        private Label lblTotal;

        private Button btnCrearFactura;
        private Button btnCancelar;
    }

}
