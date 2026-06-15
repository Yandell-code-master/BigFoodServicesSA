using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AplicacionEscritorio.Models;
using AplicacionEscritorio.Services;

namespace AplicacionEscritorio
{
    public partial class ucFacturas : UserControl
    {
        private List<Factura> _facturas = new List<Factura>();


    public ucFacturas()
        {
            InitializeComponent();
            

            txtBuscar.TextChanged += TxtBuscar_TextChanged;
        }

        private void ucFacturas_Load(object sender, EventArgs e)
        {
            ConfigurarColumnasFacturas();
          

            btnBuscar.Visible = false;

            _ = LoadFacturas();
        }

        private void ConfigurarColumnasFacturas()
        {
            dgvFacturas.AutoGenerateColumns = false;
            dgvFacturas.Columns.Clear();

            dgvFacturas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Numero",
                HeaderText = "Número",
                Width = 80
            });

            dgvFacturas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Fecha",
                HeaderText = "Fecha",
                Width = 120
            });

            dgvFacturas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CedulaCliente",
                HeaderText = "Cliente",
                Width = 150
            });

            dgvFacturas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Total",
                HeaderText = "Total",
                Width = 120
            });

            dgvFacturas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Estado",
                HeaderText = "Estado",
                Width = 100
            });

            dgvFacturas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TipoPago",
                HeaderText = "Pago",
                Width = 120
            });

            dgvFacturas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Condicion",
                HeaderText = "Condición",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
        }
        //cargar facturas cada que alguien entre a la vista
        protected override async void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (this.Visible)
            {
                await LoadFacturas();
            }
        }



        private async Task LoadFacturas()
        {
            try
            {
                _facturas = await ApiService.GetAsync<List<Factura>>("Facturas/List");
                FiltrarFacturas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FiltrarFacturas()
        {
            string filtro = txtBuscar.Text.Trim();

            dgvFacturas.DataSource =
                string.IsNullOrWhiteSpace(filtro)
                ? _facturas
                : _facturas.Where(f =>
                    f.Numero.ToString().Contains(filtro) ||
                    f.CedulaCliente.Contains(filtro))
                .ToList();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            FiltrarFacturas();
        }

     


   

        private async void btnAnularFactura_Click(object sender, EventArgs e)
        {
            if (dgvFacturas.SelectedRows.Count == 0)
                return;

            var factura =
                (Factura)dgvFacturas.SelectedRows[0].DataBoundItem;

            string resultado =
                await ApiService.DeleteAsync(
                $"Facturas/AnularFactura?numero={factura.Numero}");

            MessageBox.Show(resultado);

            await LoadFacturas();
        }

        private async void btnPagarCuenta_Click(object sender, EventArgs e)
        {
            if (dgvFacturas.SelectedRows.Count == 0)
                return;

            var factura =
                (Factura)dgvFacturas.SelectedRows[0].DataBoundItem;

            string resultado =
                await ApiService.PutAsync(
                $"Facturas/PagarCuenta?numeroFactura={factura.Numero}",
                new { });

            MessageBox.Show(resultado);

            await LoadFacturas();
        }

   
   

     
    }


}
