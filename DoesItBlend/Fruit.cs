using System;
using System.Collections.Generic;
using System.Text;

namespace DoesItBlend
{
    /// <summary>
    /// A base class representing fruit
    /// </summary>
    public abstract class Fruit : IBlendable
    {

        /// <summary>
        /// base case for fruits being blended
        /// </summary>
        /// <returns>a string of what most fruits look like</returns>
        public abstract override string Blend();

    }
}
