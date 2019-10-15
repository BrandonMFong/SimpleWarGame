using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleWarGame
{
    /// <summary>
    /// ExplodeAmmo is a type of Weapon. 
    /// Has no bonus to attack.
    /// Inprecise (wide range) but high damage.
    /// </summary>
    public class ExplodeAmmo : Weapon
    {
        /// <summary>
        /// ExplodeAmmo Constructor. Takes no arguments.
        /// Sets default values.
        /// </summary>
        public ExplodeAmmo()
        {
            this.damage = 40.00;
        }

        //override public double Damage
        //{
        //    set
        //    {
        //        base.damage = 40.00;
        //    }
        //}
    }
}
