using AbstractFactory.Products.Door;
using AbstractFactory.Products.Room;

namespace AbstractFactory.Products
{
    public class Maze
    {
        private readonly IRoom[] rooms;
        private IRoom previousRoom;
        private IRoom currentRoom;

        public Maze(IRoom[] rooms)
        {
            this.rooms = rooms;
            this.previousRoom = rooms[0];
            this.currentRoom = rooms[0];
        }

        public string Move(int direction)
        {
            var side = this.currentRoom.GetSide(direction);

            if (side is IDoor)
            {
                var door = side as IDoor;
                (this.previousRoom, this.currentRoom) = door.GetConnectingRooms();
            }

            return side.Enter();
        }
    }
}
