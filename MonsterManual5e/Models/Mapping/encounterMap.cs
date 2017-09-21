using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MonsterManual5e.Models.Mapping
{
    public class EncounterMap : EntityTypeConfiguration<Encounter>
    {
        public EncounterMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(45);

            // Table & Column Mappings
            this.ToTable("encounter", "dnd_monster");
            this.Property(t => t.Id).HasColumnName("id");
            this.Property(t => t.Name).HasColumnName("name");
            this.Property(t => t.Experience).HasColumnName("experience");
            this.Property(t => t.DifficultyXp).HasColumnName("difficulty_xp");

            // Relationships
            this.HasMany(t => t.Monsters)
                .WithMany(t => t.Encounters)
                .Map(m =>
                    {
                        m.ToTable("xref_monster_encounter", "dnd_monster");
                        m.MapLeftKey("encounter_id");
                        m.MapRightKey("monster_id");
                    });


        }
    }
}
