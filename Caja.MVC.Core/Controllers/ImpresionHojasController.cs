using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Caja.MVC.Core.Controllers
{
    public class ImpresionHojasController : Controller
    {
        // GET: ImpresionHojasController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ImpresionHojasController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ImpresionHojasController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ImpresionHojasController/Create
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

        // GET: ImpresionHojasController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ImpresionHojasController/Edit/5
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

        // GET: ImpresionHojasController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ImpresionHojasController/Delete/5
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
