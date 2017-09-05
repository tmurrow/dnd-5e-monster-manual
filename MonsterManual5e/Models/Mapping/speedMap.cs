using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MonsterManual5e.Models.Mapping
{
    public class SpeedMap : EntityTypeConfiguration<Speed>
    {
        public SpeedMap()
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
            this.ToTable("speed", "dnd_monster");
            this.Property(t => t.Id).HasColumnName("id");
            this.Property(t => t.Name).HasColumnName("name");
            this.Property(t => t.Order).HasColumnName("order");
            this.Property(t => t.Note).HasColumnName("note");
        }
    }
}
