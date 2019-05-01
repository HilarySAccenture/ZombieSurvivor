using System.Collections.Generic;

namespace ZombieSurvivor
{
    public class Game
    {
        public List<Survivor> SurvivorGroup;

        public Game()
        {
            SurvivorGroup = new List<Survivor>();
        }

        public void AddSurvivor(Survivor survivor)
        {
            if (SurvivorGroup.Count == 0)
            {
                SurvivorGroup.Add(survivor);
            }
            else
            {
                foreach (var person in SurvivorGroup)
                {
                    if (person.Name != survivor.Name)
                    {
                        SurvivorGroup.Add(survivor);
                    }
                
                }
            }
            
        }
    }
}