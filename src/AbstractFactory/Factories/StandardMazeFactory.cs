using AbstractFactory.Products.Door;
using AbstractFactory.Products.Room;
using AbstractFactory.Products.Wall;

namespace AbstractFactory.Factories
{
    public class StandardMazeFactory : MazeFactory
    {
        public override IDoor CreateDoor(IRoom currentRoom, IRoom nextRoom)
        {
            return new StandardDoor(currentRoom, nextRoom);
        }

        public override IRoom CreateRoom()
        {
            return new StandardRoom();
        }

        public override IWall CreateWall()
        {
            return new StandardWall();
        }
    }
}
