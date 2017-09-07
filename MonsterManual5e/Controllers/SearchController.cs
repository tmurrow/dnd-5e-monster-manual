using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MonsterManual5e.Models;
using MonsterManual5e.ViewModels;
using MonsterManual5e.Repositories;

namespace MonsterManual5e.Controllers
{
    public class SearchController : Controller
    {
        MonsterRepository mrepo = new MonsterRepository();
        // GET: Search
        public ActionResult Index()
        {
            SearchViewModel vm = new SearchViewModel();
            vm.Monsters = mrepo.GetAllMonsters().ToList();
            return View(vm);
        }

        [HttpPost]
        public ActionResult Search(string name)
        {
            SearchViewModel vm = new SearchViewModel();
            vm.Monsters = mrepo.GetAllMonsters().ToList();
            vm.Monsters = vm.Monsters.Where(m => m.Name.StartsWith(name)).ToList();

            if (Request.IsAjaxRequest())
            {
                return PartialView("_Results", vm);
            }

            return View("Index", vm);
        }
    }
}