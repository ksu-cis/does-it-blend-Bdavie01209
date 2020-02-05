using System;
using System.Collections.Generic;
using System.Text;

namespace DoesItBlend
{
    public abstract class IBlendable
    {
        /// <summary>
        /// a method shared by all iblendable objects showin gwhat happens when blended
        /// </summary>
        /// <returns>what the appearence of the blended object</returns>
        public abstract string Blend();

    }
}
