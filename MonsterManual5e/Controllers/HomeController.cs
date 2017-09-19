using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MonsterManual5e.Models;
using MonsterManual5e.ViewModels;
using MonsterManual5e.Repositories;
using MonsterManual5e.Helpers;

namespace MonsterManual5e.Controllers
{
    public class HomeController : Controller
    {
        MonsterRepository mrepo = new MonsterRepository();

        public ActionResult Index()
        {
            ListViewModel vm = new ListViewModel();
            vm.Monsters = mrepo.GetAllMonsters().ToList();
            vm.Sizes = SelectListBuilder.GetSizesMulti().ToList();
            vm.Types = SelectListBuilder.GetTypes().ToList();
            return View(vm);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}