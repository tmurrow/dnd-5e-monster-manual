using System;
using System.Collections.Generic;

namespace MonsterManual5e.Models
{
    public partial class AbilityScore
    {
        public AbilityScore()
        {
            this.Skills = new List<Skill>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public int Order { get; set; }
        public string Note { get; set; }
        public virtual ICollection<Skill> Skills { get; set; }
    }
}
