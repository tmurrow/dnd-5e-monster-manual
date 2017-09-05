using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonsterManual5e.Models
{
    public class Alignment
    {
        public string Name { get; set; }

        public int Order { get; set; }

        public int AttitudeId { get; set; }

        public int MoralityId { get; set; }

        public virtual AlignmentAttitude Attitude { get; set; }

        public virtual AlignmentMorality Morality { get; set; }
    }
}