using System;
using MagicDestroyers.Equipment.Armors.Light;
using MagicDestroyers.Equipment.Weapons.Blunt;
using MagicDestroyers.Enums;

namespace MagicDestroyers.Characters.Spellcaster
{
    public class Mage : Spellcaster
    {
        private const string DEFAULT_NAME = "Rain";
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTH_POINTS = 70;
        private const int DEFAULT_ABILITY_POINTS = 130;
        private const Faction DEFAULT_FACTION = Faction.Spellcaster;

        private readonly ClothRobe DEFAULT_BODY_ARMOR = new ClothRobe();
        private readonly Staff DEFAULT_WEAPON = new Staff();

        public Mage()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
        }

         public Mage(string name, int level)
            : this(name, level, DEFAULT_HEALTH_POINTS)
        {
        }

         public Mage(string name, int level, int healthPoints)
        {
            base.Name = name;
            base .Level = level;
            base.HealthPoints = healthPoints;
            base.AbilityPoints = DEFAULT_ABILITY_POINTS;
            base.Faction = DEFAULT_FACTION;
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