using System;
using MagicDestroyers.Equipment.Armors.Heavy;
using MagicDestroyers.Equipment.Weapons.Sharp;
using MagicDestroyers.Enums;
using MagicDestroyers.Characters.Character;

namespace MagicDestroyers.Characters.Melee
{
    public class Warrior : Melee
    {
        //private code is for the fields and cannot be seen outside the class
        private const string DEFAULT_NAME = "Jack";
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTH_POINTS = 110;
        private const int DEFAULT_ABILITY_POINTS = 100;
        private const Faction DEFAULT_FACTION = Faction.Melee;

        private readonly Chainlink DEFAULT_BODY_ARMOR = new Chainlink();
        private readonly Axe DEFAULT_WEAPON = new Axe();   

        private Chainlink bodyArmor;
        private Axe weapon;

         public Chainlink BodyArmor {
            get {
                return this.bodyArmor;
            }
            set {
                this.bodyArmor = value;
            }
        }

        public Axe Weapon {
            get {
                return weapon;
            }
            set {
                this.weapon = value;
            }
        }


        public Warrior()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
        }

        public Warrior(string name, int level)
            : this(name, level, DEFAULT_HEALTH_POINTS)
        {
        }

        public Warrior(string name, int level, int healthPoints)
        {
            this.Name = name;
            this .Level = level;
            this.HealthPoints = healthPoints;
            this.AbilityPoints = DEFAULT_ABILITY_POINTS;
            this.Faction = DEFAULT_FACTION;
            this.BodyArmor = DEFAULT_BODY_ARMOR;
            this.Weapon = DEFAULT_WEAPON;
        }

        public void Strike()
        {
            throw new NotImplementedException();
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }

        public void SkinHarden()
        {
            throw new NotImplementedException();
        }
    }
}