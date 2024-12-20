namespace HigherOrLower.Cli.Helpers
{
    /// <summary>
    /// A Simple number generator
    /// </summary>
    internal class NumberGenerator
    {
        /// <summary>
        /// Generate a number between a lower and upper bound
        /// </summary>
        /// <param name="lowerBound">The minimum Number (inclusive)</param>
        /// <param name="upperBound">The maximum Number (exclusive)</param>
        /// <returns></returns>
        public static int Generate(int lowerBound, int upperBound)
        {
            var generator = new Random();

            return generator.Next(lowerBound, upperBound);
        }
    }
}
