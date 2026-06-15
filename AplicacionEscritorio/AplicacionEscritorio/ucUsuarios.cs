using AplicacionEscritorio.DTOs;
using AplicacionEscritorio.Models;
using AplicacionEscritorio.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionEscritorio
{
    public partial class ucUsuarios : UserControl
    {
        private List<Usuario> _usuarios = new List<Usuario>();
        private const string SecurityBaseUrl = "http://Api-security.somee.com";

        public ucUsuarios()
        {
            InitializeComponent();
            txtBuscar.TextChanged += TxtBuscar_TextChanged;
        }

        private void ucUsuarios_Load(object sender, EventArgs e)
        {
            ConfigurarColumnasUsuarios();

            btnBuscar.Visible = false;
            panelDetalle.Visible = false;

            // Cambiado para que el único rol disponible sea "Cajeros"
            cmbRoll.Items.Clear();
            cmbRoll.Items.AddRange(new string[]
            {
                "Cajeros"
            });

            _ = LoadUsuarios();
        }

        private void ConfigurarColumnasUsuarios()
        {
            dgvUsuarios.AutoGenerateColumns = false;
            dgvUsuarios.Columns.Clear();

            dgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "ID",
                Width = 60
            });

            dgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Email",
                HeaderText = "Correo Electrónico",
                Width = 220
            });

            dgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Date",
                HeaderText = "Fecha Registro",
                Width = 140
            });

            dgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Roll",
                HeaderText = "Rol de Usuario",
                Width = 130
            });

            dgvUsuarios.Columns.Add(new DataGridViewCheckBoxColumn
            {
                DataPropertyName = "Status",
                HeaderText = "Activo",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
        }

        protected override async void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (this.Visible)
            {
                await LoadUsuarios();
            }
        }

        private async Task LoadUsuarios()
        {
            try
            {
                string urlOriginal = ApiService.BaseUrl;
                ApiService.BaseUrl = SecurityBaseUrl;

                _usuarios = await ApiService.GetAsync<List<Usuario>>("api/Usuario");

                ApiService.BaseUrl = urlOriginal;
                FiltrarUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuarios de seguridad: " + ex.Message);
            }
        }

        private void FiltrarUsuarios()
        {
            string filtro = txtBuscar.Text.Trim().ToLower();

            dgvUsuarios.DataSource = string.IsNullOrWhiteSpace(filtro)
                ? _usuarios
                : _usuarios.Where(u =>
                    u.Email.ToLower().Contains(filtro) ||
                    u.Roll.ToLower().Contains(filtro))
                .ToList();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            FiltrarUsuarios();
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            panelDetalle.Visible = true;
            txtEmail.Focus();
        }

        private async void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                cmbRoll.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                return;
            }

            try
            {
                var nuevoUsuario = new UsuarioDTO
                {
                    Email = txtEmail.Text.Trim(),
                    Password = txtPassword.Text.Trim(),
                    Roll = cmbRoll.Text,
                    Status = chkStatus.Checked
                };

                string urlOriginal = ApiService.BaseUrl;
                ApiService.BaseUrl = SecurityBaseUrl;

                string resultado = await ApiService.PostAsync("api/Usuario", nuevoUsuario);

                ApiService.BaseUrl = urlOriginal;

                MessageBox.Show("Usuario registrado con éxito.");

                panelDetalle.Visible = false;
                await LoadUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar usuario: " + ex.Message);
            }
        }

        // NUEVO MÉTODO: Elimina validando que no quede el sistema vacío (Mínimo 1)
        private async void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show("Por favor, seleccione un usuario de la lista para eliminar.");
                return;
            }

            // Validación crucial del conteo total en la base/lista local
            if (_usuarios.Count <= 1)
            {
                MessageBox.Show("Acción denegada: No se puede eliminar el usuario debido a que es el único registrado en el sistema.",
                                "Validación de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var usuarioSeleccionado = (Usuario)dgvUsuarios.CurrentRow.DataBoundItem;

            var confirmacion = MessageBox.Show($"¿Está seguro de que desea eliminar al usuario {usuarioSeleccionado.Email}?",
                                               "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    string urlOriginal = ApiService.BaseUrl;
                    ApiService.BaseUrl = SecurityBaseUrl;

                    // Asume que la API acepta DELETE en la ruta: api/Usuario/{id}
                    await ApiService.DeleteAsync($"api/Usuario/{usuarioSeleccionado.Id}");

                    ApiService.BaseUrl = urlOriginal;

                    MessageBox.Show("Usuario eliminado correctamente.");
                    await LoadUsuarios();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar eliminar el usuario: " + ex.Message);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panelDetalle.Visible = false;
        }

        private void LimpiarFormulario()
        {
            txtEmail.Clear();
            txtPassword.Clear();
            // Hace que por defecto ya quede seleccionado el rol "Cajeros" (índice 0)
            cmbRoll.SelectedIndex = 0;
            chkStatus.Checked = true;
        }
    }
}