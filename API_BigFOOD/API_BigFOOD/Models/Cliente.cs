using System.Security.Principal;

namespace API_BigFOOD.Models
{
    public class Cliente
    {
        public string Cedula { get; set; }
        public string TipoCedula { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
    }
}
