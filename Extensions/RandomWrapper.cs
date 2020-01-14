using System;

namespace AQASkeletronPlus
{
    /// <summary>
    /// A random class for C# that makes the "Next" method inclusive of both bounds.
    /// </summary>
    public class RandomWrapper : Random
    {
        public RandomWrapper(int seed) : base(seed) { }

        /// <summary>
        /// Generates a random integer which is inclusive of both the upper and lower bounds.
        /// </summary>
        public override int Next(int min, int max)
        {
            return base.Next(min, max + 1);
        }
    }
}