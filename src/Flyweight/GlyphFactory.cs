namespace Flyweight
{
    using System.Collections.Generic;
    using System.Linq;
    using global::Flyweight.Flyweight;

    public class GlyphFactory
    {
        private readonly HashSet<Character> characters;
        private const int CHAR_COUNT = 128;

        public GlyphFactory()
        {
            this.characters = new HashSet<Character>();
            this.GenerateCharacters();
        }

        private void GenerateCharacters()
        {
            for (int i = 0; i < CHAR_COUNT; i++)
            {
                this.characters.Add(new Character(i));
            }
        }

        public Character GetCharacter(int code)
        {
            var character = this.characters.SingleOrDefault(c => c.Code == code);

            if (character is null)
            {
                var newCharacter = new Character(code);
                this.characters.Add(newCharacter);
                return newCharacter;
            }

            return character;
        }

    }
}
