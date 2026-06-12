using System;

namespace AplicacionEscritorio.Models
{
    public class Cliente
    {
        public string CedulaLegal { get; set; }
        public string TipoCedula { get; set; }
        public string NombreCompleto { get; set; }
        public string Email { get; set; }
        public DateTime FechaRegistro { get; set; }
        public bool Estado { get; set; }
        public int UsuarioId { get; set; }
    }
}
