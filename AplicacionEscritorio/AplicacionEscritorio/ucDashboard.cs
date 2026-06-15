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

            
            InicializarComponentesPersonalizados();

            lblWelcome.Text = $"Welcome back, {ApiService.UsuarioActual ?? "Admin"}!";
            this.Load += ucDashboard_Load;

            // Detecta cada vez que el Dashboard se oculta o se vuelve a mostrar en pantalla
            this.VisibleChanged += UcDashboard_VisibleChanged;
        }

        private void InicializarComponentesPersonalizados()
        {
            // Creamos las tarjetas mapeando correctamente los out Label a los campos de la clase
            this.cardClientes = CreateCard("\U0001F465", "Clientes", "-", out lblValorClientes);
            this.cardProductos = CreateCard("\U0001F4E6", "Productos", "-", out lblValorProductos);
            this.cardFacturas = CreateCard("\U0001F9FE", "Facturas Hoy", "-", out lblValorFacturas);
            this.cardCxC = CreateCard("\U0001F4B0", "CxC Pendientes", "-", out lblValorCxC);

            // Los añadimos al TableLayoutPanel de la vista
            this.tblKPI.Controls.Add(this.cardClientes, 0, 0);
            this.tblKPI.Controls.Add(this.cardProductos, 1, 0);
            this.tblKPI.Controls.Add(this.cardFacturas, 0, 1);
            this.tblKPI.Controls.Add(this.cardCxC, 1, 1);

            
            this.btnIrFacturar = CreateActionButton("\U0001F9FE  Nueva Factura");
            this.btnIrClientes = CreateActionButton("\U0001F464  Clientes");
            this.btnIrProductos = CreateActionButton("\U0001F4E6  Productos");
            this.btnIrFacturas = CreateActionButton("\U0001F4CB  Facturas");

            
            this.flowAcciones.Controls.Add(this.btnIrFacturar);
            this.flowAcciones.Controls.Add(this.btnIrClientes);
            this.flowAcciones.Controls.Add(this.btnIrProductos);
            this.flowAcciones.Controls.Add(this.btnIrFacturas);

         
        }

        private async void ucDashboard_Load(object sender, EventArgs e)
        {
            await CargarKPIs();
        }


        private async void UcDashboard_VisibleChanged(object sender, EventArgs e)
        {
            // Si el control se volvió visible, actualizamos los números automáticamente
            if (this.Visible)
            {
                await CargarKPIs();
            }
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