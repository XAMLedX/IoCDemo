using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Models;

namespace Demo.ViewModels
{
    public class ProductViewModel
    {
        private IProductRepository _repo;

        public decimal ProductPrice { get; private set; }

        public string ProductTitle { get; private set; }

        public ProductViewModel(IProductRepository repo)
        {
            _repo = repo;
            ProductTitle = _repo.GetProduct(3).Title + " [From View Model]";
            ProductPrice = _repo.GetProduct(3).Price;
        }
    }
}
