using MonsterManual5e.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;

namespace MonsterManual5e.Repositories
{
    public class EncounterRepository
    {
        public Encounter GetEncounterById(int id)
        {
            using (var context = new DndMonstercontext())
            {
                return context.Encounters.SingleOrDefault(encounter => encounter.Id == id);
            }
        }

        public void AddMonsterToEncounter(int monsterID, int encounterID)
        {
            using (var context = new DndMonstercontext())
            {
                Encounter encounter = GetEncounterById(encounterID);
                encounter.Monsters.Add(new MonsterRepository().GetMonsterById(monsterID));
                context.Entry(encounter).State = EntityState.Modified;
                int result = context.SaveChanges();
                Debug.WriteLine("Result = " + result);
            }
        }
    }
}