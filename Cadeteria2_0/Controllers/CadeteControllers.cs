using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Cadeteria2_0.Models;

namespace Cadeteria2_0.Controllers
{
    public class CadeteControllers : Controller
    {
        private readonly ILogger<CadeteControllers> _logger;

        public CadeteControllers(ILogger<CadeteControllers> logger)
        {
            _logger = logger;
        }

        public IActionResult ListaCadetes()
        {
            CadeteModel cadete = new CadeteModel("Lautaro", "La rioja 666", "3815478543");
            return View(cadete);
        }
    }
}