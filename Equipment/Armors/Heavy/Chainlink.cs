

namespace MagicDestroyers.Equipment.Armors.Heavy
{
    public class Chainlink
    {
        private const int DEFAULT_ARMOR_POINTS = 20;

        private int armorPoints;

        public int ArmorPoints
        {
         get
            {
                return armorPoints;
            }
            set 
            {
                if (value >= 0) 
                {
                    this.armorPoints = value;
                }
                else 
                {
                    System.Console.WriteLine("Armor points must be one or greater.");
                    throw new ArgumentOutOfRangeException(string.Empty, "Armor points must be one or greater.");
                }
            }
        }

        public Chainlink()
            : this(DEFAULT_ARMOR_POINTS)
        {
        }

        public Chainlink(int armorPoints)
        {
            this.ArmorPoints = armorPoints;
        }
    }
}