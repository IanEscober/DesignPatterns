namespace Interpreter
{
    using System;
    using System.Linq;
    using Interpreter.Contexts;
    using Interpreter.Expressions;

    public class Client
    {
        public static void Main(string[] args)
        {
            var maskDecoders = new MaskDecoder[] { new NetworkMaskDecoder(), new HostMaskDecoder() };
            var maskAdress = new MaskAdress("255.0.0.0");

            foreach (var maskDecoder in maskDecoders)
            {
                maskDecoder.Interpret(maskAdress);

            }

            Console.WriteLine($"Decoded Network Address: {maskAdress.Translation.ElementAt(0)}");
            Console.WriteLine($"Decoded Host Address: {maskAdress.Translation.ElementAt(1)}");

            Console.ReadKey();
        }
    }
}
