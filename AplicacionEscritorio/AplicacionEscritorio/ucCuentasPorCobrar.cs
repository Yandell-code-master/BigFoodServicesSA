using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AplicacionEscritorio.Models;
using AplicacionEscritorio.Services;

namespace AplicacionEscritorio
{
    public partial class ucCuentasPorCobrar : UserControl
    {
        private List<Factura> _cuentasPendientes = new List<Factura>();

        public ucCuentasPorCobrar()
        {
            InitializeComponent();
            txtBuscar.TextChanged += TxtBuscar_TextChanged;
        }

        private void ucCuentasPorCobrar_Load(object sender, EventArgs e)
        {
            ConfigurarColumnasCuentas();
            btnBuscar.Visible = false; 
            _ = LoadCuentas();
        }

        private void ConfigurarColumnasCuentas()
        {
            dgvCuentas.AutoGenerateColumns = false;
            dgvCuentas.Columns.Clear();

            dgvCuentas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Numero",
                HeaderText = "Número Factura",
                Width = 110
            });

            dgvCuentas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Fecha",
                HeaderText = "Fecha Emisión",
                Width = 130
            });

            dgvCuentas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CedulaCliente",
                HeaderText = "Cédula Cliente",
                Width = 140
            });

            dgvCuentas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Total",
                HeaderText = "Monto Pendiente",
                Width = 130
            });

            dgvCuentas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Estado",
                HeaderText = "Estado",
                Width = 110
            });

            dgvCuentas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Condicion",
                HeaderText = "Condición",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
        }

       
        protected override async void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (this.Visible)
            {
                await LoadCuentas();
            }
        }

        private async Task LoadCuentas()
        {
            try
            {
            
                var todasLasFacturas = await ApiService.GetAsync<List<Factura>>("Facturas/List");

                _cuentasPendientes = todasLasFacturas
                    .Where(f => f.Condicion == "CREDITO" && f.Estado == "PENDIENTE")
                    .ToList();

                FiltrarCuentas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar cuentas por cobrar: " + ex.Message);
            }
        }

        private void FiltrarCuentas()
        {
            string filtro = txtBuscar.Text.Trim();

            dgvCuentas.DataSource = string.IsNullOrWhiteSpace(filtro)
                ? _cuentasPendientes
                : _cuentasPendientes.Where(f =>
                    f.Numero.ToString().Contains(filtro) ||
                    f.CedulaCliente.Contains(filtro))
                .ToList();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            FiltrarCuentas();
        }

        private async void btnAbonarCuenta_Click(object sender, EventArgs e)
        {
            if (dgvCuentas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione una cuenta de la lista.");
                return;
            }

            var facturaSeleccionada = (Factura)dgvCuentas.SelectedRows[0].DataBoundItem;

            
            var confirmacion = MessageBox.Show(
                $"¿Está seguro de registrar el pago total de la factura N° {facturaSeleccionada.Numero} por un monto de {facturaSeleccionada.Total:N2}?",
                "Confirmar Pago de Cuenta",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                   
                    string resultado = await ApiService.PutAsync(
                        $"Facturas/PagarCuenta?numeroFactura={facturaSeleccionada.Numero}",
                        new { });

                    MessageBox.Show(resultado, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                  
                    await LoadCuentas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al procesar el pago: " + ex.Message);
                }
            }
        }
    }
}