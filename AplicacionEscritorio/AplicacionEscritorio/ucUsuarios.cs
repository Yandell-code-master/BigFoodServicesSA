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

            cmbRoll.Items.AddRange(new string[]
            {
                "Cliente",
                "Admin"
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panelDetalle.Visible = false;
        }

        private void LimpiarFormulario()
        {
            txtEmail.Clear();
            txtPassword.Clear();
            cmbRoll.SelectedIndex = -1;
            chkStatus.Checked = true;
        }
    }
}