using System.Drawing;
using System.Windows.Forms;

namespace AplicacionEscritorio
{
    partial class ucClientes
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.panelDetalle = new System.Windows.Forms.Panel();
            this.lblCedula = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.cmbTipoCedula = new System.Windows.Forms.ComboBox();
            this.lblTipoCedula = new System.Windows.Forms.Label();
            this.btnConsultarGometa = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();

            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.panelDetalle.SuspendLayout();
            this.SuspendLayout();

            // panelTop
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Height = 50;
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(26, 26, 26);

            // lblTitle
            this.lblTitle.Text = "\U0001F464  Clientes";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(237, 225, 208);
            this.lblTitle.Location = new System.Drawing.Point(16, 10);
            this.lblTitle.Size = new System.Drawing.Size(150, 30);

            // txtBuscar
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(237, 225, 208);
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Location = new System.Drawing.Point(180, 12);
            this.txtBuscar.Size = new System.Drawing.Size(200, 27);
            this.txtBuscar.Text = "";
            this.txtBuscar.KeyPress += (s, e) => { if (e.KeyChar == (char)13) btnBuscar.PerformClick(); };

            // btnBuscar
            this.btnBuscar.Text = "\U0001F50D";
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(237, 225, 208);
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(42, 42, 42);
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Location = new System.Drawing.Point(386, 11);
            this.btnBuscar.Size = new System.Drawing.Size(36, 28);
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);

            // btnNuevo
            this.btnNuevo.Text = "\u2795  Nuevo";
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNuevo.ForeColor = System.Drawing.Color.FromArgb(109, 80, 0);
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(255, 191, 0);
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.Location = new System.Drawing.Point(440, 10);
            this.btnNuevo.Size = new System.Drawing.Size(90, 30);
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);

            // btnEditar
            this.btnEditar.Text = "\u270F  Editar";
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnEditar.ForeColor = System.Drawing.Color.FromArgb(237, 225, 208);
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(42, 42, 42);
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Location = new System.Drawing.Point(536, 10);
            this.btnEditar.Size = new System.Drawing.Size(80, 30);
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);

            // btnEliminar
            this.btnEliminar.Text = "\U0001F5D1  Eliminar";
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(237, 225, 208);
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(42, 42, 42);
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Location = new System.Drawing.Point(622, 10);
            this.btnEliminar.Size = new System.Drawing.Size(90, 30);
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);

            // dgvClientes
            this.dgvClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.FromArgb(18, 18, 18);
            this.dgvClientes.ForeColor = System.Drawing.Color.FromArgb(237, 225, 208);
            this.dgvClientes.GridColor = System.Drawing.Color.FromArgb(42, 42, 42);
            this.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dgvClientes.RowTemplate.Height = 32;

            this.dgvClientes.EnableHeadersVisualStyles = false;
            this.dgvClientes.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(26, 26, 26);
            this.dgvClientes.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(212, 197, 171);
            this.dgvClientes.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvClientes.ColumnHeadersHeight = 36;
            this.dgvClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;

            this.dgvClientes.RowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            this.dgvClientes.RowsDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(237, 225, 208);
            this.dgvClientes.RowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(255, 191, 0);
            this.dgvClientes.RowsDefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(18, 18, 18);
            this.dgvClientes.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(24, 24, 24);

            // panelDetalle
            this.panelDetalle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDetalle.Height = 200;
            this.panelDetalle.BackColor = System.Drawing.Color.FromArgb(26, 26, 26);
            this.panelDetalle.Visible = false;
            this.panelDetalle.Padding = new System.Windows.Forms.Padding(20, 16, 20, 16);

            // lblCedula
            this.lblCedula.Text = "C\u00e9dula Legal:";
            this.lblCedula.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCedula.ForeColor = System.Drawing.Color.FromArgb(212, 197, 171);
            this.lblCedula.Location = new System.Drawing.Point(20, 16);
            this.lblCedula.Size = new System.Drawing.Size(100, 22);

            // txtCedula
            this.txtCedula.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCedula.ForeColor = System.Drawing.Color.FromArgb(237, 225, 208);
            this.txtCedula.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            this.txtCedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCedula.Location = new System.Drawing.Point(120, 14);
            this.txtCedula.Size = new System.Drawing.Size(160, 27);

            // lblTipoCedula
            this.lblTipoCedula.Text = "Tipo:";
            this.lblTipoCedula.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTipoCedula.ForeColor = System.Drawing.Color.FromArgb(212, 197, 171);
            this.lblTipoCedula.Location = new System.Drawing.Point(290, 16);
            this.lblTipoCedula.Size = new System.Drawing.Size(40, 22);

            // cmbTipoCedula
            this.cmbTipoCedula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoCedula.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbTipoCedula.ForeColor = System.Drawing.Color.FromArgb(237, 225, 208);
            this.cmbTipoCedula.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            this.cmbTipoCedula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipoCedula.Location = new System.Drawing.Point(330, 14);
            this.cmbTipoCedula.Size = new System.Drawing.Size(100, 28);
            this.cmbTipoCedula.Items.AddRange(new object[] { "FISICA", "JURIDICA", "DIMEX" });

            // btnConsultarGometa
            this.btnConsultarGometa.Text = "\U0001F50D  Gometa";
            this.btnConsultarGometa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnConsultarGometa.ForeColor = System.Drawing.Color.FromArgb(212, 197, 171);
            this.btnConsultarGometa.BackColor = System.Drawing.Color.FromArgb(42, 42, 42);
            this.btnConsultarGometa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarGometa.FlatAppearance.BorderSize = 0;
            this.btnConsultarGometa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarGometa.Location = new System.Drawing.Point(440, 14);
            this.btnConsultarGometa.Size = new System.Drawing.Size(90, 28);
            this.btnConsultarGometa.Click += new System.EventHandler(this.btnConsultarGometa_Click);

            // lblNombre
            this.lblNombre.Text = "Nombre Completo:";
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(212, 197, 171);
            this.lblNombre.Location = new System.Drawing.Point(20, 56);
            this.lblNombre.Size = new System.Drawing.Size(120, 22);

            // txtNombre
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(237, 225, 208);
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Location = new System.Drawing.Point(140, 54);
            this.txtNombre.Size = new System.Drawing.Size(390, 27);

            // lblEmail
            this.lblEmail.Text = "Email:";
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(212, 197, 171);
            this.lblEmail.Location = new System.Drawing.Point(20, 96);
            this.lblEmail.Size = new System.Drawing.Size(100, 22);

            // txtEmail
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(237, 225, 208);
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Location = new System.Drawing.Point(100, 94);
            this.txtEmail.Size = new System.Drawing.Size(430, 27);

            // btnGuardar
            this.btnGuardar.Text = "\U0001F4BE  Guardar";
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(109, 80, 0);
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(255, 191, 0);
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Location = new System.Drawing.Point(140, 140);
            this.btnGuardar.Size = new System.Drawing.Size(130, 40);
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            // btnCancelar
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(237, 225, 208);
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(42, 42, 42);
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Location = new System.Drawing.Point(286, 140);
            this.btnCancelar.Size = new System.Drawing.Size(100, 40);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);

            // assemble panelDetalle
            this.panelDetalle.Controls.Add(this.lblCedula);
            this.panelDetalle.Controls.Add(this.txtCedula);
            this.panelDetalle.Controls.Add(this.lblTipoCedula);
            this.panelDetalle.Controls.Add(this.cmbTipoCedula);
            this.panelDetalle.Controls.Add(this.btnConsultarGometa);
            this.panelDetalle.Controls.Add(this.lblNombre);
            this.panelDetalle.Controls.Add(this.txtNombre);
            this.panelDetalle.Controls.Add(this.lblEmail);
            this.panelDetalle.Controls.Add(this.txtEmail);
            this.panelDetalle.Controls.Add(this.btnGuardar);
            this.panelDetalle.Controls.Add(this.btnCancelar);

            // assemble panelTop
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Controls.Add(this.txtBuscar);
            this.panelTop.Controls.Add(this.btnBuscar);
            this.panelTop.Controls.Add(this.btnNuevo);
            this.panelTop.Controls.Add(this.btnEditar);
            this.panelTop.Controls.Add(this.btnEliminar);

            // ucClientes
            this.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.panelDetalle);
            this.Controls.Add(this.panelTop);
            this.Load += new System.EventHandler(this.ucClientes_Load);

            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.panelDetalle.ResumeLayout(false);
            this.panelDetalle.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Panel panelDetalle;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.ComboBox cmbTipoCedula;
        private System.Windows.Forms.Label lblTipoCedula;
        private System.Windows.Forms.Button btnConsultarGometa;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
