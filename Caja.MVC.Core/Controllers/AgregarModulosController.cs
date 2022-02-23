using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Caja.MVC.Core.Controllers
{
    public class AgregarModulosController : Controller
    {
        // GET: AgregarModulosController
        public ActionResult Index()
        {
            return View();
        }

        // GET: AgregarModulosController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AgregarModulosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AgregarModulosController/Create
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

        // GET: AgregarModulosController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AgregarModulosController/Edit/5
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

        // GET: AgregarModulosController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AgregarModulosController/Delete/5
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
