namespace Decorator.Decorators
{
    using System;
    using System.Diagnostics;
    using Decorator.Components;

    public class TimerDecorator : IModifyBehavior, IDecorator
    {
        private readonly IModifyBehavior modifyBehavior;
        private readonly Stopwatch stopwatch;

        public TimerDecorator(IModifyBehavior modifyBehavior)
        {
            this.modifyBehavior = modifyBehavior ?? throw new ArgumentNullException("IModifyBehavior is null");
            this.stopwatch = new Stopwatch();
        }

        public string Apply(string input)
        {
            this.stopwatch.Start();
            var result = this.modifyBehavior.Apply(input);
            this.stopwatch.Stop();

            Debug.WriteLine(this.stopwatch.ElapsedMilliseconds);

            return result;
        }
    }
}
