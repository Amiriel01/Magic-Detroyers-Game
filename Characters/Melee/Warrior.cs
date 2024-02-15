using System;
using MagicDestroyers.Equipment.Armors.Heavy;
using MagicDestroyers.Equipment.Weapons.Sharp;
using MagicDestroyers.Enums;

namespace MagicDestroyers.Characters.Melee
{
    public class Warrior
    {
        //private code is for the fields and cannot be seen outside the class
        private const string DEFAULT_NAME = "Jack";
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTH_POINTS = 110;
        private const int DEFAULT_ABILITY_POINTS = 100;
        private const Faction DEFAULT_FACTION = Faction.Melee;

        private readonly Chainlink DEFAULT_BODY_ARMOR = new Chainlink();
        private readonly Axe DEFAULT_WEAPON = new Axe();

        private int abilityPoints;
        private int healthPoints;
        private int level;

        private Faction faction;
        private string name;

        private Chainlink bodyArmor;
        private Axe weapon;

    //public code can be seen outside the object and passed as props
    //value gives the current value of the property to the height field
    //get (read) and set (write) are used to get and set the value of the property
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

         public string Faction {
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