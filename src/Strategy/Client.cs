namespace Strategy
{
    using System;
    using Strategy.Contexts;
    using Strategy.Strategies;

    public class Client
    {
        public static void Main(string[] args)
        {
            var numericFilter = new NumericTinSanitizer();
            var tinValidator = new TinValidator(numericFilter);
            Console.WriteLine(tinValidator.ValidateTin("12Ga-b342"));

            var alphabeticFilter = new AlphabeticalTinSanitizer();
            tinValidator = new TinValidator(alphabeticFilter);
            Console.WriteLine(tinValidator.ValidateTin("12Ga-b342"));

            Console.ReadKey();
        }
    }
}
