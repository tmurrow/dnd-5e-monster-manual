using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MonsterManual5e.Models.Mapping
{
    public class XrefMonsterSenseMap : EntityTypeConfiguration<XrefMonsterSense>
    {
        public XrefMonsterSenseMap()
        {
            // Primary Key
            this.HasKey(t => new { t.MonsterId, t.SenseId, t.Value });

            // Properties
            this.Property(t => t.MonsterId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SenseId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Value)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Note)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("xref_monster_sense", "dnd_monster");
            this.Property(t => t.MonsterId).HasColumnName("monster_id");
            this.Property(t => t.SenseId).HasColumnName("sense_id");
            this.Property(t => t.Value).HasColumnName("value");
            this.Property(t => t.Note).HasColumnName("note");

            // Relationships
            this.HasRequired(t => t.Monster)
                .WithMany(t => t.XrefMonsterSense)
                .HasForeignKey(d => d.MonsterId);
            this.HasRequired(t => t.Sense)
                .WithMany(t => t.XrefMonsterSense)
                .HasForeignKey(d => d.SenseId);

        }
    }
}
