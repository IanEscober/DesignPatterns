using System;
using FactoryMethod.Creators;

namespace FactoryMethod
{
    public class Client
    {
        public static void Main(string[] args)
        {
            var basket = new BasketAggregate(new Guid(), 3);
            var basketRepo = basket.CreateRepository();
            var basketFromCache = basketRepo.Set(basket);
            Console.WriteLine(basketFromCache.Count);

            var product = new ProductAggregate(new Guid(), "Sample");
            var productRepo = product.CreateRepository();
            var productFromDb = productRepo.Set(product);
            Console.WriteLine(productFromDb.ProductName);

            Console.ReadKey();
        }
    }
}
