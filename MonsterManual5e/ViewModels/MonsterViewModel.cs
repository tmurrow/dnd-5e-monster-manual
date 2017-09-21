using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MonsterManual5e.Models;

namespace MonsterManual5e.ViewModels
{
    public class MonsterViewModel
    {
        public Monster Monster { get; set; }

        public ICollection<SelectListItem> AffectTypes { get; set; }

        public ICollection<SelectListItem> Alignments { get; set; }

        public ICollection<SelectListItem> Conditions { get; set; }

        public ICollection<SelectListItem> DamageTypes { get; set; }

        public ICollection<SelectListItem> InfoTypes { get; set; }

        public ICollection<SelectListItem> Languages { get; set; }

        public ICollection<SelectListItem> Senses { get; set; }

        public ICollection<SelectListItem> Sizes { get; set; }

        public ICollection<SelectListItem> Skills { get; set; }

        public ICollection<SelectListItem> Speeds { get; set; }

        public ICollection<SelectListItem> Tags { get; set; }

        public ICollection<SelectListItem> Types { get; set; }

        public ICollection<int> SelectedSenses { get; set; }

        public ICollection<int> SelectedSkills { get; set; }

        public ICollection<int> SelectedLanguages { get; set; }

        public ICollection<int> SelectedSkillsBonuses { get; set; }

        //public ICollection<int> SelectedAffectTypes { get; set; }

        //public ICollection<int> SelectedConditions { get; set; }

        //public ICollection<int> SelectedDamageTypes { get; set; }

        //public ICollection<int> SelectedInfoTypes { get; set; }
        
        //public ICollection<int> SelectedSpeeds { get; set; }

        //public ICollection<int> SelectedTags { get; set; }
    }
}