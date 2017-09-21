using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MonsterManual5e.Models.Mapping
{
    public class XrefEncounterMonsterMap : EntityTypeConfiguration<XrefEncounterMonster>
    {
        public XrefEncounterMonsterMap()
        {
            // Primary Key
            this.HasKey(t => new { t.EncounterId, t.MonsterId });

            // Properties
            this.Property(t => t.EncounterId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MonsterId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("xref_encounter_monster", "dnd_monster");
            this.Property(t => t.EncounterId).HasColumnName("encounter_id");
            this.Property(t => t.MonsterId).HasColumnName("monster_id");
        }
    }
}
