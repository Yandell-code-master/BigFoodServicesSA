using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using AplicacionEscritorio.Models;
using AplicacionEscritorio.Services;

namespace AplicacionEscritorio
{
    public partial class ucCrearFactura : UserControl
    {
        public ucCrearFactura()
        {
            InitializeComponent();
        }

        private void ucCrearFactura_Load(object sender, EventArgs e)
        {
            ConfigurarColumnasDetalle();
            LimpiarFormulario();

            cmbTipoPago.Items.AddRange(new string[] { "EFECTIVO", "TARJETA", "SINPE MOVIL" });
            cmbCondicion.Items.AddRange(new string[] { "CONTADO", "CREDITO" });
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

        private async void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                var cliente = await ApiService.GetAsync<Cliente>($"Clientes/Search?cedula={txtCedulaCliente.Text.Trim()}");
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

                var producto = await ApiService.GetAsync<Producto>($"Productos/Search?codigoInterno={codigo}");
                decimal subtotal = producto.PrecioVenta * cantidad;

                dgvDetalle.Rows.Add(producto.CodigoInterno, producto.Descripcion, cantidad, producto.PrecioVenta, subtotal);
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
                    total += Convert.ToDecimal(row.Cells["Subtotal"].Value);
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
                    if (row.IsNewRow) continue;

                    factura.Detalle.Add(new DetalleFacturaDTO
                    {
                        CodInterno = Convert.ToInt32(row.Cells["Codigo"].Value),
                        Cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value)
                    });
                }

                string resultado = await ApiService.PostAsync("Facturas/CrearFactura", factura);
                MessageBox.Show(resultado);
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
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