using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using MonsterManual5e.Models.Mapping;

namespace MonsterManual5e.Models
{
    public partial class DndMonstercontext : DbContext
    {
        static DndMonstercontext()
        {
            Database.SetInitializer<DndMonstercontext>(null);
        }

        public DndMonstercontext()
            : base("Name=DndMonstercontext")
        {
        }

        public DbSet<AbilityScore> AbilityScore { get; set; }
        public DbSet<AffectType> AffectType { get; set; }
        public DbSet<AlignmentAttitude> AlignmentAttitude { get; set; }
        public DbSet<AlignmentMorality> AlignmentMorality { get; set; }
        public DbSet<DamageType> DamageType { get; set; }
        public DbSet<InfoType> InfoType { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Monster> Monsters { get; set; }
        public DbSet<Sense> Senses { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Speed> Speeds { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Type> Types { get; set; }
        public DbSet<XrefMonsterDamageType> XrefMonsterDamageType { get; set; }
        public DbSet<XrefMonsterInfo> XrefMonsterInfo { get; set; }
        public DbSet<XrefMonsterLanguage> XrefMonsterLanguage { get; set; }
        public DbSet<XrefMonsterSense> XrefMonsterSense { get; set; }
        public DbSet<XrefMonsterSkill> XrefMonsterSkill { get; set; }
        public DbSet<XrefMonsterSpeed> XrefMonsterSpeed { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AbilityScoreMap());
            modelBuilder.Configurations.Add(new AffectTypeMap());
            modelBuilder.Configurations.Add(new AlignmentAttitudeMap());
            modelBuilder.Configurations.Add(new AlignmentMoralityMap());
            modelBuilder.Configurations.Add(new DamageTypeMap());
            modelBuilder.Configurations.Add(new InfoTypeMap());
            modelBuilder.Configurations.Add(new LanguageMap());
            modelBuilder.Configurations.Add(new MonsterMap());
            modelBuilder.Configurations.Add(new SenseMap());
            modelBuilder.Configurations.Add(new SizeMap());
            modelBuilder.Configurations.Add(new SkillMap());
            modelBuilder.Configurations.Add(new SpeedMap());
            modelBuilder.Configurations.Add(new TagMap());
            modelBuilder.Configurations.Add(new TypeMap());
            modelBuilder.Configurations.Add(new XrefMonsterDamageTypeMap());
            modelBuilder.Configurations.Add(new XrefMonsterInfoMap());
            modelBuilder.Configurations.Add(new XrefMonsterLanguageMap());
            modelBuilder.Configurations.Add(new XrefMonsterSenseMap());
            modelBuilder.Configurations.Add(new XrefMonsterSkillMap());
            modelBuilder.Configurations.Add(new XrefMonsterSpeedMap());
        }
    }
}
