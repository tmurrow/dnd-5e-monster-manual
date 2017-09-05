using System;
using System.Collections.Generic;

namespace MonsterManual5e.Models
{
    public partial class Language
    {
        public Language()
        {
            this.XrefMonsterLanguage = new List<XrefMonsterLanguage>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
        public string Note { get; set; }
        public virtual ICollection<XrefMonsterLanguage> XrefMonsterLanguage { get; set; }
    }
}
