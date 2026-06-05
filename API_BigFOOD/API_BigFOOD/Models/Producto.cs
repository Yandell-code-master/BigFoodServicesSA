namespace API_BigFOOD.Models
{
    public class Producto
    {
        public string CodigoInterno { get; set; }
        public string CodigoBarra { get; set; }
        public string Descripcion { get; set; }
        public int PrecioCompraProveedor { get; set; }
        public int PrecioVenta { get; set; }
        public int DescuentoAplicado { get; set; }
        public int Impuesto { get; set; }
        public string UnidadMedida { get; set; }

    }
}
