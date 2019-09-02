namespace Decorator.Decorators
{
    using System;
    using System.Diagnostics;
    using Decorator.Components;

    public class NullDecorator : IModifyBehavior, IDecorator
    {
        private readonly IModifyBehavior modifyBehavior;

        public NullDecorator(IModifyBehavior modifyBehavior)
        {
            this.modifyBehavior = modifyBehavior ?? throw new ArgumentNullException("IModifyBehavior is null");
        }

        public string Apply(string input)
        {
            Debug.WriteLine("Deferring Modifying Behaviors");

            return input;
        }
    }
}
