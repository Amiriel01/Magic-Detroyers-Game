using MagicDestroyers.Enums;
using System;
using MagicDestroyers.Characters.Interfaces;

namespace MagicDestroyers.Characters
{
    public abstract class Characters : IAttack, IDefend
    {
        private int healthPoints;
        private int level;
        private Faction faction;
        private string name;

        private Armor bodyArmor;
        private Weapon weapon;

         public Armor BodyArmor {
            get {
                return this.bodyArmor;
            }
            set {
                this.bodyArmor = value;
            }
        }

        public Weapon Weapon {
            get {
                return weapon;
            }
            set {
                this.weapon = value;
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

        public abstract void Defend();

        public abstract void Attack();

        public abstract void SpecialAttack();
    }
}