using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyHobbies;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace DotNetCoreMVCOefeningenreeks1.Controllers
{
    public class BandLidController : Controller
    {
        private List<Band> bands;
  
        public BandLidController()
        {
            bands = BandInitializer.StartUp();
        }
    
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Lijst()
        {
            ViewBag.Bands = bands;
            return View();
        }

        public IActionResult Maak(string naam, int? jaar, Geslacht? geslacht, string band)
        {
            bands.Add(
                new Band() {
                    Naam = band ?? "Onbekend",
                    Leden = new List<BandLid>()
                    {
                        new BandLid() {
                            Naam = naam ?? "Onbekend",
                            Geslacht = geslacht ?? Geslacht.Man }
                    }
                });
            ViewBag.Bands = bands;
            return View("Lijst");
        }
    }
}
