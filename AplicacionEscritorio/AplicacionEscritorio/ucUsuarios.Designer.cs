namespace AplicacionEscritorio
{
    partial class ucUsuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnNuevoUsuario = new System.Windows.Forms.Button();
            this.btnEliminarUsuario = new System.Windows.Forms.Button(); 
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.panelDetalle = new System.Windows.Forms.Panel();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblRoll = new System.Windows.Forms.Label();
            this.cmbRoll = new System.Windows.Forms.ComboBox();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.btnGuardarUsuario = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.panelDetalle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Controls.Add(this.txtBuscar);
            this.panelTop.Controls.Add(this.btnBuscar);
            this.panelTop.Controls.Add(this.btnNuevoUsuario);
            this.panelTop.Controls.Add(this.btnEliminarUsuario); 
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(950, 50);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(225)))), ((int)(((byte)(208)))));
            this.lblTitle.Location = new System.Drawing.Point(16, 11);
            this.lblTitle.Size = new System.Drawing.Size(180, 30);
            this.lblTitle.Text = "👥 Control Usuarios";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(225)))), ((int)(((byte)(208)))));
            this.txtBuscar.Location = new System.Drawing.Point(220, 12);
            this.txtBuscar.Size = new System.Drawing.Size(220, 27);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(446, 11);
            this.btnBuscar.Size = new System.Drawing.Size(30, 28);
            // 
            // btnNuevoUsuario
            // 
            this.btnNuevoUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btnNuevoUsuario.FlatAppearance.BorderSize = 0;
            this.btnNuevoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoUsuario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNuevoUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnNuevoUsuario.Location = new System.Drawing.Point(490, 10);
            this.btnNuevoUsuario.Size = new System.Drawing.Size(140, 30);
            this.btnNuevoUsuario.Text = "➕ Nuevo Usuario";
            this.btnNuevoUsuario.UseVisualStyleBackColor = false;
            this.btnNuevoUsuario.Click += new System.EventHandler(this.btnNuevoUsuario_Click);
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69))))); // Color rojo discreto para alertas/borrado
            this.btnEliminarUsuario.FlatAppearance.BorderSize = 0;
            this.btnEliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarUsuario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEliminarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnEliminarUsuario.Location = new System.Drawing.Point(640, 10);
            this.btnEliminarUsuario.Size = new System.Drawing.Size(140, 30);
            this.btnEliminarUsuario.Text = "🗑️ Eliminar";
            this.btnEliminarUsuario.UseVisualStyleBackColor = false;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click); 
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.dgvUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(197)))), ((int)(((byte)(171)))));
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsuarios.ColumnHeadersHeight = 36;
            this.dgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsuarios.EnableHeadersVisualStyles = false;
            this.dgvUsuarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.dgvUsuarios.Location = new System.Drawing.Point(0, 50);
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(225)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dgvUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsuarios.RowTemplate.Height = 32;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(650, 500);
            // 
            // panelDetalle
            // 
            this.panelDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panelDetalle.Controls.Add(this.lblSubtitulo);
            this.panelDetalle.Controls.Add(this.lblEmail);
            this.panelDetalle.Controls.Add(this.txtEmail);
            this.panelDetalle.Controls.Add(this.lblPassword);
            this.panelDetalle.Controls.Add(this.txtPassword);
            this.panelDetalle.Controls.Add(this.lblRoll);
            this.panelDetalle.Controls.Add(this.cmbRoll);
            this.panelDetalle.Controls.Add(this.chkStatus);
            this.panelDetalle.Controls.Add(this.btnGuardarUsuario);
            this.panelDetalle.Controls.Add(this.btnCancelar);
            this.panelDetalle.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelDetalle.Location = new System.Drawing.Point(650, 50);
            this.panelDetalle.Size = new System.Drawing.Size(300, 500);
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.lblSubtitulo.Location = new System.Drawing.Point(16, 15);
            this.lblSubtitulo.Size = new System.Drawing.Size(200, 25);
            this.lblSubtitulo.Text = "Datos de Usuario";
            // 
            // lblEmail
            // 
            this.lblEmail.ForeColor = System.Drawing.Color.DarkGray;
            this.lblEmail.Location = new System.Drawing.Point(16, 60);
            this.lblEmail.Text = "Email / Usuario:";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(16, 80);
            this.txtEmail.Size = new System.Drawing.Size(260, 23);
            // 
            // lblPassword
            // 
            this.lblPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPassword.Location = new System.Drawing.Point(16, 120);
            this.lblPassword.Text = "Contraseña:";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(16, 140);
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(260, 23);
            // 
            // lblRoll
            // 
            this.lblRoll.ForeColor = System.Drawing.Color.DarkGray;
            this.lblRoll.Location = new System.Drawing.Point(16, 180);
            this.lblRoll.Text = "Rol Asignado (Roll):";
            // 
            // cmbRoll
            // 
            this.cmbRoll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.cmbRoll.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; // Evita que escriban texto libre
            this.cmbRoll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRoll.ForeColor = System.Drawing.Color.White;
            this.cmbRoll.Location = new System.Drawing.Point(16, 200);
            this.cmbRoll.Size = new System.Drawing.Size(260, 23);
            // 
            // chkStatus
            // 
            this.chkStatus.ForeColor = System.Drawing.Color.White;
            this.chkStatus.Location = new System.Drawing.Point(16, 250);
            this.chkStatus.Text = "Usuario Activo (Status)";
            this.chkStatus.Checked = true;
            // 
            // btnGuardarUsuario
            // 
            this.btnGuardarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btnGuardarUsuario.FlatAppearance.BorderSize = 0;
            this.btnGuardarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarUsuario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuardarUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnGuardarUsuario.Location = new System.Drawing.Point(16, 310);
            this.btnGuardarUsuario.Size = new System.Drawing.Size(120, 30);
            this.btnGuardarUsuario.Text = "💾 Guardar";
            this.btnGuardarUsuario.Click += new System.EventHandler(this.btnGuardarUsuario_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(156, 310);
            this.btnCancelar.Size = new System.Drawing.Size(120, 30);
            this.btnCancelar.Text = "❌ Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // ucUsuarios
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.panelDetalle);
            this.Controls.Add(this.panelTop);
            this.Size = new System.Drawing.Size(950, 550);
            this.Load += new System.EventHandler(this.ucUsuarios_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.panelDetalle.ResumeLayout(false);
            this.panelDetalle.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnNuevoUsuario;
        private System.Windows.Forms.Button btnEliminarUsuario; 
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Panel panelDetalle;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblRoll;
        private System.Windows.Forms.ComboBox cmbRoll;
        private System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.Button btnGuardarUsuario;
        private System.Windows.Forms.Button btnCancelar;
    }
}