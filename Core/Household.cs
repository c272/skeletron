namespace AQASkeletronPlus
{
    /// <summary>
    /// Represents a single household on a settlement.
    /// </summary>
    public class Household
    {
        //Publicly accessible properties.
        public Vector2 Position { get; protected set; }
        public double ChanceToEatOut { get; protected set; }

        public Household(Vector2 pos)
        {
            Position = pos;

            //Generate a random chance to eat out.
            ChanceToEatOut = Simulation.Random.NextDouble();
        }

        /// <summary>
        /// Calculates whether this household will eat out.
        /// </summary>
        public bool EatsOut()
        {
            return (Simulation.Random.NextDouble() <= ChanceToEatOut);
        }
    }
}