namespace Listo_TPIPWA2025.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? ImagenUrl { get; set; }
        public decimal Precio { get; set; }
        public decimal? PrecioDescuento { get; set; }
    }
}
