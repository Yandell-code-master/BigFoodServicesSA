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
            ConfigurarColumnasDetalle();

            btnBuscar.Visible = false;
            panelDetalle.Visible = false;

            cmbTipoPago.Items.AddRange(new string[]
            {
            "EFECTIVO",
            "TARJETA",
            "SINPE MOVIL"
            });

            cmbCondicion.Items.AddRange(new string[]
            {
            "CONTADO",
            "CREDITO"
            });

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

        private void ConfigurarColumnasDetalle()
        {
            dgvDetalle.Columns.Clear();

            dgvDetalle.Columns.Add("Codigo", "Código");
            dgvDetalle.Columns.Add("Descripcion", "Descripción");
            dgvDetalle.Columns.Add("Cantidad", "Cantidad");
            dgvDetalle.Columns.Add("Precio", "Precio");
            dgvDetalle.Columns.Add("Subtotal", "Subtotal");
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

     

        private async void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                var cliente =
                    await ApiService.GetAsync<Cliente>(
                    $"Clientes/Search?cedula={txtCedulaCliente.Text.Trim()}");

                txtNombreCliente.Text = cliente.NombreCompleto;
            }
            catch
            {
                MessageBox.Show("Cliente no encontrado.");
            }
        }

        private async void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = Convert.ToInt32(txtCodigoProducto.Text);
                int cantidad = Convert.ToInt32(txtCantidad.Text);

                var producto =
                    await ApiService.GetAsync<Producto>(
                    $"Productos/Search?codigoInterno={codigo}");

                decimal subtotal = producto.PrecioVenta * cantidad;

                dgvDetalle.Rows.Add(
                    producto.CodigoInterno,
                    producto.Descripcion,
                    cantidad,
                    producto.PrecioVenta,
                    subtotal);

                CalcularTotal();
            }
            catch
            {
                MessageBox.Show("Producto inválido.");
            }
        }

        private void CalcularTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dgvDetalle.Rows)
            {
                if (row.Cells["Subtotal"].Value != null)
                {
                    total += Convert.ToDecimal(
                        row.Cells["Subtotal"].Value);
                }
            }

            lblTotal.Text = total.ToString("N2");
            lblSubtotal.Text = total.ToString("N2");
        }

        private async void btnCrearFactura_Click(object sender, EventArgs e)
        {
            try
            {
                var factura = new FacturaDTO
                {
                    CedulaCliente = txtCedulaCliente.Text.Trim(),
                    TipoPago = cmbTipoPago.Text,
                    Condicion = cmbCondicion.Text,
                    UsuarioId = 1
                };

                foreach (DataGridViewRow row in dgvDetalle.Rows)
                {
                    if (row.IsNewRow)
                        continue;

                    factura.Detalle.Add(
                        new DetalleFacturaDTO
                        {
                            CodInterno =
                                Convert.ToInt32(
                                row.Cells["Codigo"].Value),

                            Cantidad =
                                Convert.ToInt32(
                                row.Cells["Cantidad"].Value)
                        });
                }

                string resultado =
                    await ApiService.PostAsync(
                    "Facturas/CrearFactura",
                    factura);

                MessageBox.Show(resultado);

                panelDetalle.Visible = false;

                await LoadFacturas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panelDetalle.Visible = false;
        }

        private void LimpiarFormulario()
        {
            txtCedulaCliente.Clear();
            txtNombreCliente.Clear();
            txtCodigoProducto.Clear();
            txtCantidad.Clear();

            cmbTipoPago.SelectedIndex = -1;
            cmbCondicion.SelectedIndex = -1;

            dgvDetalle.Rows.Clear();

            lblSubtotal.Text = "0.00";
            lblTotal.Text = "0.00";
        }
    }


}
