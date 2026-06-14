using System;
using System.Drawing;
using System.Windows.Forms;

namespace AplicacionEscritorio
{
    public partial class Form2 : Form
    {
        private ucDashboard _dashboard;
        private ucClientes _clientes;
        private ucFacturas _facturas;
        private ucMenu _menu;
        private ucCrearFactura _crearFactura;
        private ucCuentasPorCobrar _cuentasCobrar;
        private ucUsuarios _usuarios;
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

        private void btnProductos_Click(object sender, EventArgs e)
        {
            if (_menu == null)
                _menu = new ucMenu();
            LoadScreen(_menu);
        }

        private void btnNuevaFactura_Click(object sender, EventArgs e)
        {
            if (_crearFactura == null)
                _crearFactura = new ucCrearFactura();
            LoadScreen(_crearFactura);
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            if (_facturas == null)
                _facturas = new ucFacturas();
            LoadScreen(_facturas);
        }

        private void btnCxC_Click(object sender, EventArgs e)
        {
            if (_cuentasCobrar == null)
                _cuentasCobrar = new ucCuentasPorCobrar();
            LoadScreen(_cuentasCobrar);
        }
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            if (_usuarios == null)
                _usuarios = new ucUsuarios();
            LoadScreen(_usuarios);
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Close();
        }
    }
}
