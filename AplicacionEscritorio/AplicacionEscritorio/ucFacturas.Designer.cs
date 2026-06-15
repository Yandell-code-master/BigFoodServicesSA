using System.Drawing;
using System.Windows.Forms;

namespace AplicacionEscritorio
{
    partial class ucFacturas
    {
        private System.ComponentModel.IContainer components = null;


    protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAnularFactura = new System.Windows.Forms.Button();
            this.btnPagarCuenta = new System.Windows.Forms.Button();
            this.dgvFacturas = new System.Windows.Forms.DataGridView();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Controls.Add(this.txtBuscar);
            this.panelTop.Controls.Add(this.btnBuscar);
            this.panelTop.Controls.Add(this.btnAnularFactura);
            this.panelTop.Controls.Add(this.btnPagarCuenta);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1216, 50);
            this.panelTop.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(225)))), ((int)(((byte)(208)))));
            this.lblTitle.Location = new System.Drawing.Point(16, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(180, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "🧾  Facturas";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(225)))), ((int)(((byte)(208)))));
            this.txtBuscar.Location = new System.Drawing.Point(200, 12);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(180, 27);
            this.txtBuscar.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(225)))), ((int)(((byte)(208)))));
            this.btnBuscar.Location = new System.Drawing.Point(386, 11);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(36, 28);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "🔍";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnAnularFactura
            // 
            this.btnAnularFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnAnularFactura.FlatAppearance.BorderSize = 0;
            this.btnAnularFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnularFactura.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAnularFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(225)))), ((int)(((byte)(208)))));
            this.btnAnularFactura.Location = new System.Drawing.Point(550, 10);
            this.btnAnularFactura.Name = "btnAnularFactura";
            this.btnAnularFactura.Size = new System.Drawing.Size(95, 30);
            this.btnAnularFactura.TabIndex = 4;
            this.btnAnularFactura.Text = "❌ Anular";
            this.btnAnularFactura.UseVisualStyleBackColor = false;
            this.btnAnularFactura.Click += new System.EventHandler(this.btnAnularFactura_Click);
            // 
            // btnPagarCuenta
            // 
            this.btnPagarCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnPagarCuenta.FlatAppearance.BorderSize = 0;
            this.btnPagarCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagarCuenta.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPagarCuenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(225)))), ((int)(((byte)(208)))));
            this.btnPagarCuenta.Location = new System.Drawing.Point(655, 10);
            this.btnPagarCuenta.Name = "btnPagarCuenta";
            this.btnPagarCuenta.Size = new System.Drawing.Size(95, 30);
            this.btnPagarCuenta.TabIndex = 5;
            this.btnPagarCuenta.Text = "💰 Pagar";
            this.btnPagarCuenta.UseVisualStyleBackColor = false;
            this.btnPagarCuenta.Click += new System.EventHandler(this.btnPagarCuenta_Click);
            // 
            // dgvFacturas
            // 
            this.dgvFacturas.AllowUserToAddRows = false;
            this.dgvFacturas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.dgvFacturas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFacturas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dgvFacturas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFacturas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(197)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFacturas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFacturas.ColumnHeadersHeight = 36;
            this.dgvFacturas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFacturas.EnableHeadersVisualStyles = false;
            this.dgvFacturas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.dgvFacturas.Location = new System.Drawing.Point(0, 50);
            this.dgvFacturas.MultiSelect = false;
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.ReadOnly = true;
            this.dgvFacturas.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(225)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dgvFacturas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFacturas.RowTemplate.Height = 32;
            this.dgvFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFacturas.Size = new System.Drawing.Size(1216, 637);
            this.dgvFacturas.TabIndex = 0;
            // 
            // ucFacturas
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Controls.Add(this.dgvFacturas);
            this.Controls.Add(this.panelTop);
            this.Name = "ucFacturas";
            this.Size = new System.Drawing.Size(1216, 687);
            this.Load += new System.EventHandler(this.ucFacturas_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            this.ResumeLayout(false);

        }

        private Panel panelTop;
        private Label lblTitle;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private Button btnAnularFactura;
        private Button btnPagarCuenta;

        private DataGridView dgvFacturas;
    }

}
