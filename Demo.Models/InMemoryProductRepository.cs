using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models
{
    public class InMemoryProductRepository : IProductRepository
    {
        public Dictionary<int, Product> _productsDictionary;

        public InMemoryProductRepository()
        {
            _productsDictionary = new Dictionary<int, Product>
            {
                { 1, new Product { Title = "Ball", Price = 12.50m } },
                { 2, new Product { Title = "Board Game", Price = 55.25m } },
                { 3, new Product { Title = "Bicycle", Price = 155.75m } }
            };
        }

        public Product GetProduct(int key)
        {
            return _productsDictionary[key];
        }
    }
}
