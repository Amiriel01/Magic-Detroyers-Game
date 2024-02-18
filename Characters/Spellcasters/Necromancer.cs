using System;
using MagicDestroyers.Equipment.Armors.Leather;
using MagicDestroyers.Equipment.Weapons.Sharp;
using MagicDestroyers.Enums;

namespace MagicDestroyers.Characters.Spellcaster
{
    public class Necromancer : Spellcaster
    {
        private readonly LightLeatherVest DEFAULT_BODY_ARMOR = new LightLeatherVest();
        private readonly Sword DEFAULT_WEAPON = new Sword();

        public Necromancer()
            : this(Consts.Necromancer.NAME, 1)
        {
        }

        public Necromancer(string name, int level)
            : this(name, level, Consts.Necromancer.HEALTH_POINTS)
        {
        }

        public Necromancer(string name, int level, int healthPoints)
        {
            base.Name = name;
            base .Level = level;
            base.HealthPoints = healthPoints;
            base.AbilityPoints = Consts.Necromancer.ABILITY_POINTS;
            base.Faction = Faction.Spellcaster;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.Weapon = DEFAULT_WEAPON;
            base.IsAlive = true;
            base.Scores = 0;
        }

        public int ShadowRage()
        {
            return base.Weapon.DamagePoints + 9;
        }

        public int VampireTouch()
        {
            throw new NotImplementedException();
        }

        public int BoneShield()
        {
            return base.BodyArmor.ArmorPoints +9;
        } 

        public override int Attack()
        {
            return this.ShadowRage();
        }

        public override int SpecialAttack()
        {
            return this.VampireTouch();
        }

        public override int Defend()
        {
            return this.BoneShield();
        }
    }
}