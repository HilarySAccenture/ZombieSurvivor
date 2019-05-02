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

        public Survivor(string name, int wounds = 0)
        {
            Name = name;
            Wounds = wounds;
            Arsenal = new List<IEquipment>();
        }

        public void Injure()
        {
            if (Wounds < 2)
            {
                Wounds++;
            }

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
    }
}