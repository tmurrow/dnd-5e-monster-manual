using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MonsterManual5e.Models.Mapping
{
    public class EncounterDifficultyThresholdMap : EntityTypeConfiguration<EncounterDifficultyThreshold>
    {
        public EncounterDifficultyThresholdMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("encounter_difficulty_threshold", "dnd_monster");
            this.Property(t => t.Id).HasColumnName("id");
            this.Property(t => t.Easy).HasColumnName("easy");
            this.Property(t => t.Medium).HasColumnName("medium");
            this.Property(t => t.Hard).HasColumnName("hard");
            this.Property(t => t.Deadly).HasColumnName("deadly");
        }
    }
}
