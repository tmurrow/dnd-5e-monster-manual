using System;
using System.Collections.Generic;

namespace MonsterManual5e.Models
{
    public partial class XrefMonsterDamageType
    {
        public int MonsterId { get; set; }

        public int DamageTypeId { get; set; }

        public int AffectTypeId { get; set; }

        public string Note { get; set; }

        public virtual AffectType AffectType { get; set; }

        public virtual DamageType DamageType { get; set; }

        public virtual Monster Monster { get; set; }

    }
}
