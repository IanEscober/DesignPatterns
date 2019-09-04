namespace Flyweight
{
    using System;
    using global::Flyweight.Flyweight;

    public class CharacterContext : IGlyph<char>
    {
        private readonly Character character;
        private readonly string style;

        public CharacterContext(Character character, string style)
        {
            this.character = character;
            this.style = style;
        }

        public char Draw()
        {
            Console.WriteLine($"Applying Style: {this.style}");
            return this.character.Draw();
        }
    }
}
