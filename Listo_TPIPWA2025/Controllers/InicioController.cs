using Listo_TPIPWA2025.Models;
using Listo_TPIPWA2025.BLL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Listo_TPIPWA2025.Controllers
{
    public class InicioController : Controller
    {
        // GET: HomeController1
        public ActionResult Inicio()
        {

            BLL_Producto bllp = new BLL_Producto();
            bllp.AgregarProducto(new Producto { Id = 1, Nombre = "Risotto de hongos", ImagenUrl = "/images/productos/risotto.jpg", Precio = 3500, PrecioDescuento = 2990 });
            bllp.AgregarProducto(new Producto { Id = 2, Nombre = "Curry", ImagenUrl = "/images/productos/curry.jpg", Precio = 3200, PrecioDescuento = 2600 });
            bllp.AgregarProducto(new Producto { Id = 3, Nombre = "Ensalada César", ImagenUrl = "/images/productos/caesar.jpg", Precio = 2800, PrecioDescuento = 2500 });
            return View(bllp.RetornaProductos());
        }


        // GET: HomeController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HomeController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HomeController1/Create
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

        // GET: HomeController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HomeController1/Edit/5
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

        // GET: HomeController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HomeController1/Delete/5
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
