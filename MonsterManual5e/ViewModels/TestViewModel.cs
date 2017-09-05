using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MonsterManual5e.Models;

namespace MonsterManual5e.ViewModels
{
    public class TestViewModel
    {
        public ICollection<AbilityScore> AbilityScores { get; set; }

        public ICollection<AffectType> AffectTypes { get; set; }

        public ICollection<AlignmentAttitude> AlignmentAttitudes { get; set; }

        public ICollection<AlignmentMorality> AlignmentMoralities { get; set; }

        public ICollection<DamageType> DamageTypes { get; set; }

        public ICollection<InfoType> InfoTypes { get; set; }

        public ICollection<Language> Languages { get; set; }

        public ICollection<Sense> Senses { get; set; }

        public ICollection<Size> Sizes { get; set; }

        public ICollection<Skill> Skills { get; set; }

        public ICollection<Speed> Speeds { get; set; }

        public ICollection<MonsterType> Types { get; set; }
    }
}