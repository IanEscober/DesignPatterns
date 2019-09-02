namespace Decorator
{
    using System;
    using Decorator.Components;
    using Decorator.Decorators;

    public class Client
    {
        public static void Main(string[] args)
        {
            var reverser = new ReverseBehavior();
            var exceptionDecorator = new ExceptionDecorator(reverser);
            var loggingDecorator = new LoggingDecorator(exceptionDecorator);
            var threadingDecorator = new ThreadingDecorator(loggingDecorator);
            var timerDecorator = new TimerDecorator(threadingDecorator);
            //var nullDecorator = new NullDecorator(timerDecorator);

            var result = timerDecorator.Apply("abc");
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
