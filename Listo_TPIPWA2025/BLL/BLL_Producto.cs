using Listo_TPIPWA2025.Models;
namespace Listo_TPIPWA2025.BLL

{
    public class BLL_Producto
    {
        private static List<Producto> productos = new List<Producto>();

        public BLL_Producto(){}

        public void AgregarProducto(Producto producto)
        {
            if(productos.Find(x=>x.Id == producto.Id)==null)productos.Add(producto);
        }
        public List<Producto> RetornaProductos()
        {
            return productos;
        }

        public void AgregarRecetaProducto(Receta receta, int idprod)
        {
            Producto? prod = EncontrarProducto(idprod);
            if (prod != null)
            { 
                if (prod.Receta==null) prod.Receta = receta;
            }
        }

        public Producto? EncontrarProducto(int idprod)
        {
            Producto? prod = new Producto();
            prod = productos.Find(x => x.Id == idprod);
            return prod;
        }
    }    
}
