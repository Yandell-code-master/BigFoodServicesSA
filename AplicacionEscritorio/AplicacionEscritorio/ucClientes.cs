using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AplicacionEscritorio.Models;
using AplicacionEscritorio.Services;

namespace AplicacionEscritorio
{
    public partial class ucClientes : UserControl
    {
        private bool _editando;
        private bool _estadoOriginal;
        private List<Cliente> _todosClientes;

        public ucClientes()
        {
            InitializeComponent();
            txtBuscar.TextChanged += TxtBuscar_TextChanged;
        }

        private void ucClientes_Load(object sender, EventArgs e)
        {
            ConfigurarColumnas();
            btnBuscar.Visible = false;
            _ = LoadClientes();
        }

        private void ConfigurarColumnas()
        {
            dgvClientes.AutoGenerateColumns = false;
            dgvClientes.Columns.Clear();

            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CedulaLegal",
                HeaderText = "C\u00e9dula",
                Width = 140
            });
            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TipoCedula",
                HeaderText = "Tipo",
                Width = 90
            });
            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NombreCompleto",
                HeaderText = "Nombre Completo",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Email",
                HeaderText = "Email",
                Width = 200
            });

        }

        private async System.Threading.Tasks.Task LoadClientes()
        {
            try
            {
                _todosClientes = await ApiService.GetAsync<List<Cliente>>("Clientes/List");
                FiltrarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar clientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FiltrarClientes()
        {
            if (_todosClientes == null) return;
            var filtro = txtBuscar.Text.Trim();
            var activos = _todosClientes.Where(c => c.Estado);
            dgvClientes.DataSource = string.IsNullOrWhiteSpace(filtro)
                ? activos.ToList()
                : activos.Where(c => c.CedulaLegal.Contains(filtro)).ToList();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            FiltrarClientes();
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            FiltrarClientes();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _editando = false;
            LimpiarFormulario();
            panelDetalle.Visible = true;
            txtCedula.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un cliente primero.", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var c = (Cliente)dgvClientes.SelectedRows[0].DataBoundItem;
            _editando = true;
            _estadoOriginal = c.Estado;
            txtCedula.Text = c.CedulaLegal;
            txtCedula.Enabled = false;
            cmbTipoCedula.Enabled = false;
            cmbTipoCedula.SelectedItem = c.TipoCedula;
            txtNombre.ReadOnly = true;
            txtNombre.Text = c.NombreCompleto;
            txtEmail.Text = c.Email;
            panelDetalle.Visible = true;
            txtNombre.Focus();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 0) return;
            var c = (Cliente)dgvClientes.SelectedRows[0].DataBoundItem;
            var msg = $"\u00bfEliminar cliente {c.NombreCompleto}?";
            if (MessageBox.Show(msg, "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    await ApiService.DeleteAsync($"Clientes/Delete?cedula={c.CedulaLegal}");
                    await LoadClientes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private async void btnConsultarGometa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCedula.Text)) return;
            try
            {
                var c = await ApiService.GetAsync<Cliente>($"Clientes/Search?cedula={txtCedula.Text.Trim()}");
                if (c != null)
                {
                    txtNombre.Text = c.NombreCompleto;
                    cmbTipoCedula.SelectedItem = c.TipoCedula;
                }
            }
            catch
            {
                // No encontrado en BD local, se llena manual
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!Validar()) return;

            var c = new Cliente
            {
                CedulaLegal = txtCedula.Text.Trim(),
                TipoCedula = cmbTipoCedula.SelectedItem.ToString(),
                NombreCompleto = txtNombre.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Estado = _editando ? _estadoOriginal : true,
                UsuarioId = 1
            };

            try
            {
                if (_editando)
                    await ApiService.PutAsync("Clientes/Update", c);
                else
                    await ApiService.PostAsync("Clientes/Save", c);

                panelDetalle.Visible = false;
                await LoadClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panelDetalle.Visible = false;
        }

        private void LimpiarFormulario()
        {
            txtCedula.Clear();
            txtCedula.Enabled = true;
            cmbTipoCedula.Enabled = true;
            txtNombre.ReadOnly = false;
            txtNombre.Clear();
            txtEmail.Clear();
            cmbTipoCedula.SelectedIndex = -1;
        }

        private bool Validar()
        {
            if (string.IsNullOrWhiteSpace(txtCedula.Text))
            { MessageBox.Show("La c\u00e9dula es requerida."); return false; }
            if (cmbTipoCedula.SelectedItem == null)
            { MessageBox.Show("Seleccione el tipo de c\u00e9dula."); return false; }
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            { MessageBox.Show("El nombre es requerido."); return false; }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            { MessageBox.Show("El email es requerido."); return false; }
            return true;
        }
    }
}
