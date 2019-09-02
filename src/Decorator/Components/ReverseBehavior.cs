namespace Decorator.Components
{
    using System;
    using System.Linq;

    public class ReverseBehavior : IModifyBehavior
    {
        public string Apply(string input)
        {
            var charArray = input
                .Reverse()
                .ToArray();
            return new string(charArray);
        }
    }
}
