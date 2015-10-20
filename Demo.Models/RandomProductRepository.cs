using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models
{
    public class RandomProductRepository : IProductRepository
    {
        public Product GetProduct(int key)
        {
            return new Product
            {
                Title = "Random",
                Price = 5.00m
            };
        }
    }
}
