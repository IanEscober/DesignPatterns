using AbstractFactory.Products;
using AbstractFactory.Products.Door;
using AbstractFactory.Products.Room;
using AbstractFactory.Products.Wall;

namespace AbstractFactory.Factories
{
    public abstract class MazeFactory
    {
        public abstract IDoor CreateDoor(IRoom currentRoom, IRoom nextRoom);
        public abstract IRoom CreateRoom();
        public abstract IWall CreateWall();

        public virtual Maze CreateMaze(IRoom[] rooms)
        {
            return new Maze(rooms);
        }
    }
}
