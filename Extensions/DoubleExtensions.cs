using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQASkeletronPlus
{
    /// <summary>
    /// A set of extensions for the built in "Double" class that extends functionality.
    /// </summary>
    public static class DoubleExtensions
    {
        /// <summary>
        /// Cumulatively sums the array of doubles provided.
        /// </summary>
        public static IEnumerable<double> CumulativeSum(this IEnumerable<double> sequence)
        {
            double sum = 0;
            foreach (var item in sequence)
            {
                sum += item;
                yield return sum;
            }
        }
    }
}
