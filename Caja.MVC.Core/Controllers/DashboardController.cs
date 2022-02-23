using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AspStudio.Models;
using Microsoft.AspNetCore.Http;
using Caja.MVC.Core.App;
using Caja.MVC.Core.Negocio;
using Microsoft.Extensions.Configuration;
using Caja.MVC.Core.Models;

namespace AspStudio.Controllers
{
    public class DashboardController : Controller
    {
        public IConfiguration Configuration { get; }
        readonly NegocioConceptoGasto negocio;

        public DashboardController(IConfiguration configuration)
        {
            Configuration = configuration;
            negocio = new NegocioConceptoGasto(configuration);
        }

        public IActionResult Index()
        {
            if (HttpContext.Session.GetString(General.KeyUsuarioSesion) == null)
            {
                return RedirectToAction("Login", "Pages");
            }


            IEnumerable<ConceptoGastoModel> modelo = negocio.Consultar();
            return View(modelo);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
