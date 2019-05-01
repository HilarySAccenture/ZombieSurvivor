using System.Collections.Generic;

namespace ZombieSurvivor
{
    public class Survivor
    {
        private string _name;
        public int Wounds;
        public List<Equipment> Arsenal { get; set; }

        public Survivor(string name, int wounds = 0, List<Equipment> arsenal = null)
        {
            _name = name;
            Wounds = wounds;

        }
        public void Injure()
        {
            if (Wounds < 2)
            {
                Wounds++;
            }
        }
        public bool IsAlive()
        {
            return (Wounds < 2);
        }

        public void AcquireEquipment(Equipment equipment)
        {
            Arsenal.Add(equipment);
    }
        }

   
}