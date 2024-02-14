

namespace MagicDestroyers.Equipment.Weapons.Sharp
{
    public class Sword
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

        public Sword() 
        {
            this.Damage = 10;
        }

        public void Bloodthirst()
        {
            throw new NotImplementedException();
        }
    }
}