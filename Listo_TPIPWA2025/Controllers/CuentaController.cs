using Listo_TPIPWA2025.BLL;
using Listo_TPIPWA2025.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Listo_TPIPWA2025.Controllers
{
    public class CuentaController : Controller
    {
        // GET: HomeController1

        BLL_Usuario bllu = new BLL_Usuario();
        public ActionResult Login()
        {
            return View();
        }

        // GET: HomeController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HomeController1/Create
        public ActionResult Registro()
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

        [HttpPost]
        public IActionResult Registro(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                if (ModelState.IsValid)
                {
                    if (usuario.Apellido==null)
                    {
                        TempData["AlertType"] = "danger"; // success, warning, info, danger
                        TempData["AlertMessage"] = "El apellido es obligatorio.";
                        return RedirectToAction("Registro");
                    }
                    if (usuario.Nombre==null)
                    {
                        TempData["AlertType"] = "danger";
                        TempData["AlertMessage"] = "El nombre es obligatorio.";
                        return RedirectToAction("Registro");
                    }
                    if (usuario.Email==null)
                    {
                        TempData["AlertType"] = "danger";
                        TempData["AlertMessage"] = "El email es obligatorio.";
                        return RedirectToAction("Registro");
                    }
                    usuario.Id = new Random().Next(1, 10000);
                    bllu.AgregarUsuario(usuario);
                    TempData["Toast"] = $"¡Bienvenido/a, {usuario.Nombre}!";

                    return RedirectToAction("Inicio", "Inicio");

                }
                else { return RedirectToAction("Login"); }
            }

            return View(usuario);
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
