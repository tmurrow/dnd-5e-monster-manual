using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MonsterManual5e.Models.Mapping
{
    public class XrefMonsterSkillMap : EntityTypeConfiguration<XrefMonsterSkill>
    {
        public XrefMonsterSkillMap()
        {
            // Primary Key
            this.HasKey(t => new { t.MonsterId, t.SkillId, t.Value });

            // Properties
            this.Property(t => t.MonsterId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SkillId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Value)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Note)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("xref_monster_skill", "dnd_monster");
            this.Property(t => t.MonsterId).HasColumnName("monster_id");
            this.Property(t => t.SkillId).HasColumnName("skill_id");
            this.Property(t => t.Value).HasColumnName("value");
            this.Property(t => t.Note).HasColumnName("note");

            // Relationships
            this.HasRequired(t => t.Monster)
                .WithMany(t => t.XrefMonsterSkill)
                .HasForeignKey(d => d.MonsterId);
            this.HasRequired(t => t.Skill)
                .WithMany(t => t.XrefMonsterSkill)
                .HasForeignKey(d => d.SkillId);

        }
    }
}
