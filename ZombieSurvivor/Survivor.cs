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


        public Survivor(string name, int wounds = 0, int experience = 0)
        {
            Name = name;
            Wounds = wounds;
            Arsenal = new List<IEquipment>();
            Experience = experience;
            Level = "Blue";

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
//    could this be designed better? as far as naming...responsibility? 
        private void AdvanceLevel()
        {
            if (Experience > 43)
            {
                Level = "Red";
            }
            else if (Experience > 18)
            {
                Level = "Orange";
            }
            else if(Experience > 6)
            {
                Level = "Yellow";
            }
           
        }
    }
}