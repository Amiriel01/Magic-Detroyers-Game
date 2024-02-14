using System;
using MagicDestroyers.Equipment.Armors.Heavy;
using MagicDestroyers.Equipment.Weapons.Blunt;

namespace MagicDestroyers.Characters.Melee
{
    public class Knight
    {
        private int abilityPoints;
        private int healthPoints;
        private int level;

        private string factions;
        private string name;

        private Chainlink bodyArmor;
        private Hammer weapon;

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
            }
        }

        public Hammer Weapon {
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

        public Knight()
            : this("Smith", 1)
        {
            // this.Name = "Smith";
            // this .Level = 1;
            // this.HealthPoints = 75;
            // this.AbilityPoints = 120;
            // this.Faction = "Melee";
            // this.BodyArmor = new Chainlink();
            // this.Weapon = new Hammer();
        }

         public Knight(string name, int level)
            : this(name, level, 75)
        {
            // this.Name = name;
            // this .Level = level;
            // this.HealthPoints = 75;
            // this.AbilityPoints = 120;
            // this.Faction = "Melee";
            // this.BodyArmor = new Chainlink();
            // this.Weapon = new Hammer();
        }

         public Knight(string name, int level, int healthPoints)
        {
            this.Name = name;
            this .Level = level;
            this.HealthPoints = healthPoints;
            this.AbilityPoints = 120;
            this.Faction = "Melee";
            this.BodyArmor = new Chainlink();
            this.Weapon = new Hammer();
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