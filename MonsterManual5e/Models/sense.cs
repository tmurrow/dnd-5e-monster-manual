using System;
using System.Collections.Generic;

namespace MonsterManual5e.Models
{
    public partial class Sense
    {
        public Sense()
        {
            this.XrefMonsterSense = new List<XrefMonsterSense>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
        public string Note { get; set; }
        public virtual ICollection<XrefMonsterSense> XrefMonsterSense { get; set; }
    }
}
