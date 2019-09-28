namespace State
{
    using System;
    using State.Contexts;

    public class Client
    {
        public static void Main(string[] args)
        {
            var random = new Random();

            for (int i = 0; i < 10; i++)
            {
                var angle = random.Next(0, 90);
                var level = random.Next(0, 100);
                var binService = new BinService(angle, level);

                binService.Validate();
            }
            
            Console.ReadKey();
        }
    }
}
