

namespace MagicDestroyers.Equipment.Weapons.Blunt
{
    public class Staff
    {
        private int damage;

         public int Damage
        {
         get
            {
                return this.damage;
            }
            set 
            {
                if (value >= 0) 
                {
                    this.damage = value;
                }
                else 
                {
                    System.Console.WriteLine("Damage must be zero or greater.");
                    throw new ArgumentOutOfRangeException(string.Empty, "Damage must be zero or greater.");
                }
            }
        }

        public Staff() 
        {

        }

        public void Empower()
        {
            throw new NotImplementedException();
        }
    }
}