using System.Drawing;
using System.Windows.Forms;

namespace AplicacionEscritorio
{
    partial class ucMenu
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

            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();

            this.dgvProductos = new System.Windows.Forms.DataGridView();

            this.panelDetalle = new System.Windows.Forms.Panel();

            this.lblCodigoBarra = new System.Windows.Forms.Label();
            this.txtCodigoBarra = new System.Windows.Forms.TextBox();

            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();

            this.lblPrecioVenta = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();

            this.lblDescuento = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();

            this.lblImpuesto = new System.Windows.Forms.Label();
            this.txtImpuesto = new System.Windows.Forms.TextBox();

            this.lblUnidadMedida = new System.Windows.Forms.Label();
            this.txtUnidadMedida = new System.Windows.Forms.TextBox();

            this.lblPrecioCompra = new System.Windows.Forms.Label();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();

            this.lblExistencia = new System.Windows.Forms.Label();
            this.txtExistencia = new System.Windows.Forms.TextBox();

            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();

            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.panelDetalle.SuspendLayout();
            this.SuspendLayout();

            // panelTop

            this.panelTop.BackColor = Color.FromArgb(26, 26, 26);
            this.panelTop.Dock = DockStyle.Top;
            this.panelTop.Size = new Size(150, 50);

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Text = "🍔 Productos";
            this.lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.FromArgb(237, 225, 208);
            this.lblTitle.Location = new Point(16, 10);
            this.lblTitle.Size = new Size(220, 30);

            // txtBuscar

            this.txtBuscar.Location = new Point(200, 12);
            this.txtBuscar.Size = new Size(180, 27);

            this.txtBuscar.Font = new Font("Segoe UI", 11F);
            this.txtBuscar.ForeColor = Color.FromArgb(237, 225, 208);
            this.txtBuscar.BackColor = Color.FromArgb(18, 18, 18);
            this.txtBuscar.BorderStyle = BorderStyle.FixedSingle;

            // btnBuscar

            this.btnBuscar.Text = "🔍";
            this.btnBuscar.Location = new Point(386, 11);
            this.btnBuscar.Size = new Size(36, 28);

            this.btnBuscar.BackColor = Color.FromArgb(42, 42, 42);
            this.btnBuscar.ForeColor = Color.FromArgb(237, 225, 208);
            this.btnBuscar.FlatStyle = FlatStyle.Flat;
            this.btnBuscar.FlatAppearance.BorderSize = 0;

            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);

            // btnNuevo

            this.btnNuevo.Text = "➕ Nuevo";

            this.btnNuevo.Location = new Point(440, 10);
            this.btnNuevo.Size = new Size(100, 30);

            this.btnNuevo.BackColor = Color.FromArgb(255, 191, 0);
            this.btnNuevo.ForeColor = Color.FromArgb(109, 80, 0);

            this.btnNuevo.FlatStyle = FlatStyle.Flat;
            this.btnNuevo.FlatAppearance.BorderSize = 0;

            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);

            // btnEditar

            this.btnEditar.Text = "✏ Editar";

            this.btnEditar.Location = new Point(550, 10);
            this.btnEditar.Size = new Size(90, 30);

            this.btnEditar.BackColor = Color.FromArgb(42, 42, 42);
            this.btnEditar.ForeColor = Color.FromArgb(237, 225, 208);

            this.btnEditar.FlatStyle = FlatStyle.Flat;
            this.btnEditar.FlatAppearance.BorderSize = 0;

            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);

            // btnEliminar

            this.btnEliminar.Text = "🗑 Eliminar";

            this.btnEliminar.Location = new Point(650, 10);
            this.btnEliminar.Size = new Size(100, 30);

            this.btnEliminar.BackColor = Color.FromArgb(42, 42, 42);
            this.btnEliminar.ForeColor = Color.FromArgb(237, 225, 208);

            this.btnEliminar.FlatStyle = FlatStyle.Flat;
            this.btnEliminar.FlatAppearance.BorderSize = 0;

            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);

            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Controls.Add(this.txtBuscar);
            this.panelTop.Controls.Add(this.btnBuscar);
            this.panelTop.Controls.Add(this.btnNuevo);
            this.panelTop.Controls.Add(this.btnEditar);
            this.panelTop.Controls.Add(this.btnEliminar);

            // dgvProductos

            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;

            dataGridViewCellStyle1.BackColor =
                Color.FromArgb(24, 24, 24);

            this.dgvProductos.AlternatingRowsDefaultCellStyle =
                dataGridViewCellStyle1;

            this.dgvProductos.BackgroundColor =
                Color.FromArgb(18, 18, 18);

            this.dgvProductos.BorderStyle = BorderStyle.None;

            this.dgvProductos.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.None;

            dataGridViewCellStyle2.Alignment =
                DataGridViewContentAlignment.MiddleLeft;

            dataGridViewCellStyle2.BackColor =
                Color.FromArgb(26, 26, 26);

            dataGridViewCellStyle2.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);

            dataGridViewCellStyle2.ForeColor =
                Color.FromArgb(212, 197, 171);

            this.dgvProductos.ColumnHeadersDefaultCellStyle =
                dataGridViewCellStyle2;

            this.dgvProductos.ColumnHeadersHeight = 36;

            this.dgvProductos.Dock = DockStyle.Fill;

            this.dgvProductos.EnableHeadersVisualStyles = false;

            this.dgvProductos.GridColor =
                Color.FromArgb(42, 42, 42);

            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.ReadOnly = true;

            this.dgvProductos.RowHeadersVisible = false;

            dataGridViewCellStyle3.BackColor =
                Color.FromArgb(18, 18, 18);

            dataGridViewCellStyle3.ForeColor =
                Color.FromArgb(237, 225, 208);

            dataGridViewCellStyle3.SelectionBackColor =
                Color.FromArgb(255, 191, 0);

            dataGridViewCellStyle3.SelectionForeColor =
                Color.FromArgb(18, 18, 18);

            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;

            this.dgvProductos.RowsDefaultCellStyle =
                dataGridViewCellStyle3;

            this.dgvProductos.RowTemplate.Height = 32;

            this.dgvProductos.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            // panelDetalle

            this.panelDetalle.BackColor =
                Color.FromArgb(26, 26, 26);

            this.panelDetalle.Dock = DockStyle.Bottom;

            this.panelDetalle.Height = 320;

            this.panelDetalle.Padding =
                new Padding(20);

            this.panelDetalle.Visible = false;

        // lblCodigoBarra

        this.lblCodigoBarra.AutoSize = true;
            this.lblCodigoBarra.ForeColor = Color.FromArgb(212, 197, 171);
            this.lblCodigoBarra.Location = new Point(20, 20);
            this.lblCodigoBarra.Text = "Código Barra:";

            // txtCodigoBarra

            this.txtCodigoBarra.Location = new Point(120, 16);
            this.txtCodigoBarra.Size = new Size(180, 27);
            this.txtCodigoBarra.Font = new Font("Segoe UI", 11F);
            this.txtCodigoBarra.ForeColor = Color.FromArgb(237, 225, 208);
            this.txtCodigoBarra.BackColor = Color.FromArgb(18, 18, 18);
            this.txtCodigoBarra.BorderStyle = BorderStyle.FixedSingle;

            // lblDescripcion

            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.ForeColor = Color.FromArgb(212, 197, 171);
            this.lblDescripcion.Location = new Point(320, 20);
            this.lblDescripcion.Text = "Descripción:";

            // txtDescripcion

            this.txtDescripcion.Location = new Point(410, 16);
            this.txtDescripcion.Size = new Size(280, 27);
            this.txtDescripcion.Font = new Font("Segoe UI", 11F);
            this.txtDescripcion.ForeColor = Color.FromArgb(237, 225, 208);
            this.txtDescripcion.BackColor = Color.FromArgb(18, 18, 18);
            this.txtDescripcion.BorderStyle = BorderStyle.FixedSingle;

            // lblPrecioVenta

            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.ForeColor = Color.FromArgb(212, 197, 171);
            this.lblPrecioVenta.Location = new Point(20, 70);
            this.lblPrecioVenta.Text = "Precio Venta:";

            // txtPrecioVenta

            this.txtPrecioVenta.Location = new Point(120, 66);
            this.txtPrecioVenta.Size = new Size(100, 27);
            this.txtPrecioVenta.Font = new Font("Segoe UI", 11F);
            this.txtPrecioVenta.ForeColor = Color.FromArgb(237, 225, 208);
            this.txtPrecioVenta.BackColor = Color.FromArgb(18, 18, 18);
            this.txtPrecioVenta.BorderStyle = BorderStyle.FixedSingle;

            // lblDescuento

            this.lblDescuento.AutoSize = true;
            this.lblDescuento.ForeColor = Color.FromArgb(212, 197, 171);
            this.lblDescuento.Location = new Point(250, 70);
            this.lblDescuento.Text = "Descuento:";

            // txtDescuento

            this.txtDescuento.Location = new Point(330, 66);
            this.txtDescuento.Size = new Size(100, 27);
            this.txtDescuento.Font = new Font("Segoe UI", 11F);
            this.txtDescuento.ForeColor = Color.FromArgb(237, 225, 208);
            this.txtDescuento.BackColor = Color.FromArgb(18, 18, 18);
            this.txtDescuento.BorderStyle = BorderStyle.FixedSingle;

            // lblImpuesto

            this.lblImpuesto.AutoSize = true;
            this.lblImpuesto.ForeColor = Color.FromArgb(212, 197, 171);
            this.lblImpuesto.Location = new Point(460, 70);
            this.lblImpuesto.Text = "Impuesto:";

            // txtImpuesto

            this.txtImpuesto.Location = new Point(530, 66);
            this.txtImpuesto.Size = new Size(100, 27);
            this.txtImpuesto.Font = new Font("Segoe UI", 11F);
            this.txtImpuesto.ForeColor = Color.FromArgb(237, 225, 208);
            this.txtImpuesto.BackColor = Color.FromArgb(18, 18, 18);
            this.txtImpuesto.BorderStyle = BorderStyle.FixedSingle;

            // lblUnidadMedida

            this.lblUnidadMedida.AutoSize = true;
            this.lblUnidadMedida.ForeColor = Color.FromArgb(212, 197, 171);
            this.lblUnidadMedida.Location = new Point(20, 120);
            this.lblUnidadMedida.Text = "Unidad:";

            // txtUnidadMedida

            this.txtUnidadMedida.Location = new Point(120, 116);
            this.txtUnidadMedida.Size = new Size(120, 27);
            this.txtUnidadMedida.Font = new Font("Segoe UI", 11F);
            this.txtUnidadMedida.ForeColor = Color.FromArgb(237, 225, 208);
            this.txtUnidadMedida.BackColor = Color.FromArgb(18, 18, 18);
            this.txtUnidadMedida.BorderStyle = BorderStyle.FixedSingle;

            // lblPrecioCompra

            this.lblPrecioCompra.AutoSize = true;
            this.lblPrecioCompra.ForeColor = Color.FromArgb(212, 197, 171);
            this.lblPrecioCompra.Location = new Point(270, 120);
            this.lblPrecioCompra.Text = "Precio Compra:";

            // txtPrecioCompra

            this.txtPrecioCompra.Location = new Point(380, 116);
            this.txtPrecioCompra.Size = new Size(100, 27);
            this.txtPrecioCompra.Font = new Font("Segoe UI", 11F);
            this.txtPrecioCompra.ForeColor = Color.FromArgb(237, 225, 208);
            this.txtPrecioCompra.BackColor = Color.FromArgb(18, 18, 18);
            this.txtPrecioCompra.BorderStyle = BorderStyle.FixedSingle;

            // lblExistencia

            this.lblExistencia.AutoSize = true;
            this.lblExistencia.ForeColor = Color.FromArgb(212, 197, 171);
            this.lblExistencia.Location = new Point(510, 120);
            this.lblExistencia.Text = "Existencia:";

            // txtExistencia

            this.txtExistencia.Location = new Point(590, 116);
            this.txtExistencia.Size = new Size(100, 27);
            this.txtExistencia.Font = new Font("Segoe UI", 11F);
            this.txtExistencia.ForeColor = Color.FromArgb(237, 225, 208);
            this.txtExistencia.BackColor = Color.FromArgb(18, 18, 18);
            this.txtExistencia.BorderStyle = BorderStyle.FixedSingle;

            // btnGuardar

            this.btnGuardar.Text = "💾 Guardar";

            this.btnGuardar.Location = new Point(220, 220);
            this.btnGuardar.Size = new Size(140, 40);

            this.btnGuardar.BackColor =
                Color.FromArgb(255, 191, 0);

            this.btnGuardar.ForeColor =
                Color.FromArgb(109, 80, 0);

            this.btnGuardar.FlatStyle = FlatStyle.Flat;
            this.btnGuardar.FlatAppearance.BorderSize = 0;

            this.btnGuardar.Click +=
                new System.EventHandler(this.btnGuardar_Click);

            // btnCancelar

            this.btnCancelar.Text = "Cancelar";

            this.btnCancelar.Location = new Point(390, 220);
            this.btnCancelar.Size = new Size(120, 40);

            this.btnCancelar.BackColor =
                Color.FromArgb(42, 42, 42);

            this.btnCancelar.ForeColor =
                Color.FromArgb(237, 225, 208);

            this.btnCancelar.FlatStyle = FlatStyle.Flat;
            this.btnCancelar.FlatAppearance.BorderSize = 0;

            this.btnCancelar.Click +=
                new System.EventHandler(this.btnCancelar_Click);

            // Agregar controles al panelDetalle

            this.panelDetalle.Controls.Add(this.lblCodigoBarra);
            this.panelDetalle.Controls.Add(this.txtCodigoBarra);

            this.panelDetalle.Controls.Add(this.lblDescripcion);
            this.panelDetalle.Controls.Add(this.txtDescripcion);

            this.panelDetalle.Controls.Add(this.lblPrecioVenta);
            this.panelDetalle.Controls.Add(this.txtPrecioVenta);

            this.panelDetalle.Controls.Add(this.lblDescuento);
            this.panelDetalle.Controls.Add(this.txtDescuento);

            this.panelDetalle.Controls.Add(this.lblImpuesto);
            this.panelDetalle.Controls.Add(this.txtImpuesto);

            this.panelDetalle.Controls.Add(this.lblUnidadMedida);
            this.panelDetalle.Controls.Add(this.txtUnidadMedida);

            this.panelDetalle.Controls.Add(this.lblPrecioCompra);
            this.panelDetalle.Controls.Add(this.txtPrecioCompra);

            this.panelDetalle.Controls.Add(this.lblExistencia);
            this.panelDetalle.Controls.Add(this.txtExistencia);

            this.panelDetalle.Controls.Add(this.btnGuardar);
            this.panelDetalle.Controls.Add(this.btnCancelar);

            // ucMenu

            this.BackColor = Color.FromArgb(18, 18, 18);

            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.panelDetalle);
            this.Controls.Add(this.panelTop);

            this.Name = "ucMenu";

            this.Load +=
                new System.EventHandler(this.ucMenu_Load);

            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvProductos)).EndInit();

            this.panelDetalle.ResumeLayout(false);
            this.panelDetalle.PerformLayout();

            this.ResumeLayout(false);
        }

        private Panel panelTop;

        private Label lblTitle;

        private TextBox txtBuscar;

        private Button btnBuscar;
        private Button btnNuevo;
        private Button btnEditar;
        private Button btnEliminar;

        private DataGridView dgvProductos;

        private Panel panelDetalle;

        private Label lblCodigoBarra;
        private TextBox txtCodigoBarra;

        private Label lblDescripcion;
        private TextBox txtDescripcion;

        private Label lblPrecioVenta;
        private TextBox txtPrecioVenta;

        private Label lblDescuento;
        private TextBox txtDescuento;

        private Label lblImpuesto;
        private TextBox txtImpuesto;

        private Label lblUnidadMedida;
        private TextBox txtUnidadMedida;

        private Label lblPrecioCompra;
        private TextBox txtPrecioCompra;

        private Label lblExistencia;
        private TextBox txtExistencia;

        private Button btnGuardar;
        private Button btnCancelar;
    }


}

