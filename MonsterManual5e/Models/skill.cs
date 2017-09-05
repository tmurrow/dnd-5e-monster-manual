using System;
using System.Collections.Generic;

namespace MonsterManual5e.Models
{
    public partial class Skill
    {
        public Skill()
        {
            this.XrefMonsterSkill = new List<XrefMonsterSkill>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int AbilityId { get; set; }
        public int Order { get; set; }
        public string Note { get; set; }
        public virtual AbilityScore AbilityScore { get; set; }
        public virtual ICollection<XrefMonsterSkill> XrefMonsterSkill { get; set; }
    }
}
