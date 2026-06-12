using System;
using System.Drawing;
using System.Windows.Forms;

namespace AplicacionEscritorio
{
    public partial class Form2 : Form
    {
        private ucDashboard _dashboard;
        private ucClientes _clientes;

        public Form2()
        {
            InitializeComponent();
            _dashboard = new ucDashboard();
            LoadScreen(_dashboard);
        }

        private void LoadScreen(UserControl screen)
        {
            panelMain.Controls.Clear();
            screen.Dock = DockStyle.Fill;
            panelMain.Controls.Add(screen);
        }

        private void ShowPlaceholder(string title, string emoji)
        {
            panelMain.Controls.Clear();
            Label lbl = new Label
            {
                Text = $"{emoji}  {title}\n\nEsta pantalla estar\u00e1 disponible pr\u00f3ximamente.",
                Font = new Font("Segoe UI", 22F, FontStyle.Regular),
                ForeColor = Color.FromArgb(237, 225, 208),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill
            };
            panelMain.Controls.Add(lbl);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (_dashboard == null)
                _dashboard = new ucDashboard();
            LoadScreen(_dashboard);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            if (_clientes == null)
                _clientes = new ucClientes();
            LoadScreen(_clientes);
        }

        private void btnProductos_Click(object sender, EventArgs e) =>
            ShowPlaceholder("Productos / Men\u00fa", "\U0001F4E6");

        private void btnNuevaFactura_Click(object sender, EventArgs e) =>
            ShowPlaceholder("Nueva Factura", "\U0001F9FE");

        private void btnFacturas_Click(object sender, EventArgs e) =>
            ShowPlaceholder("Facturas", "\U0001F4CB");

        private void btnCxC_Click(object sender, EventArgs e) =>
            ShowPlaceholder("Cuentas por Cobrar", "\U0001F4B0");

        private void btnUsuarios_Click(object sender, EventArgs e) =>
            ShowPlaceholder("Usuarios", "\U0001F510");

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Close();
        }
    }
}
