using System;
using MagicDestroyers.Equipment.Armors.Leather;
using MagicDestroyers.Equipment.Weapons.Blunt;
using MagicDestroyers.Enums;

namespace MagicDestroyers.Characters.Spellcaster
{
    public class Druid : Spellcaster
    {
        private const string DEFAULT_NAME = "Oak";
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTH_POINTS = 80;
        private const int DEFAULT_ABILITY_POINTS = 120;
        private const Faction DEFAULT_FACTION = Faction.Spellcaster;

        private readonly LightLeatherVest DEFAULT_BODY_ARMOR = new LightLeatherVest();
        private readonly Staff DEFAULT_WEAPON = new Staff();

        public Driud()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
        }

        public Driud(string name, int level)
            : this(name, level, DEFAULT_HEALTH_POINTS)
        {
        }

        public Driud(string name, int level, int healthPoints)
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

        public int Moonfire()
        {
            return base.Weapon.DamagePoints + 10;
        }

        public int Starburst()
        {
            throw new NotImplementedException();
        }

        public int OneWithTheNature()
        {
            return base.BodyArmor.ArmorPoints +7;
        }

        public override int Attack()
        {
            return this.Moonfire();
        }

        public override int SpecialAttack()
        {
            return this.Starburst();
        }

        public override int Defend()
        {
            return this.Defend();
        }
    }
}