namespace AbstractFactory.Products.Wall
{
    public class SecretWall : IWall
    {
        public SecretWall()
        {
        }

        public string Enter()
        {
            return "This Wall Can Be Broken";
        }
    }
}
