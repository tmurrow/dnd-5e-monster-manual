using System;
using System.Collections.Generic;

namespace MonsterManual5e.Models
{
    public partial class XrefMonsterSpeed
    {
        public int MonsterId { get; set; }
        public int SpeedId { get; set; }
        public int Value { get; set; }
        public string Note { get; set; }
        public virtual Monster Monster { get; set; }
        public virtual Speed Speed { get; set; }
    }
}
