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
        private EncounterRepository encounterRepo = new EncounterRepository();

        // GET: Encounter
        public ActionResult Index()
        {
            return View();
        }

        public void AddToEncounter(int monsterID, string encounterID)
        {
            encounterRepo.AddMonsterToEncounter(monsterID, Convert.ToInt32(encounterID));
        }
    }
}