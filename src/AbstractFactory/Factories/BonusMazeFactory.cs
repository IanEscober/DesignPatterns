using AbstractFactory.Products.Door;
using AbstractFactory.Products.Room;
using AbstractFactory.Products.Wall;

namespace AbstractFactory.Factories
{
    public class BonusMazeFactory : MazeFactory
    {
        public override IDoor CreateDoor(IRoom currentRoom, IRoom nextRoom)
        {
            return new LockedDoor(currentRoom, nextRoom);
        }

        public override IRoom CreateRoom()
        {
            return new BonusRoom();
        }

        public override IWall CreateWall()
        {
            return new SecretWall();
        }
    }
}
