

namespace MagicDestroyers.Equipment.Weapons.Sharp
{
    public class Sword
    {
        private const int DEFAULT_DAMAGE_POINTS = 10;

        private int damage;

         public int Damage
        {
         get
            {
                return damage;
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
            : this(DEFAULT_DAMAGE_POINTS)
        {
        }

        public Sword(int armorPoints)
        {
            this.DamagePoints = armorPoints;
        }
        public void Bloodthirst()
        {
            throw new NotImplementedException();
        }
    }
}