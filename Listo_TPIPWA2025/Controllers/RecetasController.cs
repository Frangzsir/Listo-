using Listo_TPIPWA2025.Models;
using Listo_TPIPWA2025.BLL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Listo_TPIPWA2025.Controllers
{
    public class RecetasController : Controller
    {
        // GET: RecetasController

        BLL_Producto bllp = new BLL_Producto();
        public ActionResult Recetas()
        {
           
            bllp.AgregarProducto(new Producto { Id = 4, Nombre = "Shoyu Ramen", ImagenUrl = "/images/productos/sramen.jpg", Precio = 3400 });
            bllp.AgregarProducto(new Producto { Id = 5, Nombre = "Bife de chorizo", ImagenUrl = "/images/productos/bchorizo.jpg", Precio = 3700 });
            bllp.AgregarProducto(new Producto { Id = 6, Nombre = "Pollo a la mostaza", ImagenUrl = "/images/productos/pollomostaza.jpg", Precio = 3300 });
            return View(bllp.RetornaProductos());
        }

        //Hardcodear recetas
        public void AgregarRecetas()
        {
            //Risotto de hongos
            Receta rece = new Receta(new List<string> { "250 gramos de arroz Arborio", "Caldo de verduras", "450 gramos de hongos portobello o champiñones", "1 cebolla mediana", "2 dientes de ajo", "Caldo de verduras", "100 ml de vino blanco seco", "80 gramos de manteca", "50 gtamos de queso parmesano rallado" },
    new List<string> { "En una sartén grande, calentá el aceite de oliva a fuego medio y añadí la cebolla y el ajo. Cociná hasta que estén transparentes.",
                "Agregá los hongos y salteá hasta que estén dorados y hayan soltado su líquido",
                "Añadí el arroz y mezclá bien, permitiendo que se toste ligeramente durante unos 2 minutos.",
                "Vertí el vino blanco y cocina hasta que se haya evaporado casi por completo.",
                "Comenzá a añadir el caldo caliente, una cucharada a la vez, removiendo constantemente y esperando a que el arroz absorba el líquido antes de agregar más.",
                "Continuá este proceso durante unos 18-20 minutos, hasta que el arroz esté al dente y tenga una textura cremosa.",
                "Retirá la sartén del fuego y añade la mantequilla y el queso parmesano, mezclando bien hasta que se fundan y se integren completamente.",
                "Ajustá la sal y la pimienta al gusto.",
                "Serví el risotto inmediatamente, decorado con perejil fresco picado si lo deseás."},
    "25'", "2"
);
            bllp.AgregarRecetaProducto(rece, 1);

        }

        // GET: RecetasController/Details/5
        public ActionResult Ingredientes(int id)
        {
            AgregarRecetas();
            Producto? prod = new Producto();
            prod =bllp.EncontrarProducto(id);
            return View(prod);
        }

        // GET: RecetasController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RecetasController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RecetasController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RecetasController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RecetasController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RecetasController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
