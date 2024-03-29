using System;
using MagicDestroyers.Equipment.Armors.Heavy;
using MagicDestroyers.Equipment.Weapons.Blunt;
using MagicDestroyers.Enums;

namespace MagicDestroyers.Characters.Melee
{
    public class Knight : Melee
    {
        private const string DEFAULT_NAME = "Smith";
        private const int DEFAULT_HEALTH_POINTS = 100;
        private const int DEFAULT_ABILITY_POINTS = 110;
    

        private readonly Chainlink DEFAULT_BODY_ARMOR = new Chainlink();
        private readonly Hammer DEFAULT_WEAPON = new Hammer();

        public Knight()
            : this(Consts.Knight.NAME, 1)
        {
        }

         public Knight(string name, int level)
            : this(name, level, Consts.Knight.HEALTH_POINTS)
        {
        }

         public Knight(string name, int level, int healthPoints)
        {
            base.Name = name;
            base .Level = level;
            base.HealthPoints = healthPoints;
            base.AbilityPoints = Consts.Knight.ABILITY_POINTS;
            base.Faction = Faction.Melee;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.Weapon = DEFAULT_WEAPON;
            base.IsAlive = true;
            base.Scores = 0;
        }

        public int HollowBlow()
        {
            return base.Weapon.DamagePoints + 12;
        }

        public int PurifySoul()
        {
            throw new NotImplementedException();
        }

        public int RightousWings()
        {
            return base.BodyArmor.ArmorPoints +4;
        }

        public override int Attack()
        {
            return this.HollowBlow();
        }

        public override int SpecialAttack()
        {
            return this.PurifySoul();
        }

        public override int Defend()
        {
            return this.RightousWings();
        }
    }
}