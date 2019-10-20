namespace Interpreter.Contexts
{
    using System.Collections.Generic;

    public class MaskAdress : IContext<string, ICollection<int>>
    {
        public MaskAdress(string maskAdress)
        {
            this.Base = maskAdress;
            this.Translation = new List<int>();
        }

        public string Base { get; set; }
        public ICollection<int> Translation { get; set; }
    }
}
