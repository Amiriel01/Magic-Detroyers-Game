using System;
using MagicDestroyers.Equipment.Armors.Leather;
using MagicDestroyers.Equipment.Weapons.Sharp;
using MagicDestroyers.Enums;

namespace MagicDestroyers.Characters.Melee
{
    public class Assassin : Melee
    {
        private const string DEFAULT_NAME = "Sam";
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTH_POINTS = 120;
        private const int DEFAULT_ABILITY_POINTS = 90;
        private const Faction DEFAULT_FACTION = Faction.Melee;

        private readonly LightLeatherVest DEFAULT_BODY_ARMOR = new LightLeatherVest();
        private readonly Sword DEFAULT_WEAPON = new Sword();

        private LightLeatherVest bodyArmor;
        private Sword weapon;

         public LightLeatherVest BodyArmor {
            get {
                return this.bodyArmor;
            }
            set {
                this.bodyArmor = value;
            }
        }

        public Sword Weapon {
            get {
                return this.weapon;
            }
            set {
                this.weapon = value;
            }
        }
 //chaining constructors lets the user write less code but still offerts variation in the constructor.
        public Assassin()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
        }

         public Assassin(string name, int level)
            : this(name, level, DEFAULT_HEALTH_POINTS)
        {
        }

         public Assassin(string name, int level, int healthPoints)
        {
            this.Name = name;
            this .Level = level;
            this.HealthPoints = healthPoints;
            this.AbilityPoints = DEFAULT_ABILITY_POINTS;
            this.Faction = DEFAULT_FACTION;
            this.BodyArmor = DEFAULT_BODY_ARMOR;
            this.Weapon = DEFAULT_WEAPON;
        }

        public void Raze()
        {
            throw new NotImplementedException();
        }

        public void BleedToDeath()
        {
            throw new NotImplementedException();
        }

        public void Survival()
        {
            throw new NotImplementedException();
        }
    }
}