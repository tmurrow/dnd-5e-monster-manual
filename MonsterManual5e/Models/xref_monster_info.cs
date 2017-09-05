using System;
using System.Collections.Generic;

namespace MonsterManual5e.Models
{
    public partial class XrefMonsterInfo
    {
        public int MonsterId { get; set; }

        public int InfoTypeId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public virtual InfoType InfoType { get; set; }

        public virtual Monster Monster { get; set; }

    }
}
