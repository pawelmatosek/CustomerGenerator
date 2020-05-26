namespace ConsoleApp4.Classes
{
    public static class Consts
    {
        /// <summary>
        /// Number of letters in English alphabet 
        /// </summary>
        public static int LettersInAlphabet = 26;

        /// <summary>
        /// First letter in ASCII is 65 
        /// </summary>
        public static int SkipToAsciiValues = 65;

        /// <summary>
        /// Assumed maximal human age
        /// </summary>
        public static int MaxHumanAge = 120;

        /// <summary>
        /// Maximal value from we will randomize values
        /// </summary>
        public static int MaxRandomLegth = 50;

        /// <summary>
        /// Number of customers that will be generated
        /// </summary>
        public static int RandomCustomers = 10;

        /// <summary>
        /// Minimal value that we will randomize from
        /// </summary>
        public const int MinimalRandomNumber = 10;

        /// <summary>
        /// File that will contain generated Customers 
        /// </summary>
        public const string CustomersFile = "Customers.txt";
    }
}
