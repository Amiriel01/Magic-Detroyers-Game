using MagicDestroyers.Characters;
using MagicDestroyers.Characters.Melee;
using MagicDestroyers.Characters.Spellcasters;
using System.Collections.Generic;

namespace MagicDestroyers
{
    class EntryPoint
    {
        static void Main()
        {
            Random rng = new Random();

            int currentMelee = 0;
            int currentSpellcaster = 0;

            bool GameOver = false;

            List <Character> characters = new List<Character>()
            {
                new Warrior(),
                new Warrior(),
                new Warrior(),
                // new Knight(),
                // new Assassin(),
                new Mage(),
                new Mage(),
                new Mage(),
                // new Necromancer(),
                // new Driud(),
            }

            List<Melee> meleeTeam = new List<Melee>();
            List<Spellcaster> spellTeam = new List<Spellcaster>();

            foreach (var character in characters)
            {
                if (character is Melee)
                {
                    meleeTeam.Add((Melee)character)
                }
                else if (character is Spellcaster)
                {
                    spellTeam.Add((Spellcaster) character)
                }
            }

            while (!GameOver)
            {
                currentMelee = rng.Next(0, meleeTeam.Count);

                currentSpellcaster = rng.Next(0, spellTeam);

                spellTeam[currentSpellcaster].TakeDamage(meleeTeam[0].Attack(), meleeTeam[currentMelee].Name);

                if (!spellTeam[currentSpellcaster].isAlive)
                {
                    meleeTeam[currentMelee].WonBattle();

                    spellTeam.Remove(spellTeam[currentSpellcaster]);

                    if (spellTeam.Count = 0)
                    {
                        Console.WriteLine("Melee team wins.")
                    }
                    else
                    {
                        currentSpellcaster = rng.Next(0, spellTeam.Count);
                    }  
                }

                meleeTeam[currentMelee].TakeDamage(spellTeam[0].Attack(), spellTeam[currentSpellcaster].Name);

                if (!meleeTeam[currentMelee].isAlive)
                {
                    spellTeam[currentSpellcaster].WonBattle();

                    meleeTeam.Remove(meleeTeam[currentMelee]);

                    if (meleeTeam.Count = 0)
                    {
                        Console.WriteLine("Spell team wins.")
                    }
                    else
                    {
                        currentMelee = rng.Next(0, currentMelee.Count);
                    }  
                }
            }
        }

         public void WonBattle()
            {
                this.scores++; 

                if (this.scores % 10 == 0)
                {
                    this.level++;
                }
            }
    }
}