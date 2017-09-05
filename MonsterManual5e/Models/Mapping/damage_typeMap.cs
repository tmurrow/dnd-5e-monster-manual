using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MonsterManual5e.Models.Mapping
{
    public class DamageTypeMap : EntityTypeConfiguration<DamageType>
    {
        public DamageTypeMap()
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
            this.ToTable("damage_type", "dnd_monster");
            this.Property(t => t.Id).HasColumnName("id");
            this.Property(t => t.Name).HasColumnName("name");
            this.Property(t => t.Order).HasColumnName("order");
            this.Property(t => t.Note).HasColumnName("note");

            // Relationships
            this.HasMany(t => t.Monsters)
                .WithMany(t => t.DamageType)
                .Map(m =>
                    {
                        m.ToTable("xref_monster_immunity", "dnd_monster");
                        m.MapLeftKey("damage_type_id");
                        m.MapRightKey("monster_id");
                    });

            this.HasMany(t => t.Monsters1)
                .WithMany(t => t.DamageType1)
                .Map(m =>
                    {
                        m.ToTable("xref_monster_resistance", "dnd_monster");
                        m.MapLeftKey("damage_type_id");
                        m.MapRightKey("monster_id");
                    });

            this.HasMany(t => t.Monsters2)
                .WithMany(t => t.DamageType2)
                .Map(m =>
                    {
                        m.ToTable("xref_monster_vulnerability", "dnd_monster");
                        m.MapLeftKey("damage_type_id");
                        m.MapRightKey("monster_id");
                    });


        }
    }
}
