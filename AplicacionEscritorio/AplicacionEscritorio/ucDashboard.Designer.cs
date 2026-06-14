using System.Drawing;
using System.Windows.Forms;

namespace AplicacionEscritorio
{
    partial class ucDashboard
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.tblKPI = new System.Windows.Forms.TableLayoutPanel();
            this.cardClientes = CreateCard("\U0001F465", "Clientes", "-", out lblValorClientes);
            this.cardProductos = CreateCard("\U0001F4E6", "Productos", "-", out lblValorProductos);
            this.cardFacturas = CreateCard("\U0001F9FE", "Facturas Hoy", "-", out lblValorFacturas);
            this.cardCxC = CreateCard("\U0001F4B0", "CxC Pendientes", "-", out lblValorCxC);
            this.panelBottom = new System.Windows.Forms.Panel();
            this.lblAcceso = new System.Windows.Forms.Label();
            this.flowAcciones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnIrFacturar = CreateActionButton("\U0001F9FE  Nueva Factura");
            this.btnIrClientes = CreateActionButton("\U0001F464  Clientes");
            this.btnIrProductos = CreateActionButton("\U0001F4E6  Productos");
            this.btnIrFacturas = CreateActionButton("\U0001F4CB  Facturas");

            this.panelBottom.SuspendLayout();
            this.SuspendLayout();

            // lblWelcome
            this.lblWelcome.Text = "Welcome back!";
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(237, 225, 208);
            this.lblWelcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblWelcome.Height = 70;
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblWelcome.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);

            // tblKPI
            this.tblKPI.ColumnCount = 2;
            this.tblKPI.RowCount = 2;
            this.tblKPI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblKPI.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.tblKPI.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.tblKPI.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            this.tblKPI.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            this.tblKPI.Padding = new System.Windows.Forms.Padding(30, 10, 30, 10);
            this.tblKPI.Controls.Add(this.cardClientes, 0, 0);
            this.tblKPI.Controls.Add(this.cardProductos, 1, 0);
            this.tblKPI.Controls.Add(this.cardFacturas, 0, 1);
            this.tblKPI.Controls.Add(this.cardCxC, 1, 1);

            // panelBottom
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Height = 110;
            this.panelBottom.BackColor = System.Drawing.Color.Transparent;

            // lblAcceso
            this.lblAcceso.Text = "Acceso R\u00e1pido";
            this.lblAcceso.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblAcceso.ForeColor = System.Drawing.Color.FromArgb(212, 197, 171);
            this.lblAcceso.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAcceso.Height = 40;
            this.lblAcceso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAcceso.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);

            // flowAcciones
            this.flowAcciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowAcciones.Height = 60;
            this.flowAcciones.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.flowAcciones.BackColor = System.Drawing.Color.Transparent;
            this.flowAcciones.Controls.Add(this.btnIrFacturar);
            this.flowAcciones.Controls.Add(this.btnIrClientes);
            this.flowAcciones.Controls.Add(this.btnIrProductos);
            this.flowAcciones.Controls.Add(this.btnIrFacturas);

            // assemble panelBottom
            this.panelBottom.Controls.Add(this.flowAcciones);
            this.panelBottom.Controls.Add(this.lblAcceso);

            // ucDashboard
            this.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            this.Controls.Add(this.tblKPI);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.lblWelcome);
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);
        }
        
        private Panel CreateCard(string icon, string label, string value, out Label valueLabel)
        {
            Panel p = new Panel
            {
                BackColor = Color.FromArgb(30, 30, 30),
                Dock = DockStyle.Fill,
                Margin = new Padding(10)
            };

            TableLayoutPanel inner = new TableLayoutPanel
            {
                ColumnCount = 1,
                RowCount = 3,
                Dock = DockStyle.Fill,
                BackColor = Color.Transparent
            };
            inner.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));
            inner.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));
            inner.RowStyles.Add(new RowStyle(SizeType.Percent, 33.34F));

            inner.Controls.Add(new Label
            {
                Text = icon,
                Font = new Font("Segoe UI", 28F),
                ForeColor = Color.FromArgb(255, 191, 0),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.Transparent
            }, 0, 0);

            valueLabel = new Label
            {
                Text = value,
                Font = new Font("Segoe UI", 36F, FontStyle.Bold),
                ForeColor = Color.FromArgb(237, 225, 208),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.Transparent
            };
            inner.Controls.Add(valueLabel, 0, 1);

            inner.Controls.Add(new Label
            {
                Text = label,
                Font = new Font("Segoe UI", 12F),
                ForeColor = Color.FromArgb(212, 197, 171),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.Transparent
            }, 0, 2);

            p.Controls.Add(inner);
            return p;
        }

        private Button CreateActionButton(string text)
        {
            return new Button
            {
                Text = text,
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                ForeColor = Color.FromArgb(109, 80, 0),
                BackColor = Color.FromArgb(255, 191, 0),
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0 },
                Cursor = Cursors.Hand,
                Size = new Size(140, 50),
                Margin = new Padding(0, 0, 12, 0)
            };
        }

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblValorClientes;
        private System.Windows.Forms.Label lblValorProductos;
        private System.Windows.Forms.Label lblValorFacturas;
        private System.Windows.Forms.Label lblValorCxC;
        private System.Windows.Forms.TableLayoutPanel tblKPI;
        private System.Windows.Forms.Panel cardClientes;
        private System.Windows.Forms.Panel cardProductos;
        private System.Windows.Forms.Panel cardFacturas;
        private System.Windows.Forms.Panel cardCxC;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label lblAcceso;
        private System.Windows.Forms.FlowLayoutPanel flowAcciones;
        private System.Windows.Forms.Button btnIrFacturar;
        private System.Windows.Forms.Button btnIrClientes;
        private System.Windows.Forms.Button btnIrProductos;
        private System.Windows.Forms.Button btnIrFacturas;
    }
}
