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
            //vm.Languages = SelectListBuilder.GetLanguages().ToList();
            //vm.Sizes = SelectListBuilder.GetSizes().ToList();
            //vm.Types = SelectListBuilder.GetTypes().ToList();
            //vm.Alignments = SelectListBuilder.GetAlignments().ToList();
            //vm.Senses = SelectListBuilder.GetSenses().ToList();
            //vm.Skills = SelectListBuilder.GetSkills().ToList();

            return View(vm);
        }

        public ActionResult Edit(int id)
        {
            MonsterViewModel vm = new MonsterViewModel();
            vm.Monster = mrepo.GetMonsterById(id);
            vm.Languages = SelectListBuilder.GetLanguages().ToList();
            vm.Sizes = SelectListBuilder.GetSizes().ToList();
            vm.Types = SelectListBuilder.GetTypes().ToList();
            vm.Alignments = SelectListBuilder.GetAlignments().ToList();
            vm.Senses = SelectListBuilder.GetSenses().ToList();
            vm.Skills = SelectListBuilder.GetSkills().ToList();
            vm.SelectedSenses = new List<int>();
            vm.SelectedSkills = new List<int>();
            vm.SelectedSkillsBonuses = new List<int>();

            for (int i = 0; i < vm.Monster.XrefMonsterSkill.Count; i++)
            {
                vm.SelectedSkills.Add(vm.Monster.XrefMonsterSkill.ElementAt(i).SkillId);
                vm.SelectedSkillsBonuses.Add(vm.Monster.XrefMonsterSkill.ElementAt(i).Value);
            }

            for (int i = 0; i < vm.Monster.XrefMonsterSense.Count; i++)
            {
                vm.SelectedSenses.Add(vm.Monster.XrefMonsterSense.ElementAt(i).SenseId);
            }

            return View(vm);
        }

        [HttpPost]
        public ActionResult Edit(MonsterViewModel mvm)
        {

            return Info(mvm.Monster.Id);
        }

        public string GetAlignmentName(string a, string m)
        {
            return AlignmentBuilder.GetAlignment(a, m);
        }
    }
}