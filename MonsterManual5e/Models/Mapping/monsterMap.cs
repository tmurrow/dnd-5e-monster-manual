using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MonsterManual5e.Models.Mapping
{
    public class MonsterMap : EntityTypeConfiguration<Monster>
    {
        public MonsterMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(63);

            this.Property(t => t.AcNote)
                .HasMaxLength(63);

            this.Property(t => t.HpNote)
                .HasMaxLength(15);

            this.Property(t => t.LanguageNote)
                .HasMaxLength(127);

            this.Property(t => t.ChallengNote)
                .HasMaxLength(45);

            // Table & Column Mappings
            this.ToTable("monster", "dnd_monster");
            this.Property(t => t.Id).HasColumnName("id");
            this.Property(t => t.Name).HasColumnName("name");
            this.Property(t => t.SizeId).HasColumnName("size_id");
            this.Property(t => t.TypeId).HasColumnName("type_id");
            this.Property(t => t.AlignmentAttitudeId).HasColumnName("alignment_attitude_id");
            this.Property(t => t.AlignmentMoralityId).HasColumnName("alignment_morality_id");
            this.Property(t => t.Ac).HasColumnName("ac");
            this.Property(t => t.AcNote).HasColumnName("ac_note");
            this.Property(t => t.Hp).HasColumnName("hp");
            this.Property(t => t.HpNote).HasColumnName("hp_note");
            this.Property(t => t.Str).HasColumnName("str");
            this.Property(t => t.Dex).HasColumnName("dex");
            this.Property(t => t.Con).HasColumnName("con");
            this.Property(t => t.Int).HasColumnName("int");
            this.Property(t => t.Wis).HasColumnName("wis");
            this.Property(t => t.Cha).HasColumnName("cha");
            this.Property(t => t.StrSave).HasColumnName("str_save");
            this.Property(t => t.DexSave).HasColumnName("dex_save");
            this.Property(t => t.ConSave).HasColumnName("con_save");
            this.Property(t => t.IntSave).HasColumnName("int_save");
            this.Property(t => t.WisSave).HasColumnName("wis_save");
            this.Property(t => t.ChaSave).HasColumnName("cha_save");
            this.Property(t => t.PassivePerception).HasColumnName("passive_perception");
            this.Property(t => t.LanguageNote).HasColumnName("language_note");
            this.Property(t => t.ChallengeRating).HasColumnName("challenge_rating");
            this.Property(t => t.ChallengNote).HasColumnName("challeng_note");

            // Relationships
            this.HasMany(t => t.Tags)
                .WithMany(t => t.Monsters)
                .Map(m =>
                    {
                        m.ToTable("xref_monster_tag", "dnd_monster");
                        m.MapLeftKey("monster_id");
                        m.MapRightKey("tag_id");
                    });

            this.HasRequired(t => t.AlignmentAttitude)
                .WithMany(t => t.Monsters)
                .HasForeignKey(d => d.AlignmentAttitudeId);
            this.HasRequired(t => t.AlignmentMorality)
                .WithMany(t => t.Monsters)
                .HasForeignKey(d => d.AlignmentMoralityId);
            this.HasRequired(t => t.Size)
                .WithMany(t => t.Monsters)
                .HasForeignKey(d => d.SizeId);
            this.HasRequired(t => t.Type)
                .WithMany(t => t.Monsters)
                .HasForeignKey(d => d.TypeId);

        }
    }
}
