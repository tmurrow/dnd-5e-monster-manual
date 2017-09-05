using System;
using System.Collections.Generic;

namespace MonsterManual5e.Models
{
    public partial class Speed
    {
        public Speed()
        {
            this.XrefMonsterSpeed = new List<XrefMonsterSpeed>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
        public string Note { get; set; }
        public virtual ICollection<XrefMonsterSpeed> XrefMonsterSpeed { get; set; }
    }
}
