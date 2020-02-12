using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Ejercicio2.Models;
using Ejercicio2.HelperFunctions;

namespace Ejercicio2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    
        [HttpPost]
        public IActionResult Index(NumerosViewModel model)
        {

            if (ModelState.IsValid)
            {
                return RedirectToAction("MayorMenor", model);
            }
            return View(model);
        }

        public IActionResult MayorMenor(NumerosViewModel model)
        {
            model.Mayor = Functions.ObtenerMayor(model.Numeros);
            model.Menor = Functions.ObtenerMenor(model.Numeros);
            return View(model);
        }

    }
}
