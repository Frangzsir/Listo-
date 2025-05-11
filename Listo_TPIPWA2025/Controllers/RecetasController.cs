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

        // GET: RecetasController/Details/5
        public ActionResult Ingredientes(int id)
        {
            //List<Producto> lp = bllp.RetornaProductos();
            Receta rece = new Receta();
            bllp.AgregarRecetaProducto(new Receta { },id);
            return View();
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
