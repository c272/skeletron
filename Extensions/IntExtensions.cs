using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQASkeletronPlus
{
    /// <summary>
    /// Extends with extra integer methods.
    /// </summary>
    public static class IntExtensions
    {
        /// <summary>
        /// Clamps an integer between a minimum and maximum value, inclusive.
        /// </summary>
        public static void Clamp(this int x, int min, int max)
        {
            if (x < min) { x = min; }
            if (x > max) { x = max; }
        }
    }
}
