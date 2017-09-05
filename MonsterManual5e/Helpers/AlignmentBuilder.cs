using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MonsterManual5e.Models;
using MonsterManual5e.Repositories;

namespace MonsterManual5e.Helpers
{
    public static class AlignmentBuilder
    {
        private static MonsterRepository mrepo = new MonsterRepository();

        public static string GetAlignment(string attitude, string morality)
        {
            string alignment;

            if (attitude.Equals("none") || morality.Equals("none"))
            {
                alignment = "Unaligned";
            }
            else if (attitude.Equals("any") && morality.Equals("any"))
            {
                alignment = "Any alignment";
            }            
            else if (attitude.Equals("any"))
            {
                alignment = "Any " + morality;
            }
            else if (morality.Equals("any"))
            {
                alignment = "Any " + attitude;
            }
            else if (attitude.Equals("Neutral") && morality.Equals("Neutral"))
            {
                alignment = "True Neutral";
            }
            else
            {
                alignment = attitude + " " + morality;
            }
            return alignment;
        }

        public static Alignment GetAlignment(AlignmentAttitude attitude, AlignmentMorality morality)
        {
            Alignment alignment = new Alignment();
            alignment.Name = GetAlignment(attitude.Name, morality.Name);
            alignment.Attitude = attitude;
            alignment.Morality = morality;
            alignment.Order = GetAlignmentOrder(alignment.Attitude.Name, alignment.Morality.Name);

            return alignment;
        }

        public static List<Alignment> GetAllAlignments()
        {
            List<Alignment> alignmentList = new List<Alignment>();
            List<AlignmentAttitude> attitudeList = mrepo.GetAllAlignmentAttitudes().ToList();
            List<AlignmentMorality> moralityList = mrepo.GetAllAlignmentMoralities().ToList();

            for (int i = 0; i < attitudeList.Count; i++)
            {
                for (int j = 0; j < moralityList.Count; j++)
                {
                    Alignment alignment = GetAlignment(attitudeList.ElementAt(i), moralityList.ElementAt(j));

                    if (alignment.Attitude.Name.Equals("any") && alignment.Morality.Name.Equals("any"))
                    {
                        alignment.Name = "Any alignment";
                    }
                    else if (alignment.Attitude.Name.Equals("none") || alignment.Morality.Name.Equals("none"))
                    {
                        alignment.Name = "Unaligned";
                    }
                    else if (alignment.Attitude.Name.Equals("any"))
                    {
                        alignment.Name = "Any " + alignment.Morality.Name;
                    }
                    else if (alignment.Morality.Name.Equals("any"))
                    {
                        alignment.Name = "Any " + alignment.Attitude.Name;
                    }
                    else if (alignment.Attitude.Name.Equals("Neutral") && alignment.Morality.Name.Equals("Neutral"))
                    {
                        alignment.Name = "True Neutral";
                    }
                    else
                    {
                        alignment.Name = alignment.Attitude.Name + " " + alignment.Morality.Name;
                    }

                    //if alignment isn't in the list, add it
                    var test = alignmentList.SingleOrDefault(a => a.Name.Equals(alignment.Name));
                    if (test == null)
                    {
                        alignmentList.Add(alignment);
                    }
                }
            }

            return alignmentList;
        }

        private static int GetAlignmentOrder(string attitude, string morality)
        {
            int order = 0;

            if (attitude.Equals("none") || morality.Equals("none"))
            {
                order = 17;
            }
            else if (attitude.Equals("Lawful"))
            {
                if (morality.Equals("Good"))
                {
                    order = 1;
                }
                else if (morality.Equals("Neutral"))
                {
                    order = 2;
                }
                else if (morality.Equals("Evil"))
                {
                    order = 3;
                }
                else if (morality.Equals("any"))
                {
                    order = 10;
                }
            }
            else if (attitude.Equals("Neutral"))
            {
                if (morality.Equals("Good"))
                {
                    order = 4;
                }
                else if (morality.Equals("Neutral"))
                {
                    order = 5;
                }
                else if (morality.Equals("Evil"))
                {
                    order = 6;
                }
                else if (morality.Equals("any"))
                {
                    order = 11;
                }
            }
            else if (attitude.Equals("Chaotic"))
            {
                if (morality.Equals("Good"))
                {
                    order = 7;
                }
                else if (morality.Equals("Neutral"))
                {
                    order = 8;
                }
                else if (morality.Equals("Evil"))
                {
                    order = 9;
                }
                else if (morality.Equals("any"))
                {
                    order = 12;
                }
            }
            else if (attitude.Equals("any"))
            {
                if (morality.Equals("Good"))
                {
                    order = 13;
                }
                else if (morality.Equals("Neutral"))
                {
                    order = 14;
                }
                else if (morality.Equals("Evil"))
                {
                    order = 15;
                }
                else if (morality.Equals("any"))
                {
                    order = 16;
                }
            }

            return order;
        }
    }
}