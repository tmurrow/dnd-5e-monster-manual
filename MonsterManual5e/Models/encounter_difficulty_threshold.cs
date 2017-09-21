using System;
using System.Collections.Generic;

namespace MonsterManual5e.Models
{
    public partial class EncounterDifficultyThreshold
    {
        public int Id { get; set; }

        public int Easy { get; set; }

        public int Medium { get; set; }

        public int Hard { get; set; }

        public int Deadly { get; set; }

    }
}
