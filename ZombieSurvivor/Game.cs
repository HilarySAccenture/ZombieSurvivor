using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Linq;

namespace ZombieSurvivor
{
    public class Game
    {
        public List<Survivor> Players { get; set; } = new List<Survivor>();
        public string Level { get; set; }


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

        public bool AllPlayersAreDead()
        {
            var deadPlayers = Players.Where(player => player.IsDead());

            return (deadPlayers.Count() == Players.Count);
        }

        public void GetLevel()
        {
            throw new System.NotImplementedException();
        }
    }
}