namespace Flyweight.Flyweight
{
    public class Character : IGlyph<char>
    {
        public int Code { get; }

        public Character(int code)
        {
            this.Code = code;
        }

        public char Draw()
        {
            return (char)this.Code;
        }
    }
}
