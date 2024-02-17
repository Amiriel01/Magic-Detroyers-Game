using System;

namespace MagicDestroyers.Characters.Melee
{
    public class Melee : Character
    {
        private int abilityPoints; 

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
    }
}