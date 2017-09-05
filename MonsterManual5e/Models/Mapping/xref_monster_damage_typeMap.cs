using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MonsterManual5e.Models.Mapping
{
    public class XrefMonsterDamageTypeMap : EntityTypeConfiguration<XrefMonsterDamageType>
    {
        public XrefMonsterDamageTypeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.MonsterId, t.DamageTypeId, t.AffectTypeId });

            // Properties
            this.Property(t => t.MonsterId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DamageTypeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AffectTypeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Note)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("xref_monster_damage_type", "dnd_monster");
            this.Property(t => t.MonsterId).HasColumnName("monster_id");
            this.Property(t => t.DamageTypeId).HasColumnName("damage_type_id");
            this.Property(t => t.AffectTypeId).HasColumnName("affect_type_id");
            this.Property(t => t.Note).HasColumnName("note");

            // Relationships
            this.HasRequired(t => t.AffectType)
                .WithMany(t => t.XrefMonsterDamageType)
                .HasForeignKey(d => d.AffectTypeId);
            this.HasRequired(t => t.DamageType)
                .WithMany(t => t.XrefMonsterDamageType)
                .HasForeignKey(d => d.DamageTypeId);
            this.HasRequired(t => t.Monster)
                .WithMany(t => t.XrefMonsterDamageType)
                .HasForeignKey(d => d.MonsterId);

        }
    }
}
