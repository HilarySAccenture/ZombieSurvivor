using System.Collections.Generic;

namespace ZombieSurvivor
{
    public class Survivor
    {
        private string _name;
        public int Wounds;
        public List<IEquipment> Arsenal { get; set; }

        public Survivor(string name, int wounds = 0, List<IEquipment> arsenal = null)
        {
            _name = name;
            Wounds = wounds;
            Arsenal = new List<IEquipment>();

        }
        public void Injure()
        {
            if (Wounds < 2)
            {
                Wounds++;
            }

            if (Arsenal.Count > 0)
            {
                int lastEquipment = Arsenal.Count - 1;
                Arsenal.RemoveAt(lastEquipment);
            }
        }
        public bool IsAlive()
        {
            return (Wounds < 2);
        }

        public void AcquireEquipment(IEquipment equipment)
        {
            if (Arsenal.Count < 5)
            {
                Arsenal.Add(equipment);
            }
        }
     
    }
        

   
}