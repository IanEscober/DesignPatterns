namespace AbstractFactory.Products.Room
{
    public interface IRoom
    {
        ISide GetSide(int direction);
        void SetSide(int direction, ISide side);
    }
}
