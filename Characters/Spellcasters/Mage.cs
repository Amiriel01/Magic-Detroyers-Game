using System;
using MagicDestroyers.Equipment.Armors.Light;
using MagicDestroyers.Equipment.Weapons.Blunt;
using MagicDestroyers.Enums;

namespace MagicDestroyers.Characters.Spellcaster
{
    public class Mage : Spellcaster
    {
        private readonly ClothRobe DEFAULT_BODY_ARMOR = new ClothRobe();
        private readonly Staff DEFAULT_WEAPON = new Staff();

        public Mage()
            : this(Consts.Mage.NAME, 1)
        {
        }

         public Mage(string name, int level)
            : this(name, level, Consts.Mage.HEALTH_POINTS)
        {
        }

         public Mage(string name, int level, int healthPoints)
        {
            base.Name = name;
            base .Level = level;
            base.HealthPoints = healthPoints;
            base.AbilityPoints = Consts.MageABILITY_POINTS;
            base.Faction = Faction.Spellcaster;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.Weapon = DEFAULT_WEAPON;
            base.IsAlive = true;
            base.Scores = 0;
        }

        public int ArcaneWrath()
        {
            return base.Weapon.DamagePoints + 11;
        }

        public int Firewall()
        {
            throw new NotImplementedException();
        }

        public int Meditation()
        {
            return base.BodyArmor.ArmorPoints +6;
        } 

        public override int Attack()
        {
            return this.ArcaneWrath();
        }

        public override int SpecialAttack()
        {
            return this.Firewall();
        }

        public override int Defend()
        {
            return this.Meditation();
        }
    }
}