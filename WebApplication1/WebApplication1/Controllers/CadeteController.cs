using Cadeteria_2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cadeteria_2.Controllers
{
    public class CadeteController : Controller
    {
        private List<CadeteModel> cadetes = new List<CadeteModel>();
        //private helper h = new helper();
        //CadeteModel cadete;
        public IActionResult Index()
        {
            //CadeteModel cadete = new CadeteModel("Agustin", "Rojas Paz 33", "3816431774");
            return View(cadetes);
            //return View(cadete);
        }

        public IActionResult createCadete()
        {
            return View();
        }

        [HttpPost]
        public IActionResult creaCadete(string nombre, string direccion, string telefono)
        {
            //cadetes.Add(new CadeteModel(nombre, direccion, telefono));
            helper h = new helper();

            h.agregaCadeteCSV(new CadeteModel(nombre, direccion, telefono));

            cadetes = h.CadetesAlmacenados();
            //return View("Index", cadetes);
            return View("Index", cadetes);
        }
        /*
        public List<CadeteModel> getCadetes()
        {
            return this.cadetes;
        }*/
    }
}
