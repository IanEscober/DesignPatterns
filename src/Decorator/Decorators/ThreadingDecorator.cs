namespace Decorator.Decorators
{
    using System;
    using Decorator.Components;
    using System.Threading.Tasks;

    public class ThreadingDecorator : IModifyBehavior, IDecorator
    {
        private readonly IModifyBehavior modifyBehavior;

        public ThreadingDecorator(IModifyBehavior modifyBehavior)
        {
            this.modifyBehavior = modifyBehavior ?? throw new ArgumentNullException("IModifyBehavior is null");
        }

        public string Apply(string input)
        {
            input = input ?? throw new ArgumentNullException("input is null");

            var task = Task.Run(() => this.modifyBehavior.Apply(input));

            task.Wait();

            return task.Result;
        }
    }
}
