using MagicDestroyers.Enums;
using System;
using MagicDestroyers.Characters.Interfaces;

namespace MagicDestroyers.Characters
{
    public abstract class Characters : IAttack, IDefend
    {
        private int healthPoints;
        private int level;
        private int scores;
        private Faction faction;
        private string name;

        private bool isAlive;

        private Armor bodyArmor;
        private Weapon weapon;

        public int scores 
        {
            get
            {
                return this.scores;
            }
            private set 
            {
                this.scores = value;
            }
        }

        public bool isAlive
        {
            get
            {
                return this.isAlive;
            }
            private set
            {
                this.isAlive = value;
            }
        }

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

        public abstract int Defend();

        public abstract int Attack();

        public abstract int SpecialAttack();

        public void TakeDamage(int damage, string attackerName)
        {
            if (this.Defend() < damage)
            {
                this.healthPoints = this.healthPoints - damage + this.Defend;

                if (this.healthPoints <= 0)
                {
                    this.isAlive = false;
                }
            }
            else
            {
                Console.WriteLine("Damage was not hire enough to harm player.")
            }

            if (!this.isAlive)
            {
                Console.WriteLine($"{this.name} recieved {damage} damage from {attackerName} and is now dead.")
            }
            else
            {
                Console.WriteLine($"{this.name} recieved {damage} damage from {attackerName} and now has {this.healthPoints} health points left.")
            }
        }
    }
}