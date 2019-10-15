using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleWarGame
{
    /// <summary>
    /// Abstract Base Class for all other classes.
    /// Gives every inherited class the Name property.
    /// </summary>
    /// Just going to set every member as public and will define privates later
    public abstract class GameObject
    {
        public string Name { get; set; }

        //public abstract  Weapon();
        //public abstract double Damage { get; }
    }
}
