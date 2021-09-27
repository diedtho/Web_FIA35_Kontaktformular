using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_FIA35_Kontaktformular.Controllers
{
    
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string inpVorname, string inpNachname, DateTime inpGeburtsdatum, string rbGeschlecht, string chbWin, string chbLinux,
            string chbIOs, string chbAndroid, string npBemerkungen)
        {
            ViewBag.Vorname = inpVorname;
            ViewBag.Nachname = inpNachname;
            ViewBag.Geburtsdatum = inpGeburtsdatum.ToShortDateString();
            ViewBag.Geschlecht = rbGeschlecht;
            ViewBag.Bemerkungen = npBemerkungen;

            List<string> betriebsSysteme = new List<string>();
            if (chbWin != null) {
                betriebsSysteme.Add("Windows");
            }
            if (chbLinux != null)
            {
                betriebsSysteme.Add("Linux");
            }
            if (chbIOs != null)
            {
                betriebsSysteme.Add("IOs");
            }
            if (chbAndroid != null)
            {
                betriebsSysteme.Add("Android");
            }
            ViewBag.ListeBetriebssysteme = betriebsSysteme;

            return View();
        }
    }
}
