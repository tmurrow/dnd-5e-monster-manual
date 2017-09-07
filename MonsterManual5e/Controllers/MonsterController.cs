﻿using System;
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
    public class MonsterController : Controller
    {
        private MonsterRepository mrepo = new MonsterRepository();

        // GET: Monster
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            MonsterViewModel vm = new MonsterViewModel();
            vm.Monster = new Monster();
            vm.Languages = SelectListBuilder.GetLanguages().ToList();
            vm.Sizes = SelectListBuilder.GetSizes().ToList();
            vm.Types = SelectListBuilder.GetTypes().ToList();
            vm.Alignments = SelectListBuilder.GetAlignments().ToList();
            vm.Senses = SelectListBuilder.GetSenses().ToList();
            vm.Skills = SelectListBuilder.GetSkills().ToList();

            return View(vm);
        }

        public ActionResult Info(int id)
        {
            MonsterViewModel vm = new MonsterViewModel();
            vm.Monster = mrepo.GetMonsterById(id);
            vm.Languages = SelectListBuilder.GetLanguages().ToList();
            vm.Sizes = SelectListBuilder.GetSizes().ToList();
            vm.Types = SelectListBuilder.GetTypes().ToList();
            vm.Alignments = SelectListBuilder.GetAlignments().ToList();
            vm.Senses = SelectListBuilder.GetSenses().ToList();
            vm.Skills = SelectListBuilder.GetSkills().ToList();

            return View(vm);
        }

        public string GetAlignmentName(string a, string m)
        {
            return AlignmentBuilder.GetAlignment(a, m);
        }
    }
}