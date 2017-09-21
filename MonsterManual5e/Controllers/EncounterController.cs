using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MonsterManual5e.Views.Encounter
{
    public class EncounterController : Controller
    {
        // GET: Encounter
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddToEncounter() //int id)
        {
            return View();
        }

        public ActionResult AddToDifficultyCalculator() //int id)
        {
            return View();
        }
    }
}