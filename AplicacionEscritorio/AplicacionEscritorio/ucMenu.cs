using AplicacionEscritorio.Models;
using AplicacionEscritorio.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionEscritorio
{
    public partial class ucMenu : UserControl
    {
        private bool editando = false;
        private Producto productoSeleccionado = null;

        public ucMenu()
        {
            InitializeComponent();

            btnBuscar.Click += btnBuscar_Click;
            btnNuevo.Click += btnNuevo_Click;
            btnEditar.Click += btnEditar_Click;
            btnEliminar.Click += btnEliminar_Click;
            btnGuardar.Click += btnGuardar_Click;
            btnCancelar.Click += btnCancelar_Click;

            this.Load += ucMenu_Load;
        }

        private async void ucMenu_Load(object sender, EventArgs e)
        {
            panelDetalle.Visible = false;

            ConfigurarColumnasProductos();

            await CargarProductos();
        }

        private async Task CargarProductos()
        {
            try
            {
                var lista = await ApiService.GetAsync<List<Producto>>(
                    "Productos/List");

                dgvProductos.DataSource = null;
                dgvProductos.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar productos.\n\n" + ex.Message);
            }
        }


        private void ConfigurarColumnasProductos()
        {
            dgvProductos.AutoGenerateColumns = false;
            dgvProductos.Columns.Clear();

            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CodigoInterno",
                HeaderText = "Código",
                Width = 80
            });

            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CodigoBarra",
                HeaderText = "Código Barra",
                Width = 130
            });

            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Descripcion",
                HeaderText = "Descripción",
                Width = 220
            });

            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PrecioVenta",
                HeaderText = "Precio Venta",
                Width = 110,
                DefaultCellStyle =
        {
            Format = "N2"
        }
            });

            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Descuento",
                HeaderText = "Desc %",
                Width = 80
            });

            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Impuesto",
                HeaderText = "Imp %",
                Width = 80
            });

            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "UnidadMedida",
                HeaderText = "Unidad",
                Width = 90
            });

            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PrecioCompra",
                HeaderText = "Precio Compra",
                Width = 110,
                DefaultCellStyle =
        {
            Format = "N2"
        }
            });

            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Existencia",
                HeaderText = "Stock",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
        }
        private void LimpiarFormulario()
        {
            txtCodigoBarra.Clear();
            txtDescripcion.Clear();
            txtPrecioVenta.Clear();
            txtDescuento.Clear();
            txtImpuesto.Clear();
            txtUnidadMedida.Clear();
            txtPrecioCompra.Clear();
            txtExistencia.Clear();

            productoSeleccionado = null;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            editando = false;

            LimpiarFormulario();

            panelDetalle.Visible = true;
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtBuscar.Text))
                {
                    await CargarProductos();
                    return;
                }

                int codigo;

                if (!int.TryParse(txtBuscar.Text.Trim(), out codigo))
                {
                    MessageBox.Show(
                        "Ingrese un código interno válido.");
                    return;
                }

                var producto =
                    await ApiService.GetAsync<Producto>(
                        $"Productos/Search?codigoInterno={codigo}");

                dgvProductos.DataSource = null;
                dgvProductos.DataSource =
                    new List<Producto> { producto };
            }
            catch
            {
                MessageBox.Show("Producto no encontrado.");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow == null)
                return;

            productoSeleccionado =
                dgvProductos.CurrentRow.DataBoundItem as Producto;

            if (productoSeleccionado == null)
                return;

            editando = true;

            txtCodigoBarra.Text =
                productoSeleccionado.CodigoBarra;

            txtDescripcion.Text =
                productoSeleccionado.Descripcion;

            txtPrecioVenta.Text =
                productoSeleccionado.PrecioVenta.ToString();

            txtDescuento.Text =
                productoSeleccionado.Descuento.ToString();

            txtImpuesto.Text =
                productoSeleccionado.Impuesto.ToString();

            txtUnidadMedida.Text =
                productoSeleccionado.UnidadMedida;

            txtPrecioCompra.Text =
                productoSeleccionado.PrecioCompra.ToString();

            txtExistencia.Text =
                productoSeleccionado.Existencia.ToString();

            panelDetalle.Visible = true;
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProductos.CurrentRow == null)
                {
                    MessageBox.Show(
                        "Seleccione un producto.");
                    return;
                }

                Producto producto =
                    dgvProductos.CurrentRow.DataBoundItem as Producto;

                if (producto == null)
                    return;

                DialogResult respuesta =
                    MessageBox.Show(
                        $"¿Eliminar {producto.Descripcion}?",
                        "Confirmar",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                if (respuesta != DialogResult.Yes)
                    return;

                string resultado =
                    await ApiService.DeleteAsync(
                        $"Productos/Delete?codigoInterno={producto.CodigoInterno}");

                MessageBox.Show(resultado);

                await CargarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Producto producto;

                if (editando)
                {
                    producto = productoSeleccionado;
                }
                else
                {
                    producto = new Producto();
                }

                producto.CodigoBarra =
                    txtCodigoBarra.Text.Trim();

                producto.Descripcion =
                    txtDescripcion.Text.Trim();

                producto.PrecioVenta =
                    Convert.ToDecimal(txtPrecioVenta.Text);

                producto.Descuento =
                    Convert.ToDecimal(txtDescuento.Text);

                producto.Impuesto =
                    Convert.ToDecimal(txtImpuesto.Text);

                producto.UnidadMedida =
                    txtUnidadMedida.Text.Trim();

                producto.PrecioCompra =
                    Convert.ToDecimal(txtPrecioCompra.Text);

                producto.Existencia =
                    Convert.ToInt32(txtExistencia.Text);

                producto.UsuarioId = 1;

                string resultado;

                if (editando)
                {
                    resultado =
                        await ApiService.PutAsync(
                            "Productos/Update",
                            producto);
                }
                else
                {
                    resultado =
                        await ApiService.PostAsync(
                            "Productos/Save",
                            producto);
                }

                MessageBox.Show(resultado);

                panelDetalle.Visible = false;

                LimpiarFormulario();

                await CargarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al guardar.\n\n" + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panelDetalle.Visible = false;

            LimpiarFormulario();
        }
    }
}