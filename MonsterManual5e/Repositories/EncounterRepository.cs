using MonsterManual5e.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

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
                //Encounter encounter = GetEncounterById(encounterID);
                //encounter.Monsters.Add(new MonsterRepository().GetMonsterById(monsterID));
                //context.Entry(enconuter).State = EntityState.Added;
                XrefEncounterMonster xref = new XrefEncounterMonster();
                xref.EncounterId = encounterID;
                xref.MonsterId = monsterID;
                context.SaveChanges();
            }
        }
    }
}