using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MonsterManual5e.Models.Mapping
{
    public class XrefMonsterSpeedMap : EntityTypeConfiguration<XrefMonsterSpeed>
    {
        public XrefMonsterSpeedMap()
        {
            // Primary Key
            this.HasKey(t => new { t.MonsterId, t.SpeedId, t.Value });

            // Properties
            this.Property(t => t.MonsterId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SpeedId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Value)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Note)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("xref_monster_speed", "dnd_monster");
            this.Property(t => t.MonsterId).HasColumnName("monster_id");
            this.Property(t => t.SpeedId).HasColumnName("speed_id");
            this.Property(t => t.Value).HasColumnName("value");
            this.Property(t => t.Note).HasColumnName("note");

            // Relationships
            this.HasRequired(t => t.Monster)
                .WithMany(t => t.XrefMonsterSpeed)
                .HasForeignKey(d => d.MonsterId);
            this.HasRequired(t => t.Speed)
                .WithMany(t => t.XrefMonsterSpeed)
                .HasForeignKey(d => d.SpeedId);

        }
    }
}
