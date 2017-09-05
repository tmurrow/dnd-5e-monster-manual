using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MonsterManual5e.Models.Mapping
{
    public class ConditionMap : EntityTypeConfiguration<Condition>
    {
        public ConditionMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(45);

            this.Property(t => t.Note)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("condition", "dnd_monster");
            this.Property(t => t.Id).HasColumnName("id");
            this.Property(t => t.Name).HasColumnName("name");
            this.Property(t => t.Order).HasColumnName("order");
            this.Property(t => t.Note).HasColumnName("note");

            // Relationships
            this.HasMany(t => t.Monsters)
                .WithMany(t => t.Conditions)
                .Map(m =>
                    {
                        m.ToTable("xref_monster_condition", "dnd_monster");
                        m.MapLeftKey("condition_id");
                        m.MapRightKey("monster_id");
                    });


        }
    }
}
