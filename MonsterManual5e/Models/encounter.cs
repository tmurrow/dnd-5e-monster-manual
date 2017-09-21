using System;
using System.Collections.Generic;

namespace MonsterManual5e.Models
{
    public partial class Encounter
    {
        public Encounter()
        {
            this.Monsters = new List<Monster>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int Experience { get; set; }

        public int DifficultyXp { get; set; }

        public virtual ICollection<Monster> Monsters { get; set; }

    }
}
