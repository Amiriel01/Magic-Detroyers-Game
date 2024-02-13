using System;
using MagicDestroyers.Equipment.Armors.Heavy;
using MagicDestroyers.Equipment.Weapons.Sharp;

namespace MagicDestroyers.Characters.Melee
{
    public class Warrior
    {
        //private code is for the field only and cannot be seen outside the class
        private int abilityPoints;
        private int healthPoints;
        private int level;

        private string factions;
        private string name;

        private Chainlink bodyArmor;
        private Axe weapon;

    //public code can be seen outside the object and passed as props
        public int abilityPoints {
            get {
                return abilityPoints;
            }
            set {
                
            }
        }

        public Warrior()
        {

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