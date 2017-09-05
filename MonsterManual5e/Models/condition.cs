using System;
using System.Collections.Generic;

namespace MonsterManual5e.Models
{
    public partial class Condition
    {
        public Condition()
        {
            this.Monsters = new List<Monster>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int Order { get; set; }

        public string Note { get; set; }

        public virtual ICollection<Monster> Monsters { get; set; }

    }
}
