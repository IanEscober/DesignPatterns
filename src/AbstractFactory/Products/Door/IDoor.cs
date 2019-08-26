using AbstractFactory.Products.Room;

namespace AbstractFactory.Products.Door
{
    public interface IDoor : ISide
    {
        (IRoom CurrentRoom, IRoom NextRoom) GetConnectingRooms();
    }
}
