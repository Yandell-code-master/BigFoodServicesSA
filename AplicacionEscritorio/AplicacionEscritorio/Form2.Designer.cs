using System.Drawing;
using System.Windows.Forms;

namespace AplicacionEscritorio
{
    partial class Form2
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
            this.tblTop = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.flowNav = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnNuevaFactura = new System.Windows.Forms.Button();
            this.btnFacturas = new System.Windows.Forms.Button();
            this.btnCxC = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            this.tblTop.SuspendLayout();
            this.flowNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panelTop.Controls.Add(this.tblTop);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1200, 50);
            this.panelTop.TabIndex = 1;
            // 
            // tblTop
            // 
            this.tblTop.ColumnCount = 3;
            this.tblTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tblTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tblTop.Controls.Add(this.lblTitle, 0, 0);
            this.tblTop.Controls.Add(this.flowNav, 1, 0);
            this.tblTop.Controls.Add(this.btnLogout, 2, 0);
            this.tblTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblTop.Location = new System.Drawing.Point(0, 0);
            this.tblTop.Name = "tblTop";
            this.tblTop.RowCount = 1;
            this.tblTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblTop.Size = new System.Drawing.Size(1200, 50);
            this.tblTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(124, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "BigFoodSA";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowNav
            // 
            this.flowNav.BackColor = System.Drawing.Color.Transparent;
            this.flowNav.Controls.Add(this.btnDashboard);
            this.flowNav.Controls.Add(this.btnClientes);
            this.flowNav.Controls.Add(this.btnProductos);
            this.flowNav.Controls.Add(this.btnNuevaFactura);
            this.flowNav.Controls.Add(this.btnFacturas);
            this.flowNav.Controls.Add(this.btnCxC);
            this.flowNav.Controls.Add(this.btnUsuarios);
            this.flowNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowNav.Location = new System.Drawing.Point(133, 3);
            this.flowNav.Name = "flowNav";
            this.flowNav.Size = new System.Drawing.Size(964, 44);
            this.flowNav.TabIndex = 1;
            // 
            // btnDashboard
            // 
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(225)))), ((int)(((byte)(208)))));
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(110, 34);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "🏠 Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(225)))), ((int)(((byte)(208)))));
            this.btnClientes.Location = new System.Drawing.Point(110, 0);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(0);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(110, 34);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "👤 Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(225)))), ((int)(((byte)(208)))));
            this.btnProductos.Location = new System.Drawing.Point(220, 0);
            this.btnProductos.Margin = new System.Windows.Forms.Padding(0);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(110, 34);
            this.btnProductos.TabIndex = 2;
            this.btnProductos.Text = "📦 Menú";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnNuevaFactura
            // 
            this.btnNuevaFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevaFactura.FlatAppearance.BorderSize = 0;
            this.btnNuevaFactura.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnNuevaFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaFactura.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNuevaFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(225)))), ((int)(((byte)(208)))));
            this.btnNuevaFactura.Location = new System.Drawing.Point(330, 0);
            this.btnNuevaFactura.Margin = new System.Windows.Forms.Padding(0);
            this.btnNuevaFactura.Name = "btnNuevaFactura";
            this.btnNuevaFactura.Size = new System.Drawing.Size(110, 34);
            this.btnNuevaFactura.TabIndex = 3;
            this.btnNuevaFactura.Text = "🧾 Facturar";
            this.btnNuevaFactura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaFactura.Click += new System.EventHandler(this.btnNuevaFactura_Click);
            // 
            // btnFacturas
            // 
            this.btnFacturas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFacturas.FlatAppearance.BorderSize = 0;
            this.btnFacturas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnFacturas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(225)))), ((int)(((byte)(208)))));
            this.btnFacturas.Location = new System.Drawing.Point(440, 0);
            this.btnFacturas.Margin = new System.Windows.Forms.Padding(0);
            this.btnFacturas.Name = "btnFacturas";
            this.btnFacturas.Size = new System.Drawing.Size(110, 34);
            this.btnFacturas.TabIndex = 4;
            this.btnFacturas.Text = "📋 Facturas";
            this.btnFacturas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturas.Click += new System.EventHandler(this.btnFacturas_Click);
            // 
            // btnCxC
            // 
            this.btnCxC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCxC.FlatAppearance.BorderSize = 0;
            this.btnCxC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnCxC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCxC.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCxC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(225)))), ((int)(((byte)(208)))));
            this.btnCxC.Location = new System.Drawing.Point(550, 0);
            this.btnCxC.Margin = new System.Windows.Forms.Padding(0);
            this.btnCxC.Name = "btnCxC";
            this.btnCxC.Size = new System.Drawing.Size(110, 34);
            this.btnCxC.TabIndex = 5;
            this.btnCxC.Text = "💰 CxC";
            this.btnCxC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCxC.Click += new System.EventHandler(this.btnCxC_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(225)))), ((int)(((byte)(208)))));
            this.btnUsuarios.Location = new System.Drawing.Point(660, 0);
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(0);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(110, 34);
            this.btnUsuarios.TabIndex = 6;
            this.btnUsuarios.Text = "🔐 Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(197)))), ((int)(((byte)(171)))));
            this.btnLogout.Location = new System.Drawing.Point(1103, 3);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.btnLogout.Size = new System.Drawing.Size(94, 44);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "🚪  Salir";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 50);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1200, 650);
            this.panelMain.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTop);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelTop.ResumeLayout(false);
            this.tblTop.ResumeLayout(false);
            this.flowNav.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.TableLayoutPanel tblTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.FlowLayoutPanel flowNav;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnNuevaFactura;
        private System.Windows.Forms.Button btnFacturas;
        private System.Windows.Forms.Button btnCxC;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panelMain;
    }
}
