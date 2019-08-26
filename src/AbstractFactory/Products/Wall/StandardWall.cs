namespace AbstractFactory.Products.Wall
{
    public class StandardWall : IWall
    {
        public StandardWall()
        {
        }

        public string Enter()
        {
            return "A Wall Is Blocking";
        }
    }
}
