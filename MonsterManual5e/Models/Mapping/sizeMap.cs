using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MonsterManual5e.Models.Mapping
{
    public class SizeMap : EntityTypeConfiguration<Size>
    {
        public SizeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.HitDice)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.Note)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("size", "dnd_monster");
            this.Property(t => t.Id).HasColumnName("id");
            this.Property(t => t.Name).HasColumnName("name");
            this.Property(t => t.HitDice).HasColumnName("hit_dice");
            this.Property(t => t.AverageHp).HasColumnName("average_hp");
            this.Property(t => t.Order).HasColumnName("order");
            this.Property(t => t.Note).HasColumnName("note");
        }
    }
}
