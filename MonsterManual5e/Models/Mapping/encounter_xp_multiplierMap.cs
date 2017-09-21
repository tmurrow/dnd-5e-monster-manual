using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MonsterManual5e.Models.Mapping
{
    public class EncounterXpMultiplierMap : EntityTypeConfiguration<EncounterXpMultiplier>
    {
        public EncounterXpMultiplierMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("encounter_xp_multiplier", "dnd_monster");
            this.Property(t => t.Id).HasColumnName("id");
            this.Property(t => t.Multiplier).HasColumnName("multiplier");
        }
    }
}
