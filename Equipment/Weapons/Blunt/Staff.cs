

namespace MagicDestroyers.Equipment.Weapons.Blunt
{
    public class Staff
    {
        private const int DEFAULT_DAMAGE_POINTS = 10;

        public Staff()
            : this(DEFAULT_DAMAGE_POINTS)
        {
        }

        public Staff(int armorPoints)
        {
            this.DamagePoints = armorPoints;
        }

        public override void SpecialAbility()
        {
            this.Buff();
        }

        public void Buff()
        {
            this.Empower();
        }
        
        public void Empower()
        {
            throw new NotImplementedException();
        }
    }
}