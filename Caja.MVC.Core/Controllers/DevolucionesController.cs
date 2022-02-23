using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Caja.MVC.Core.Controllers
{
    public class DevolucionesController : Controller
    {
        // GET: DevolucionesController
        public ActionResult Index()
        {
            return View();
        }

        // GET: DevolucionesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DevolucionesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DevolucionesController/Create
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

        // GET: DevolucionesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DevolucionesController/Edit/5
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

        // GET: DevolucionesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DevolucionesController/Delete/5
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
