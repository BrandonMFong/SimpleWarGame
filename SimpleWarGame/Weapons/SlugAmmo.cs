using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleWarGame
{
    /// <summary>
    /// SlugAmmo is a type of Weapon. 
    /// Has low bonus to attack.
    /// Percise but moderate damage.
    /// </summary>
    public class SlugAmmo : Weapon
    {
        /// <summary>
        /// SlugAmmo Constructor. Takes no arguments.
        /// Sets default values.
        /// </summary>
        public SlugAmmo()
        {
            this.damage = 30.00;
        }
        //override public double Damage
        //{
        //    set
        //    {
        //        damage = value;
        //    }
        //}
    }
}
