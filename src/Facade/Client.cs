namespace Facade
{
    using System;

    public class Client
    {
        public static void Main(string[] args)
        {
            var facade = new StringFacade();

            Console.WriteLine($"Before: {facade.TheString}");
            facade.Populate();
            Console.WriteLine($"After: {facade.TheString}");

            Console.ReadKey();
        }
    }
}
