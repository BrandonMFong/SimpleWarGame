using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleWarGame
{
    /// <summary>
    /// Abstract base class for all weapons in the game.
    /// </summary>
    public abstract class Weapon : GameObject
    {
        public Weapon()
        {

        }
        //public double damage;
        
        public double damage = 1.00;
        /// <summary>
        /// Virtual property for class Weapon
        /// </summary>
        public virtual double Damage
        {
            get
            {
                return damage;
            }
            set
            {
                damage = 1.0;
            }
        }
       
    }
}
