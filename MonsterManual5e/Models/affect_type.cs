using System;
using System.Collections.Generic;

namespace MonsterManual5e.Models
{
    public partial class AffectType
    {
        public AffectType()
        {
            this.XrefMonsterDamageType = new List<XrefMonsterDamageType>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int Order { get; set; }

        public string Note { get; set; }

        public virtual ICollection<XrefMonsterDamageType> XrefMonsterDamageType { get; set; }

    }
}
