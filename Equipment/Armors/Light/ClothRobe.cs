namespace MagicDestroyers.Equipment.Armors.Light
{
    public class ClothRobe
    {
        private const int DEFAULT_ARMOR_POINTS = 10;

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

        public ClothRobe()
            : this(DEFAULT_ARMOR_POINTS)
        {
        }

        public ClothRobe(int armorPoints)
        {
            this.ArmorPoints = armorPoints;
        }
    }
}