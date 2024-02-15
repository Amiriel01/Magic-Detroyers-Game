

namespace MagicDestroyers.Equipment.Armors.Leather
{
    public class LightLeatherVest
    {
        private const int DEFAULT_ARMOR_POINTS = 15;

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

        public LightLeatherVest()
            : this(DEFAULT_ARMOR_POINTS)
        {
        }

        public LightLeatherVest(int armorPoints)
        {
            this.ArmorPoints = armorPoints;
        }
    }
}