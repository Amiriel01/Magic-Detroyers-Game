using System;
using MagicDestroyers.Equipment.Armors.Heavy;
using MagicDestroyers.Equipment.Weapons.Blunt;
using MagicDestroyers.Enums;

namespace MagicDestroyers.Characters.Melee
{
    public class Knight : Melee
    {
        private const string DEFAULT_NAME = "Smith";
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTH_POINTS = 100;
        private const int DEFAULT_ABILITY_POINTS = 110;
        private const Faction DEFAULT_FACTION = Faction.Melee;

        private readonly Chainlink DEFAULT_BODY_ARMOR = new Chainlink();
        private readonly Hammer DEFAULT_WEAPON = new Hammer();

        private Chainlink bodyArmor;
        private Hammer weapon;

        public Chainlink BodyArmor {
            get {
                return this.bodyArmor;
            }
            set {
                this.bodyArmor = value;
            }
        }

        public Hammer Weapon {
            get {
                return weapon;
            }
            set {
                this.weapon = value;
            }
        }

        public Knight()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
        }

         public Knight(string name, int level)
            : this(name, level, DEFAULT_HEALTH_POINTS)
        {
        }

         public Knight(string name, int level, int healthPoints)
        {
            this.Name = name;
            this .Level = level;
            this.HealthPoints = healthPoints;
            this.AbilityPoints = DEFAULT_ABILITY_POINTS;
            this.Faction = DEFAULT_FACTION;
            this.BodyArmor = DEFAULT_BODY_ARMOR;
            this.Weapon = DEFAULT_WEAPON;
        }

        public void HollowBlow()
        {
            throw new NotImplementedException();
        }

        public void PurifySoul()
        {
            throw new NotImplementedException();
        }

        public void RightousWings()
        {
            throw new NotImplementedException();
        }
    }
}