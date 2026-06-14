using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionEscritorio.Models
{
    internal class Factura
    {
        public int Numero { get; set; }
        public DateTime Fecha { get; set; }
        public string CedulaCliente { get; set; }
        public decimal Subtotal { get; set; }
        public decimal MontoDescuento { get; set; }
        public decimal MontoImpuesto { get; set; }
        public decimal Total { get; set; }
        public string Estado { get; set; } = string.Empty;
        public int UsuarioId { get; set; }
        public string TipoPago { get; set; } = string.Empty;
        public string Condicion { get; set; } = string.Empty;
    }
}
