using System;
using System.Collections.Generic;

namespace MonsterManual5e.Models
{
    public partial class DamageType
    {
        public DamageType()
        {
            this.XrefMonsterDamageType = new List<XrefMonsterDamageType>();
            this.Monsters = new List<Monster>();
            this.Monsters1 = new List<Monster>();
            this.Monsters2 = new List<Monster>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int Order { get; set; }

        public string Note { get; set; }

        public virtual ICollection<XrefMonsterDamageType> XrefMonsterDamageType { get; set; }

        public virtual ICollection<Monster> Monsters { get; set; }

        public virtual ICollection<Monster> Monsters1 { get; set; }

        public virtual ICollection<Monster> Monsters2 { get; set; }

    }
}
