using System;
using MagicDestroyers.Equipment.Armors.Light;
using MagicDestroyers.Equipment.Weapons.Blunt;
using MagicDestroyers.Enums;

namespace MagicDestroyers.Characters.Spellcaster
{
    public class Mage : Spellcaster
    {
        private const string DEFAULT_NAME = "Rain";
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTH_POINTS = 70;
        private const int DEFAULT_ABILITY_POINTS = 130;
        private const Faction DEFAULT_FACTION = Faction.Spellcaster;

        private readonly ClothRobe DEFAULT_BODY_ARMOR = new ClothRobe();
        private readonly Staff DEFAULT_WEAPON = new Staff();

        private ClothRobe bodyArmor;
        private Staff weapon;

         public ClothRobe BodyArmor {
            get {
                return this.bodyArmor;
            }
            set {
                this.bodyArmor = value;
            }
        }

        public Staff Weapon {
            get {
                return this.weapon;
            }
            set {
                this.weapon = value;
            }
        }


        public Mage()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
        }

         public Mage(string name, int level)
            : this(name, level, DEFAULT_HEALTH_POINTS)
        {
        }

         public Mage(string name, int level, int healthPoints)
        {
            this.Name = name;
            this .Level = level;
            this.HealthPoints = healthPoints;
            this.AbilityPoints = DEFAULT_ABILITY_POINTS;
            this.Faction = DEFAULT_FACTION;
            this.BodyArmor = DEFAULT_BODY_ARMOR;
            this.Weapon = DEFAULT_WEAPON;
        }

        public void ArcaneWrath()
        {
            throw new NotImplementedException();
        }

        public void Firewall()
        {
            throw new NotImplementedException();
        }

        public void Meditation()
        {
            throw new NotImplementedException();
        } 

        public override void Attack()
        {
            throw new NotImplementedException();
        }

        public override void SpecialAttack()
        {
            throw new NotImplementedException();
        }

        public override void Defend()
        {
            throw new NotImplementedException();
        }
    }
}