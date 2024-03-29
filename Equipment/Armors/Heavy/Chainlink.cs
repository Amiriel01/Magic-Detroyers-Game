

namespace MagicDestroyers.Equipment.Armors.Heavy
{
    public class Chainlink : Heavy
    {
        private const int DEFAULT_ARMOR_POINTS = 20;

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