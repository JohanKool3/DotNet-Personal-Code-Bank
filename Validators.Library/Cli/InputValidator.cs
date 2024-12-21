namespace Validators.Library.Cli
{
    public class InputValidator
    {
        /// <summary>
        /// Validates a users input, returns -1 if invalid
        /// </summary>
        /// <param name="option"></param>
        /// <param name="optionAmount"></param>
        /// <returns></returns>
        public static int ValidateOption(string? option, int lowerBound, int upperBound)
        {
            // Must not be null
            if (option is null)
            {
                return -1;
            }

            var successful = int.TryParse(option, out int chosenIndex);
            if (!successful)
            {
                return -1;
            }

            if (chosenIndex < lowerBound || chosenIndex > upperBound)
            {
                return -1;
            }

            return chosenIndex;
        }

        public static bool ValidateOption(string? option, float lowerBound, float upperBound)
        {
            // Must not be null
            if (option is null)
            {
                return false;
            }

            var successful = float.TryParse(option, out float chosenIndex);
            if (!successful)
            {
                return false;
            }

            if (chosenIndex < lowerBound || chosenIndex > upperBound)
            {
                return false;
            }

            return true;
        }
    }
}
