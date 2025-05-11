using Listo_TPIPWA2025.Models;

namespace Listo_TPIPWA2025.Models
{
    public class Producto
    {
        public Producto() { }
        public Producto(Producto pProd) { Id = pProd.Id; Nombre = pProd.Nombre; ImagenUrl = pProd.ImagenUrl; Precio = pProd.Precio; PrecioDescuento = pProd.PrecioDescuento;}
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? ImagenUrl { get; set; }
        public decimal? Precio { get; set; }
        public decimal? PrecioDescuento { get; set; }
        public Receta? Receta { get; set; }


    }


    public class Receta
    {
        public Receta(List<string> pIng, List<string> pInst, string pTiem, string porc) { Ingredientes = pIng; Instrucciones = pInst; TiempoPreparacion = pTiem; Porciones = porc; }

        public Receta() { }
        public List<string>? Ingredientes { get; set; }
        public List<string>? Instrucciones { get; set; }
        public string? TiempoPreparacion { get; set; }
        public string? Porciones { get; set; }

    }


}


/*public class ProductoconDescuento: Producto
{
    public decimal PrecioDescuento { get; set; }
    public decimal MostrarPrecio()
    {
        return PrecioDescuento;
    }
}*/

