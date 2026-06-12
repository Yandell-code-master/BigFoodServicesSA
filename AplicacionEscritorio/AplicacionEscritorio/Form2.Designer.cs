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
            this.SuspendLayout();

            // panelTop
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Height = 50;
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(26, 26, 26);

            // tblTop
            this.tblTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblTop.ColumnCount = 3;
            this.tblTop.RowCount = 1;
            this.tblTop.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130));
            this.tblTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.tblTop.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100));
            this.tblTop.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

            // lblTitle
            this.lblTitle.Text = "BigFoodSA";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(255, 191, 0);
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);

            // flowNav
            this.flowNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowNav.BackColor = System.Drawing.Color.Transparent;

            this.btnDashboard = CreateNavButton("\U0001F3E0  Dashboard");
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            this.flowNav.Controls.Add(this.btnDashboard);

            this.btnClientes = CreateNavButton("\U0001F464  Clientes");
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            this.flowNav.Controls.Add(this.btnClientes);

            this.btnProductos = CreateNavButton("\U0001F4E6  Men\u00fa");
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            this.flowNav.Controls.Add(this.btnProductos);

            this.btnNuevaFactura = CreateNavButton("\U0001F9FE  Facturar");
            this.btnNuevaFactura.Click += new System.EventHandler(this.btnNuevaFactura_Click);
            this.flowNav.Controls.Add(this.btnNuevaFactura);

            this.btnFacturas = CreateNavButton("\U0001F4CB  Facturas");
            this.btnFacturas.Click += new System.EventHandler(this.btnFacturas_Click);
            this.flowNav.Controls.Add(this.btnFacturas);

            this.btnCxC = CreateNavButton("\U0001F4B0  CxC");
            this.btnCxC.Click += new System.EventHandler(this.btnCxC_Click);
            this.flowNav.Controls.Add(this.btnCxC);

            this.btnUsuarios = CreateNavButton("\U0001F510  Usuarios");
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            this.flowNav.Controls.Add(this.btnUsuarios);

            // btnLogout
            this.btnLogout.Text = "\U0001F6AA  Salir";
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(212, 197, 171);
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.Padding = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // assemble tblTop
            this.tblTop.Controls.Add(this.lblTitle, 0, 0);
            this.tblTop.Controls.Add(this.flowNav, 1, 0);
            this.tblTop.Controls.Add(this.btnLogout, 2, 0);

            this.panelTop.Controls.Add(this.tblTop);

            // panelMain
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;

            // Form2
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);

            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTop);
            this.panelTop.ResumeLayout(false);
            this.tblTop.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button CreateNavButton(string text)
        {
            return new System.Windows.Forms.Button
            {
                Text = text,
                Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular),
                ForeColor = System.Drawing.Color.FromArgb(237, 225, 208),
                BackColor = System.Drawing.Color.Transparent,
                FlatStyle = System.Windows.Forms.FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0, MouseOverBackColor = System.Drawing.Color.FromArgb(42, 42, 42) },
                Cursor = System.Windows.Forms.Cursors.Hand,
                Size = new System.Drawing.Size(110, 34),
                TextAlign = System.Drawing.ContentAlignment.MiddleLeft,
                Margin = new System.Windows.Forms.Padding(0)
            };
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
