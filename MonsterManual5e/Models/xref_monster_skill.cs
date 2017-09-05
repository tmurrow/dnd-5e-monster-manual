using System;
using System.Collections.Generic;

namespace MonsterManual5e.Models
{
    public partial class XrefMonsterSkill
    {
        public int MonsterId { get; set; }
        public int SkillId { get; set; }
        public int Value { get; set; }
        public string Note { get; set; }
        public virtual Monster Monster { get; set; }
        public virtual Skill Skill { get; set; }
    }
}
