using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using MonsterManual5e.Helpers;

namespace MonsterManual5e.Models
{
    public partial class Monster
    {
        public Monster()
        {
            this.XrefMonsterDamageType = new List<XrefMonsterDamageType>();
            this.XrefMonsterInfo = new List<XrefMonsterInfo>();
            this.XrefMonsterLanguage = new List<XrefMonsterLanguage>();
            this.XrefMonsterSense = new List<XrefMonsterSense>();
            this.XrefMonsterSkill = new List<XrefMonsterSkill>();
            this.XrefMonsterSpeed = new List<XrefMonsterSpeed>();
            this.Conditions = new List<Condition>();
            this.DamageType = new List<DamageType>();
            this.DamageType1 = new List<DamageType>();
            this.Tags = new List<Tag>();
            this.DamageType2 = new List<DamageType>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int SizeId { get; set; }

        public int TypeId { get; set; }

        [NotMapped]
        public Alignment Alignment { get; set; }
        //{
        //    get
        //    {
        //        return AlignmentBuilder.GetAlignment(AlignmentAttitude, AlignmentMorality);
        //    }
        //    set { }
        //}

        public int AlignmentAttitudeId { get; set; }

        public int AlignmentMoralityId { get; set; }

        public int Ac { get; set; }

        public string AcNote { get; set; }

        public int Hp { get; set; }

        public string HpNote { get; set; }

        public int Str { get; set; }

        public int Dex { get; set; }

        public int Con { get; set; }

        public int Int { get; set; }

        public int Wis { get; set; }

        public int Cha { get; set; }

        public int StrSave { get; set; }

        public int DexSave { get; set; }

        public int ConSave { get; set; }

        public int IntSave { get; set; }

        public int WisSave { get; set; }

        public int ChaSave { get; set; }

        public int PassivePerception { get; set; }

        public string LanguageNote { get; set; }

        public float ChallengeRating { get; set; }

        public int ExperiencePoints { get; set; }

        public int TelepathyDistance { get; set; }

        public virtual AlignmentAttitude AlignmentAttitude { get; set; }

        public virtual AlignmentMorality AlignmentMorality { get; set; }

        public virtual ICollection<XrefMonsterDamageType> XrefMonsterDamageType { get; set; }

        public virtual ICollection<XrefMonsterInfo> XrefMonsterInfo { get; set; }

        public virtual ICollection<XrefMonsterLanguage> XrefMonsterLanguage { get; set; }

        public virtual ICollection<XrefMonsterSense> XrefMonsterSense { get; set; }

        public virtual ICollection<XrefMonsterSkill> XrefMonsterSkill { get; set; }

        public virtual ICollection<XrefMonsterSpeed> XrefMonsterSpeed { get; set; }

        public virtual Size Size { get; set; }

        public virtual MonsterType MonsterType { get; set; }

        public virtual ICollection<Condition> Conditions { get; set; }

        public virtual ICollection<DamageType> DamageType { get; set; }

        public virtual ICollection<DamageType> DamageType1 { get; set; }

        public virtual ICollection<Tag> Tags { get; set; }

        public virtual ICollection<DamageType> DamageType2 { get; set; }

    }
}
