

namespace MagicDestroyers.Equipment.Armors.Heavy
{
    public class Chainlink
    {
        private int armorPoints;


        public int ArmorPoints
        {
         get
            {
                return this.armorPoints;
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
        {
           
        }
    }
}