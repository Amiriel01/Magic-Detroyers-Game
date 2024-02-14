using System;
using MagicDestroyers.Equipment.Armors.Leather;
using MagicDestroyers.Equipment.Weapons.Blunt;

namespace MagicDestroyers.Characters.Spellcaster
{
    public class Druid
    {
        private int abilityPoints;
        private int healthPoints;
        private int level;

        private string factions;
        private string name;

        private LightLeatherVest bodyArmor;
        private Staff weapon;

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

         public LightLeatherVest BodyArmor {
            get {
                return this.bodyArmor;
            }
            set {
                this.bodyArmor = value;
                // if (value >= 1) 
                // {
                //     bodyArmor = value;
                // }
                // else 
                // {
                //     System.Console.WriteLine("Body Armour must be one or greater.");
                //     throw new ArgumentOutOfRangeException(string.Empty, "Body Armour must be one or greater.");
                // }
            }
        }

        public Staff Weapon {
            get {
                return this.weapon;
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


        public Driud()
            : this("Oak", 1)
        {
            // this.Name = "Oak";
            // this .Level = 1;
            // this.HealthPoints = 50;
            // this.AbilityPoints = 60;
            // this.Faction = "Spellcaster";
            // this.BodyArmor = new LightLeatherVest();
            // this.Weapon = new Staff();
        }

        public Driud(string name, int level)
            : this(name, level, 50)
        {
            // this.Name = name;
            // this .Level = level;
            // this.HealthPoints = 50;
            // this.AbilityPoints = 60;
            // this.Faction = "Spellcaster";
            // this.BodyArmor = new LightLeatherVest();
            // this.Weapon = new Staff();
        }

        public Driud(string name, int level, int healthPoints)
        {
            this.Name = name;
            this .Level = level;
            this.HealthPoints = healthPoints;
            this.AbilityPoints = 60;
            this.Faction = "Melee";
            this.BodyArmor = new LightLeatherVest();
            this.Weapon = new Staff();
        }

        public void Moonfire()
        {
            throw new NotImplementedException();
        }

        public void Starburst()
        {
            throw new NotImplementedException();
        }

        public void OneWithTheNature()
        {
            throw new NotImplementedException();
        }
    }
}