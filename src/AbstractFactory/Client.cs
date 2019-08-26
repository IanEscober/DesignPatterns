using System;
using AbstractFactory.Factories;
using AbstractFactory.Products;

namespace AbstractFactory
{
    public class Client
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Standard Maze");
            var standardMaze = Generate(new StandardMazeFactory());
            Console.WriteLine(standardMaze.Move(0));
            Console.WriteLine(standardMaze.Move(2));

            Console.WriteLine("Bonus Maze");
            var bonusMaze = Generate(new BonusMazeFactory());
            Console.WriteLine(bonusMaze.Move(0));
            Console.WriteLine(bonusMaze.Move(3));

            Console.WriteLine("Mixed Maze");
            var mixedMaze = Generate(new StandardMazeFactory(), new BonusMazeFactory());
            Console.WriteLine(mixedMaze.Move(0));
            Console.WriteLine(mixedMaze.Move(1));


            Console.ReadKey();
        }

        private static Maze Generate(params MazeFactory[] mazeFactory)
        {
            var length = mazeFactory.Length;
            var random = new Random();

            var currentRoom = mazeFactory[random.Next(0, mazeFactory.Length)].CreateRoom();
            var nextRoom = mazeFactory[random.Next(0, mazeFactory.Length)].CreateRoom();

            var door = mazeFactory[random.Next(0, mazeFactory.Length)].CreateDoor(currentRoom, nextRoom);
            var wall = mazeFactory[random.Next(0, mazeFactory.Length)].CreateWall();

            currentRoom.SetSide(0, door);
            currentRoom.SetSide(1, wall);
            currentRoom.SetSide(2, wall);
            currentRoom.SetSide(3, wall);
            nextRoom.SetSide(0, wall);
            nextRoom.SetSide(1, wall);
            nextRoom.SetSide(2, door);
            nextRoom.SetSide(3, wall);

            var maze = mazeFactory[random.Next(0, mazeFactory.Length)].CreateMaze(new[] { currentRoom, nextRoom });
            return maze;
        }
    }
}
