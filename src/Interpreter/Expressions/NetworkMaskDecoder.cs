namespace Interpreter.Expressions
{
    using System.Collections.Generic;
    using Interpreter.Contexts;

    public class NetworkMaskDecoder : MaskDecoder
    {
        public override void Interpret(IContext<string, ICollection<int>> context)
        {
            var networkAdress = context.Base.Split('.')[0];

            if (networkAdress == "255")
            {
                context.Translation.Add(192);
            }
        }
    }
}
