namespace Decorator.Decorators
{
    using System;
    using System.Diagnostics;
    using Decorator.Components;

    public class LoggingDecorator : IModifyBehavior, IDecorator
    {
        private readonly IModifyBehavior modifyBehavior;

        public LoggingDecorator(IModifyBehavior modifyBehavior)
        {
            this.modifyBehavior = modifyBehavior ?? throw new ArgumentNullException("IModifyBehavior is null");
        }

        public string Apply(string input)
        {
            Debug.WriteLine("Before");
            var result = this.modifyBehavior.Apply(input);
            Debug.WriteLine("After");

            return result;
        }
    }
}
