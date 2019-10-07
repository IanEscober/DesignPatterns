namespace Visitor
{
    using System;
    using System.Collections.Generic;
    using Visitor.Elements;
    using Visitor.Visitors;

    public class Client
    {
        public static void Main(string[] args)
        {
            var bindings = new List<IBinding<int>> { new BlobBinding<int>(), new QueueBinding<int>() };
            var inputCollector = new InCollector<int>(default(int));
            var outputCollector = new OutCollector<int>(default(int));

            var binder = new Binder<int>(bindings);
            binder.Accept(inputCollector);
            binder.Accept(outputCollector);

            Console.ReadKey();
        }
    }
}
