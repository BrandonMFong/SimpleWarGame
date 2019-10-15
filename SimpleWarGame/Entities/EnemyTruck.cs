using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleWarGame
{
    /// <summary>
    /// The EnemyTruck class.  Low Health and Armor. Uses Missle Ammo.
    /// </summary>
    public class EnemyTruck : Entity
    {
        /// <summary>
        /// EnemyTruck Constructor. Takes no arguments.
        /// Initalizies an EnemyTruck to default values.
        /// </summary>
        public EnemyTruck()
        {
            this.Health = 70;
            this.Armor = 70;
            this.Weapon = new MissleAmmo();
        }

        
    }
}
