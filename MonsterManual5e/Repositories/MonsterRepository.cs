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
                return context.Monsters.Include("Size").Include("MonsterType").Include("AlignmentAttitude").Include("AlignmentMorality").ToList();
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