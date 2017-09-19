using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MonsterManual5e.Models.Mapping
{
    public class SourceMap : EntityTypeConfiguration<Source>
    {
        public SourceMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(45);

            this.Property(t => t.Abbreviation)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("source", "dnd_monster");
            this.Property(t => t.Id).HasColumnName("id");
            this.Property(t => t.Name).HasColumnName("name");
            this.Property(t => t.Abbreviation).HasColumnName("abbreviation");
        }
    }
}
