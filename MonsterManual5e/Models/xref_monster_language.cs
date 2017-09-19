using System;
using System.Collections.Generic;

namespace MonsterManual5e.Models
{
    public partial class XrefMonsterLanguage
    {
        public int MonsterId { get; set; }

        public int LanguageId { get; set; }

        public sbyte Speak { get; set; }

        public sbyte CommandsOnly { get; set; }

        public string Note { get; set; }

        public virtual Language Language { get; set; }

        public virtual Monster Monster { get; set; }

    }
}
