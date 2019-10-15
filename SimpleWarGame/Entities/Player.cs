using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleWarGame
{
    /// <summary>
    /// The Player class.  High Health and Armor. Uses various kinds of Ammo selected by the player.
    /// </summary>
    public class Player : Entity
    {
        /// <summary>
        /// Player Constructor. Takes no arguments.
        /// Initalizies an Player to default values.
        /// </summary>
        public Player()
        {
            this.Health = 100;
            this.Armor = 100;
        }


        /// <summary>
        /// Allows the player to select which weapon they want to use.
        /// </summary>
        /// <param name="type">The weapon they would like to use. Check the weaponType enum for possible options.</param>
        public void SelectWeapon(weaponType type)
        {
            switch (type)
            {
                case weaponType.explosive:
                    this.Weapon = new ExplodeAmmo();
                    break;
                case weaponType.piercing:
                    this.Weapon = new PiercingAmmo();
                    break;
            }
        }
        /*
         * player is trying to access weapon.
         * from where?  the entity?  
         * Entity should use the methods of the method to use in the attack method
         */


        /// <summary>
        /// Heals the player to maximum health.
        /// </summary>
        public void Heal()
        {
            this.Health = this.MaxHealth;
        }
        
    }
}