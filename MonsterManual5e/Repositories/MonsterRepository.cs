using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MonsterManual5e.Models;

namespace MonsterManual5e.Repositories
{
    public class MonsterRepository
    {
        #region Monster
        public IEnumerable<Monster> GetAllMonsters()
        {
            using (var context = new DndMonstercontext())
            {
                return context.Monsters
                    .Include("Size")
                    .Include("MonsterType")
                    .Include("AlignmentAttitude")
                    .Include("AlignmentMorality")
                    .Include("Source")
                    .Include(m => m.XrefMonsterDamageType.Select(s => s.DamageType))
                    .Include(m => m.XrefMonsterDamageType.Select(s => s.AffectType))
                    .Include(m => m.XrefMonsterInfo.Select(s => s.InfoType))
                    .Include(m => m.XrefMonsterLanguage.Select(s => s.Language))
                    .Include(m => m.XrefMonsterSense.Select(s => s.Sense))
                    .Include(m => m.XrefMonsterSkill.Select(s => s.Skill))
                    .Include(m => m.XrefMonsterSpeed.Select(s => s.Speed))
                    .Include("Encounters")
                    .Include("Conditions")
                    .Include("DamageType")
                    .Include("DamageType1")
                    .Include("Tags")
                    .Include("DamageType2")
                    .ToList();
            }
        }

        public Monster GetMonsterById(int id)
        {
            using (var context = new DndMonstercontext())
            {
                return context.Monsters
                    .Include("Size")
                    .Include("MonsterType")
                    .Include("AlignmentAttitude")
                    .Include("AlignmentMorality")
                    .Include("Source")
                    .Include(m => m.XrefMonsterDamageType.Select(s => s.DamageType))
                    .Include(m => m.XrefMonsterDamageType.Select(s => s.AffectType))
                    .Include(m => m.XrefMonsterInfo.Select(s => s.InfoType))
                    .Include(m => m.XrefMonsterLanguage.Select(s => s.Language))
                    .Include(m => m.XrefMonsterSense.Select(s => s.Sense))
                    .Include(m => m.XrefMonsterSkill.Select(s => s.Skill))
                    .Include(m => m.XrefMonsterSpeed.Select(s => s.Speed))
                    .Include("Encounters")
                    .Include("Conditions")
                    .Include("DamageType")
                    .Include("DamageType1")
                    .Include("Tags")
                    .Include("DamageType2")
                    .SingleOrDefault(m => m.Id == id);

                //context.Video_Group.Include(v => v.Video_Group_Personnel_Group.Select(s => s.Personnel_Group))
            }
        }

        public Monster GetMonsterByName(string name)
        {
            using (var context = new DndMonstercontext())
            {
                return context.Monsters.Where(m => m.Name.Equals(name)).SingleOrDefault();
            }
        }
        #endregion

        #region Alignments
        public IEnumerable<AlignmentAttitude> GetAllAlignmentAttitudes()
        {
            using (var context = new DndMonstercontext())
            {
                return context.AlignmentAttitude.ToList();
            }
        }

        public IEnumerable<AlignmentMorality> GetAllAlignmentMoralities()
        {
            using (var context = new DndMonstercontext())
            {
                return context.AlignmentMorality.ToList();
            }
        }
        #endregion

        #region Languages
        public IEnumerable<Language> GetAllLanguages()
        {
            using (var context = new DndMonstercontext())
            {
                return context.Languages.ToList();
            }
        }
        #endregion

        #region Sizes
        public IEnumerable<Size> GetAllSizes()
        {
            using (var context = new DndMonstercontext())
            {
                return context.Sizes.ToList();
            }
        }
        #endregion

        #region Types
        public IEnumerable<MonsterType> GetAllTypes()
        {
            using (var context = new DndMonstercontext())
            {
                return context.MonsterType.ToList();
            }
        }
        #endregion

        #region Senses
        public IEnumerable<Sense> GetAllSenses()
        {
            using (var context = new DndMonstercontext())
            {
                return context.Senses.ToList();
            }
        }
        #endregion

        #region Skills
        public IEnumerable<Skill> GetAllSkills()
        {
            using (var context = new DndMonstercontext())
            {
                return context.Skills.ToList();
            }
        }
        #endregion
    }
}