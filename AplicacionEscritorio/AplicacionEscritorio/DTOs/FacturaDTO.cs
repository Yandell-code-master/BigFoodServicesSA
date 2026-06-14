using System.Collections.Generic;

public class FacturaDTO
{
    public string CedulaCliente { get; set; }
    public string TipoPago { get; set; }
    public string Condicion { get; set; }
    public int UsuarioId { get; set; }

    public List<DetalleFacturaDTO> Detalle { get; set; }
        = new List<DetalleFacturaDTO>();
}