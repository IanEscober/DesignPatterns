namespace Flyweight
{
    using System;

    public class Client
    {
        public static void Main(string[] args)
        {
            var glyphFactory = new GlyphFactory();

            var randomCharacter = glyphFactory.GetCharacter(new Random().Next(0, 128));
            var styledRandomCharacter = new CharacterContext(randomCharacter, "Upper");

            Console.WriteLine(styledRandomCharacter.Draw());

            Console.ReadKey();
        }
    }
}
