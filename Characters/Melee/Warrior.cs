using System;
using MagicDestroyers.Equipment.Armors.Heavy;
using MagicDestroyers.Equipment.Weapons.Sharp;

namespace MagicDestroyers.Characters.Melee
{
    public class Warrior
    {
        //private code is for the fields and cannot be seen outside the class
        private int abilityPoints;
        private int healthPoints;
        private int level;

        private string factions;
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

         public string Factions {
            get {
                return this.factions;
            }
            set {
                if (value === 'Melee' || value === 'Spellcaster') 
                {
                    this.faction = value;
                }
                else 
                {
                    System.Console.WriteLine("Faction must be Warrior or Spellcaster");
                    throw new ArgumentOutOfRangeException(string.Empty, "Faction must be Warrior or Spellcaster");
                }
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
                // if (value >= 1) 
                // {
                //     this.bodyArmor = value;
                // }
                // else 
                // {
                //     System.Console.WriteLine("Body Armour must be one or greater.");
                //     throw new ArgumentOutOfRangeException(string.Empty, "Body Armour must be one or greater.");
                // }
            }
        }

        public Axe Weapon {
            get {
                return weapon;
            }
            set {
                this.weapon = value;
                // if (value >= 1) 
                // {
                //     weapon = value;
                // }
                // else 
                // {
                //     System.Console.WriteLine("Weapon must be one or greater.");
                //      throw new ArgumentOutOfRangeException(string.Empty, "Weapon must be one or greater.");
                // }
            }
        }


        public Warrior()
            : this("Jack", 1)
        {
            // this.Name = "Jack";
            // this .Level = 1;
            // this.HealthPoints = 120;
            // this.AbilityPoints = 60;
            // this.Faction = "Melee";
            // this.BodyArmor = new Chainlink();
            // this.Weapon = new Axe();
        }

        public Warrior(string name, int level)
            : this(name, level, 120)
        {
            // this.Name = name;
            // this .Level = level;
            // this.HealthPoints = 120;
            // this.AbilityPoints = 60;
            // this.Faction = "Melee";
            // this.BodyArmor = new Chainlink();
            // this.Weapon = new Axe();
        }

        public Warrior(string name, int level, int healthPoints)
        {
            this.Name = name;
            this .Level = level;
            this.HealthPoints = healthPoints;
            this.AbilityPoints = 60;
            this.Faction = "Melee";
            this.BodyArmor = new Chainlink();
            this.Weapon = new Axe();
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