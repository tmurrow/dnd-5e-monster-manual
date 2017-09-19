using System;
using System.Collections.Generic;

namespace MonsterManual5e.Models
{
    public partial class Source
    {
        public Source()
        {
            this.Monsters = new List<Monster>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Abbreviation { get; set; }

        public virtual ICollection<Monster> Monsters { get; set; }

    }
}
