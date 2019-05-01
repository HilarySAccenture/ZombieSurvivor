using System.Collections.Generic;

namespace ZombieSurvivor
{
    public class Game
    {
        public Dictionary<Survivor,string> SurvivorGroup;
        public Game(Dictionary<Survivor, string> survivorGroup = null)
        {
            SurvivorGroup = new Dictionary<Survivor, string>();
        }
        public void AddSurvivor(Survivor survivor)
        {
            SurvivorGroup.Add(survivor, survivor.Name);
        }
    }
}