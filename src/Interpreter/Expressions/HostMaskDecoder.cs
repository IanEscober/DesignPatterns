namespace Interpreter.Expressions
{
    using System.Collections.Generic;
    using Interpreter.Contexts;

    public class HostMaskDecoder : MaskDecoder
    {
        public override void Interpret(IContext<string, ICollection<int>> context)
        {
            var hostAdress = context.Base.Split('.')[1];

            if (hostAdress == "0")
            {
                context.Translation.Add(10);
            }
        }
    }
}
