using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleWarGame
{
    /// <summary>
    /// Abstract Base class for all character agents (AKA Entities).
    /// Every Entity has Health, Armor, and MaxHealth properties.
    /// Every Entity has Attack and Defend methods.
    /// </summary>
    public abstract class Entity : GameObject //Entity inherits stuff from GameObject
    {
        public double defense   = 0.00;
        private double health   = 0.00;
        private double armor    = 0.00;
        /* TODO make a default constructor */

        public Entity()
        {

        }
        

        public double Health
        {
            get
            {
                return health;
            }
            set
            {
                if (value > 100)    health = 100;
                else if (value < 0) health = 0;
                else                health = value;
            }
        }
        public double Armor
        {
            get
            {
                return armor;
            }
            set
            {
                if (value > 100)    armor = 100;
                else if (value < 0) armor = 0;
                else                armor = value;
            }
        }

        public double MaxHealth = 100;
        public Weapon Weapon;
        

        public void Attack (Entity p1)
            // This attacks another player
        {
            p1.Health = p1.Health - this.Weapon.Damage; // i don't think this.weapon.damage is going to return anything of type weapon
        }
        public void Defend(Entity p1) { } // Implement if you have time
    }
}
