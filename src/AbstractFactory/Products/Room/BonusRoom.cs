namespace AbstractFactory.Products.Room
{
    public class BonusRoom : IRoom
    {
        private ISide[] sides;

        public BonusRoom()
        {
            this.sides = new ISide[4];
        }

        public ISide GetSide(int direction)
        {
            return this.sides[direction];
        }

        public void SetSide(int direction, ISide side)
        {
            this.sides[direction] = side;
        }
    }
}
