using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;

namespace ZombieSurvivor
{
    public class Survivor
    {
        public string Name { get; }
        public int Wounds { get; private set; }
        public List<IEquipment> Arsenal { get; }
        public int Experience { get; set; }
        public string Level { get; set; }


        public Survivor(string name, int wounds = 0, int experience = 0, string level = null)
        {
            Name = name;
            Wounds = wounds;
            Arsenal = new List<IEquipment>();
            Experience = experience;
            Level = AdvanceLevel();

        }

        public void Injure()
        {
            if (Wounds < 2)Wounds++;

            if (Arsenal.Count <= 0) return;
            
            var lastEquipment = Arsenal.Count - 1;
            Arsenal.RemoveAt(lastEquipment);
        }

        public bool IsDead()
        {
            return (Wounds == 2);
        }

        public void AcquireEquipment(IEquipment equipment)
        {
            if (Arsenal.Count < 5)
            {
                Arsenal.Add(equipment);
            }
        }
        public void KillZombie()
        {
            Experience++;

            AdvanceLevel();
        }

        private string AdvanceLevel()
        {
            if (Experience >= 6)
            {
                return "Yellow";
            }
            return "Blue";
        }
    }
}