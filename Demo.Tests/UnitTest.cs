using System;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using Demo.ViewModels;
using Demo.Models;
using Microsoft.Practices.Unity;

namespace Demo.Tests
{
    public class MockProductRepository : IProductRepository
    {
        public Product GetProduct(int key)
        {
            return new Product { Title = "Test", Price = 7.50m };
        }
    }

    [TestClass]
    public class ProductViewModelUnitTest
    {
        private UnityContainer _container;

        public ProductViewModelUnitTest()
        {
            _container = new UnityContainer();
            _container.RegisterType<IProductRepository, MockProductRepository>();
        }

        [TestMethod]
        public void TestProductTitle()
        {            
            ProductViewModel viewModel = _container.Resolve<ProductViewModel>();

            string expected = "Test [From View Model]";
            string actual = viewModel.ProductTitle;

            Assert.AreEqual<string>(expected, actual);
        }

        [TestMethod]
        public void TestIsNotNull()
        {
            ProductViewModel viewModel = _container.Resolve<ProductViewModel>();

            decimal expected = 7.50m;
            decimal actual = viewModel.ProductPrice;

            Assert.AreEqual<decimal>(expected, actual);
        }
    }
}
