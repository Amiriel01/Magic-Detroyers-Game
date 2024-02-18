using System;
using MagicDestroyers.Equipment.Armors.Leather;
using MagicDestroyers.Equipment.Weapons.Blunt;
using MagicDestroyers.Enums;

namespace MagicDestroyers.Characters.Spellcaster
{
    public class Druid : Spellcaster
    {
        private readonly LightLeatherVest DEFAULT_BODY_ARMOR = new LightLeatherVest();
        private readonly Staff DEFAULT_WEAPON = new Staff();

        public Driud()
            : this(Consts.Druid.NAME, 1)
        {
        }

        public Driud(string name, int level)
            : this(name, level, Consts.Druid.HEALTH_POINTS)
        {
        }

        public Driud(string name, int level, int healthPoints)
        {
            base.Name = name;
            base .Level = level;
            base.HealthPoints = healthPoints;
            base.AbilityPoints = Consts.Druid.ABILITY_POINTS;
            base.Faction = Faction.Spellcaster;
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