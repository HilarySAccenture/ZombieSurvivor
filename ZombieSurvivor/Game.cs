using System.Collections.Generic;

namespace ZombieSurvivor
{
    public class Game
    {
        private List<Survivor> _players = new List<Survivor>();

        public List<Survivor> Players
        {
            get => _players;
            set => _players = value;
        }        

        public void AddSurvivor(Survivor survivor)
        {
            if (Players.Count == 0)
            {
                Players.Add(survivor);
            }
            else
            {
                for (var i = Players.Count - 1; i >= 0; i--)
                {
                    if (Players[i].Name != survivor.Name)
                    {
                        Players.Add(survivor);
                    }
                }
            }
            
        }
    }
}