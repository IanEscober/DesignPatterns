using AbstractFactory.Products.Room;

namespace AbstractFactory.Products.Door
{
    public class StandardDoor : IDoor
    {
        private readonly IRoom currentRoom;
        private readonly IRoom nextRoom;

        public StandardDoor(IRoom currentRoom, IRoom nextRoom)
        {
            this.currentRoom = currentRoom;
            this.nextRoom = nextRoom;
        }

        public (IRoom CurrentRoom, IRoom NextRoom) GetConnectingRooms()
        {
            return (this.currentRoom, this.nextRoom);
        }

        public string Enter()
        {
            return "Opening Door";
        }
    }
}
