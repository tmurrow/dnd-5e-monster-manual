using System;
using System.Collections.Generic;

namespace MonsterManual5e.Models
{
    public partial class InfoType
    {
        public InfoType()
        {
            this.XrefMonsterInfo = new List<XrefMonsterInfo>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int Order { get; set; }

        public string Note { get; set; }

        public virtual ICollection<XrefMonsterInfo> XrefMonsterInfo { get; set; }

    }
}
