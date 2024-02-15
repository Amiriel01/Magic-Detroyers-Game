using System;
using MagicDestroyers.Equipment.Armors.Leather;
using MagicDestroyers.Equipment.Weapons.Sharp;
using MagicDestroyers.Enums;

namespace MagicDestroyers.Characters.Spellcaster
{
    public class Necromancer
    {
        private const string DEFAULT_NAME = "Angie";
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTH_POINTS = 60;
        private const int DEFAULT_ABILITY_POINTS = 150;
        private const Faction DEFAULT_FACTION = Faction.Spellcaster;

        private readonly LightLeatherVest DEFAULT_BODY_ARMOR = new LightLeatherVest();
        private readonly Sword DEFAULT_WEAPON = new Sword();

        private int abilityPoints;
        private int healthPoints;
        private int level;

        private Faction faction;
        private string name;

        private LightLeatherVest bodyArmor;
        private Sword weapon;

 public int AbilityPoints {
            get {
                return this.abilityPoints;
            }
            set {
                if (value >= 1 && value <= 50) 
                {
                    this.abilityPoints = value;
                }
                else 
                {
                    System.Console.WriteLine("Ability Points must be between 1 and 50.");
                    throw new ArgumentOutOfRangeException(string.Empty, "Ability Points must be between 1 and 50.");
                }
            }
        }

         public int HealthPoints {
            get {
                return this.healthPoints;
            }
            set {
                if (value >= 1 && value <= 100) 
                {
                    this.healthPoints = value;
                }
                else 
                {
                    System.Console.WriteLine("Health points must be between 1 and 100.");
                    throw new ArgumentOutOfRangeException(string.Empty, "Health points must be between 1 and 100.");
                }
            }
        }

         public int Level {
            get {
                return this.level;
            }
            set {
                if (value >= 1) 
                {
                    this.level = value;
                }
                else 
                {
                    System.Console.WriteLine("Level must be one or greater.");
                    throw new ArgumentOutOfRangeException(string.Empty, "Level must be one or greater.");
                }
            }
        }

         public Faction Faction {
            get {
                return this.faction;
            }
            set 
                {
                    this.faction = value;
                }
        }

         public string Name {
            get {
                return this.name;
            }
            set {
                if (value >= 3 && value <= 15) 
                {
                    this.name = value;
                }
                else 
                {
                    System.Console.WriteLine("Name must be 3-15 characters.");
                    throw new ArgumentOutOfRangeException(string.Empty, "Name must be 3-15 characters.");
                }
            }
        }

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


        public Necromancer()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
        }

        public Necromancer(string name, int level)
            : this(name, level, DEFAULT_HEALTH_POINTS)
        {
        }

        public Necromancer(string name, int level, int healthPoints)
        {
            this.Name = name;
            this .Level = level;
            this.HealthPoints = healthPoints;
            this.AbilityPoints = DEFAULT_ABILITY_POINTS;
            this.Faction = DEFAULT_FACTION;
            this.BodyArmor = DEFAULT_BODY_ARMOR;
            this.Weapon = DEFAULT_WEAPON;
        }

        public void ShadowRage()
        {
            throw new NotImplementedException();
        }

        public void VampireTouch()
        {
            throw new NotImplementedException();
        }

        public void BoneShield()
        {
            throw new NotImplementedException();
        } 
    }
}