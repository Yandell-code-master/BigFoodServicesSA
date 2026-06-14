namespace AplicacionEscritorio
{
    partial class ucCuentasPorCobrar
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
            this.btnAbonarCuenta = new System.Windows.Forms.Button();
            this.dgvCuentas = new System.Windows.Forms.DataGridView();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Controls.Add(this.txtBuscar);
            this.panelTop.Controls.Add(this.btnBuscar);
            this.panelTop.Controls.Add(this.btnAbonarCuenta);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(800, 50);
            this.panelTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(225)))), ((int)(((byte)(208)))));
            this.lblTitle.Location = new System.Drawing.Point(16, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(220, 30);
            this.lblTitle.Text = "⏳ Cuentas por Cobrar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(225)))), ((int)(((byte)(208)))));
            this.txtBuscar.Location = new System.Drawing.Point(250, 12);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(200, 27);
            this.txtBuscar.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(225)))), ((int)(((byte)(208)))));
            this.btnBuscar.Location = new System.Drawing.Point(456, 11);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(36, 28);
            this.btnBuscar.Text = "🔍";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnAbonarCuenta
            // 
            this.btnAbonarCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btnAbonarCuenta.FlatAppearance.BorderSize = 0;
            this.btnAbonarCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbonarCuenta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAbonarCuenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.btnAbonarCuenta.Location = new System.Drawing.Point(640, 10);
            this.btnAbonarCuenta.Name = "btnAbonarCuenta";
            this.btnAbonarCuenta.Size = new System.Drawing.Size(140, 30);
            this.btnAbonarCuenta.TabIndex = 2;
            this.btnAbonarCuenta.Text = "💰 Liquidar Pago";
            this.btnAbonarCuenta.UseVisualStyleBackColor = false;
            this.btnAbonarCuenta.Click += new System.EventHandler(this.btnAbonarCuenta_Click);
            // 
            // dgvCuentas
            // 
            this.dgvCuentas.AllowUserToAddRows = false;
            this.dgvCuentas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.dgvCuentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCuentas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dgvCuentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCuentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(197)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCuentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCuentas.ColumnHeadersHeight = 36;
            this.dgvCuentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCuentas.EnableHeadersVisualStyles = false;
            this.dgvCuentas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.dgvCuentas.Location = new System.Drawing.Point(0, 50);
            this.dgvCuentas.MultiSelect = false;
            this.dgvCuentas.Name = "dgvCuentas";
            this.dgvCuentas.ReadOnly = true;
            this.dgvCuentas.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(225)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dgvCuentas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCuentas.RowTemplate.Height = 32;
            this.dgvCuentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCuentas.Size = new System.Drawing.Size(800, 400);
            this.dgvCuentas.TabIndex = 3;
            // 
            // ucCuentasPorCobrar
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Controls.Add(this.dgvCuentas);
            this.Controls.Add(this.panelTop);
            this.Name = "ucCuentasPorCobrar";
            this.Size = new System.Drawing.Size(800, 450);
            this.Load += new System.EventHandler(this.ucCuentasPorCobrar_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentas)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAbonarCuenta;
        private System.Windows.Forms.DataGridView dgvCuentas;
    }
}
