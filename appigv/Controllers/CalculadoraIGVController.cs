using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using appigv.Models;


namespace appigv.Controllers
{
    public class CalculadoraIGVController : Controller
    {
        private readonly ILogger<CalculadoraIGVController> _logger;

        public CalculadoraIGVController(ILogger<CalculadoraIGVController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["Message"] = "";
            return View();
        }

        [HttpPost]
        public IActionResult MiMetodoExecute(CalcularIGV objCalculadora)
        {
            Double result = 0.0;
            String message ="";
            Double total =0.0;
            Double igv=1.18;

            total = objCalculadora.Precio + objCalculadora.Cantidad;
            result = total*igv;
            message ="El precio a pagar es " + total;

            
            ViewData["Message"] = message;
            return View("Index");
        }

    }
}