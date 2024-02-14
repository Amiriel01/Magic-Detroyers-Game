

namespace MagicDestroyers.Equipment.Weapons.Sharp
{
    public class Axe
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

        public Axe() 
        {

        }

        public void HackNSlash()
        {
            throw new NotImplementedException();
        }
    }
}