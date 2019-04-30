namespace ZombieSurvivor
{
    public class Survivor
    {
        private string _name;
        private int _wounds = 0;

        public Survivor(string name, int wounds)
        {
            _name = name;
            _wounds = wounds;
        }

        public bool IsAlive()
        {
            return true;
        }
    }
}