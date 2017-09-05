using System;
using System.Collections.Generic;

namespace MonsterManual5e.Models
{
    public partial class XrefMonsterSense
    {
        public int MonsterId { get; set; }
        public int SenseId { get; set; }
        public int Value { get; set; }
        public string Note { get; set; }
        public virtual Monster Monster { get; set; }
        public virtual Sense Sense { get; set; }
    }
}
