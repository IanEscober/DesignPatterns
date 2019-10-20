namespace Interpreter.Expressions
{
    using System.Collections.Generic;
    using Interpreter.Contexts;

    public abstract class MaskDecoder
    {
        public abstract void Interpret(IContext<string, ICollection<int>> context);
    }
}
