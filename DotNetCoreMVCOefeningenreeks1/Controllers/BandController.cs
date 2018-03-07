using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MyHobbies;

namespace DotNetCoreMVCOefeningenreeks1.Controllers
{
    public class BandController : Controller
    {
        private List<Band> bands;
        public BandController()
        {
            bands = BandInitializer.StartUp();
        }

        // GET: /<controller>/
        public ViewResult Index()
        {
            return View();
        }

        public ViewResult Lijst()
        {
            ViewBag.Bands = bands;
            return View();
        }

        public ViewResult LijstMetLeden()
        {
            ViewBag.Bands = bands;
            return View();
        }

        public ViewResult Maak(string naam, int? jaar)
        {
            bands.Add(new Band()
                {
                    Naam = naam ?? "Onbekend",
                    Jaar = jaar ?? DateTime.Now.Year
                });
            ViewBag.Bands = bands;
            
            return View("Lijst");
        }
    }
}
