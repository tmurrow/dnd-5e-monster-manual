using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MonsterManual5e.Models.Mapping
{
    public class XrefMonsterInfoMap : EntityTypeConfiguration<XrefMonsterInfo>
    {
        public XrefMonsterInfoMap()
        {
            // Primary Key
            this.HasKey(t => new { t.MonsterId, t.InfoTypeId, t.Name, t.Description });

            // Properties
            this.Property(t => t.MonsterId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.InfoTypeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(45);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(16777215);

            // Table & Column Mappings
            this.ToTable("xref_monster_info", "dnd_monster");
            this.Property(t => t.MonsterId).HasColumnName("monster_id");
            this.Property(t => t.InfoTypeId).HasColumnName("info_type_id");
            this.Property(t => t.Name).HasColumnName("name");
            this.Property(t => t.Description).HasColumnName("description");

            // Relationships
            this.HasRequired(t => t.InfoType)
                .WithMany(t => t.XrefMonsterInfo)
                .HasForeignKey(d => d.InfoTypeId);
            this.HasRequired(t => t.Monster)
                .WithMany(t => t.XrefMonsterInfo)
                .HasForeignKey(d => d.MonsterId);

        }
    }
}
