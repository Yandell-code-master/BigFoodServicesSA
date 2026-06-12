using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AplicacionEscritorio.Models;
using AplicacionEscritorio.Services;

namespace AplicacionEscritorio
{
    public partial class ucDashboard : UserControl
    {
        public ucDashboard()
        {
            InitializeComponent();
            lblWelcome.Text = $"Welcome back, {ApiService.UsuarioActual ?? "Admin"}!";
            this.Load += ucDashboard_Load;
        }

        private async void ucDashboard_Load(object sender, EventArgs e)
        {
            await CargarKPIs();
        }

        private async System.Threading.Tasks.Task CargarKPIs()
        {
            try
            {
                var tClientes = ApiService.GetAsync<List<Cliente>>("Clientes/List");
                var tProductos = ApiService.GetAsync<List<object>>("Productos/List");
                var tFacturas = ApiService.GetAsync<List<Dictionary<string, object>>>("Facturas/List");

                await Task.WhenAll(tClientes, tProductos, tFacturas);

                lblValorClientes.Text = tClientes.Result?.Count(c => c.Estado).ToString() ?? "0";
                lblValorProductos.Text = tProductos.Result?.Count.ToString() ?? "0";

                var facturas = tFacturas.Result;
                if (facturas != null)
                {
                    lblValorFacturas.Text = facturas.Count(d =>
                    {
                        d.TryGetValue("fecha", out var raw);
                        return DateTime.TryParse(raw?.ToString(), out var dt) && dt.Date == DateTime.Today;
                    }).ToString();
                    lblValorCxC.Text = facturas.Count(d =>
                    {
                        d.TryGetValue("estado", out var raw);
                        return raw?.ToString() == "PENDIENTE";
                    }).ToString();
                }
            }
            catch
            {
                lblValorClientes.Text = "?";
                lblValorProductos.Text = "?";
                lblValorFacturas.Text = "?";
                lblValorCxC.Text = "?";
            }
        }
    }
}
