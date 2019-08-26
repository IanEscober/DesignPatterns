using AbstractFactory.Products.Room;

namespace AbstractFactory.Products.Door
{
    public class LockedDoor : IDoor
    {
        private readonly IRoom currentRoom;
        private readonly IRoom lockedRoom;

        public LockedDoor(IRoom currentRoom, IRoom lockedRoom)
        {
            this.currentRoom = currentRoom;
            this.lockedRoom = lockedRoom;
        }

        public (IRoom CurrentRoom, IRoom NextRoom) GetConnectingRooms()
        {
            return (this.currentRoom, this.lockedRoom);
        }


        public string Enter()
        {
            return "This Door Requires A Key";
        }
    }
}
