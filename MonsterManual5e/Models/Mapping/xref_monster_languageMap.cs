using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MonsterManual5e.Models.Mapping
{
    public class XrefMonsterLanguageMap : EntityTypeConfiguration<XrefMonsterLanguage>
    {
        public XrefMonsterLanguageMap()
        {
            // Primary Key
            this.HasKey(t => new { t.MonsterId, t.LanguageId, t.TelepathyDistance, t.Speak, t.CommandsOnly });

            // Properties
            this.Property(t => t.MonsterId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LanguageId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TelepathyDistance)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Note)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("xref_monster_language", "dnd_monster");
            this.Property(t => t.MonsterId).HasColumnName("monster_id");
            this.Property(t => t.LanguageId).HasColumnName("language_id");
            this.Property(t => t.TelepathyDistance).HasColumnName("telepathy_distance");
            this.Property(t => t.Speak).HasColumnName("speak");
            this.Property(t => t.CommandsOnly).HasColumnName("commands_only");
            this.Property(t => t.Note).HasColumnName("note");

            // Relationships
            this.HasRequired(t => t.Language)
                .WithMany(t => t.XrefMonsterLanguage)
                .HasForeignKey(d => d.LanguageId);
            this.HasRequired(t => t.Monster)
                .WithMany(t => t.XrefMonsterLanguage)
                .HasForeignKey(d => d.MonsterId);

        }
    }
}
