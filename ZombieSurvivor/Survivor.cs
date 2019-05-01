namespace ZombieSurvivor
{
    public class Survivor
    {
        private string _name;
        public int Wounds { get; set; }
        public Survivor(string name, int wounds = 0)
        {
            _name = name;
            Wounds = wounds;

        }
        public void Injure()
        {
            Wounds++;
        }

        
    }
}