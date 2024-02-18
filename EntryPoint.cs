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

            Melee currentMelee;
            Spellcaster currentSpellcaster;

            bool GameOver = false;

            List <Character> characters = new List<Character>()
            {
                new Warrior(),
                new Knight(),
                new Assassin(),
                new Mage(),
                new Necromancer(),
                new Driud(),
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
                currentMelee = meleeTeam[rng.Next(0, meleeTeam.Count)];

                currentSpellcaster = spellTeam[rng.Next(0, spellTeam.Count)];

                spellTeam[currentSpellcaster].TakeDamage(meleeTeam[0].Attack(), meleeTeam[currentMelee].Name);

                currentSpellcaster.TakeDamage(currentMelee.Attack(), currentMelee.Name, currentMelee.GetType().ToString());

                if (![currentSpellcaster].isAlive)
                {
                    currentMelee.WonBattle();

                    spellTeam.Remove(currentSpellcaster);

                    if (spellTeam.Count == 0)
                    {
                        Tools.ColorfulWriteLine("\nMelee team wins!", ConsoleColor.Red);
                        break;
                    }
                    else
                    {
                        currentSpellcaster = rng.Next(0, spellTeam.Count);
                    }  
                }

                meleeTeam[currentMelee].TakeDamage(spellTeam[0].Attack(), spellTeam[currentSpellcaster].Name);

                if (!currentMelee.isAlive)
                {
                    currentSpellcaster.WonBattle();

                    meleeTeam.Remove(currentMelee);

                    if (meleeTeam.Count == 0)
                    {
                        Tools.ColorfulWriteLine("\nSpell team wins!", ConsoleColor.Red);
                        break;
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