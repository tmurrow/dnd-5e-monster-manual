using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MonsterManual5e.Models;
using MonsterManual5e.ViewModels;
using MonsterManual5e.Repositories;
using MonsterManual5e.Helpers;


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