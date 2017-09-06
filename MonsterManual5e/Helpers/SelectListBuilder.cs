using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MonsterManual5e.Models;
using MonsterManual5e.Repositories;

namespace MonsterManual5e.Helpers
{
    public static class SelectListBuilder
    {
        private static MonsterRepository mrepo = new MonsterRepository();

        public static IEnumerable<SelectListItem> GetLanguages()
        {
            List<SelectListItem> languageSelectList = new List<SelectListItem>();
            List<Language> languageList = mrepo.GetAllLanguages().ToList();
            foreach (Language x in languageList)
            {
                SelectListItem item = new SelectListItem { Value = x.Id.ToString(), Text = x.Name };
                languageSelectList.Add(item);
            }

            return languageSelectList;
        }

        public static IEnumerable<SelectListItem> GetSizes()
        {
            List<SelectListItem> sizeSelectList = new List<SelectListItem>();
            List<Size> sizeList = mrepo.GetAllSizes().ToList();
            foreach (Size x in sizeList)
            {
                SelectListItem item = new SelectListItem { Value = x.Id.ToString(), Text = x.Name };
                sizeSelectList.Add(item);
            }

            sizeSelectList.Insert(0, new SelectListItem { Value = "0", Text = "Select a size...", Selected = true });

            return sizeSelectList;
        }

        public static IEnumerable<SelectListItem> GetTypes()
        {
            List<SelectListItem> typeSelectList = new List<SelectListItem>();
            List<MonsterType> typeList = mrepo.GetAllTypes().ToList();
            foreach (MonsterType x in typeList)
            {
                SelectListItem item = new SelectListItem { Value = x.Id.ToString(), Text = x.Name };
                typeSelectList.Add(item);
            }

            typeSelectList.Insert(0, new SelectListItem { Value = "0", Text = "Select a type...", Selected = true });

            return typeSelectList;
        }

        public static IEnumerable<SelectListItem> GetAlignments()
        {
            List<SelectListItem> alignmentSelectList = new List<SelectListItem>();
            List<AlignmentAttitude> alignmentAttitudeList = mrepo.GetAllAlignmentAttitudes().ToList();
            List<AlignmentMorality> alignmentMoralityList = mrepo.GetAllAlignmentMoralities().ToList();
            List<Alignment> alignmentList = AlignmentBuilder.GetAllAlignments();
            alignmentList = alignmentList.OrderBy(a => a.Order).ToList();
                        
            foreach (Alignment x in alignmentList)
            {
                SelectListItem item = new SelectListItem { Value = x.Order.ToString(), Text = x.Name };
                alignmentSelectList.Add(item);
            }

            alignmentSelectList.Insert(0, new SelectListItem { Value = "0", Text = "Select an alignment...", Selected = true });

            return alignmentSelectList;
        }

        public static IEnumerable<SelectListItem> GetSenses()
        {
            List<SelectListItem> senseSelectList = new List<SelectListItem>();
            List<Sense> senseList = mrepo.GetAllSenses().ToList();
            foreach (Sense x in senseList)
            {
                SelectListItem item = new SelectListItem { Value = x.Id.ToString(), Text = x.Name };
                senseSelectList.Add(item);
            }

            return senseSelectList;
        }

        public static IEnumerable<SelectListItem> GetSkills()
        {
            List<SelectListItem> skillSelectList = new List<SelectListItem>();
            List<Skill> skillList = mrepo.GetAllSkills().ToList();
            foreach (Skill x in skillList)
            {
                SelectListItem item = new SelectListItem { Value = x.Id.ToString(), Text = x.Name };
                skillSelectList.Add(item);
            }

            return skillSelectList;
        }
    }
}