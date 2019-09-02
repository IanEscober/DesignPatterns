namespace Decorator.Decorators
{
    using System;
    using System.Diagnostics;
    using Decorator.Components;

    public class ExceptionDecorator : IModifyBehavior, IDecorator
    {
        private readonly IModifyBehavior modifyBehavior;

        public ExceptionDecorator(IModifyBehavior modifyBehavior)
        {
            this.modifyBehavior = modifyBehavior ?? throw new ArgumentNullException("IModifyBehavior is null");
        }

        public string Apply(string input)
        {
            var result = default(string);

            try
            {
                result = this.modifyBehavior.Apply(input);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }

            return result;
        }
    }
}
