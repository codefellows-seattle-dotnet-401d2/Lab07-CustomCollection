using System;
using Xunit;
using CustomCollection;

namespace XUnitTestCollection
{
    public class UnitTest1
    {
        [Fact]
        public void TestAddToCollection()
        {
            Store<Product> bestBuy = new Store<Product>();
            Assert.Equal(0, bestBuy.count);
            bestBuy.Add(new Product("PS4 Slim", Product.ProductType.GameConsole));
            Assert.Equal(1, bestBuy.count);
            Assert.Equal("PS4 Slim", bestBuy.items[0].Name);
        }

        [Fact]
        public void TestRemoveFromCollection()
        {
            Store<Product> bestBuy = new Store<Product>();
            bestBuy.Add(new Product("PS4 Slim", Product.ProductType.GameConsole));
            bestBuy.Add(new Product("PS4 Pro", Product.ProductType.GameConsole));
            Assert.Equal(2, bestBuy.count);
            bestBuy.Remove(bestBuy.items[0]);
            Assert.Equal(1, bestBuy.count);
            Assert.Equal("PS4 Pro", bestBuy.items[0].Name);
        }

        [Fact]
        public void TestCollectionSizeIncrease()
        {
            Store<Product> bestBuy = new Store<Product>
            {
                new Product("PS", Product.ProductType.GameConsole),
                new Product("PSOne", Product.ProductType.GameConsole),
                new Product("PS2", Product.ProductType.GameConsole),
                new Product("PS2 Slim", Product.ProductType.GameConsole),
                new Product("PS3", Product.ProductType.GameConsole),
                new Product("PS3 Slim", Product.ProductType.GameConsole),
                new Product("PS4", Product.ProductType.GameConsole),
                new Product("PS4 Slim", Product.ProductType.GameConsole),
            };
            Assert.Equal(8, bestBuy.count);
            Assert.Equal(10, bestBuy.items.Length);
            bestBuy.Add(new Product("PS4 Pro", Product.ProductType.GameConsole));
            Assert.Equal(9, bestBuy.count);
            Assert.Equal(15, bestBuy.items.Length);
        }

        [Fact]
        public void TestCollectionSizeDecrease()
        {
            Store<Product> bestBuy = new Store<Product>
            {
                new Product("PS4", Product.ProductType.GameConsole),
                new Product("PS4 Pro", Product.ProductType.GameConsole),
            };
            Assert.Equal(2, bestBuy.count);
            Assert.Equal(10, bestBuy.items.Length);
            bestBuy.Remove(bestBuy.items[0]);
            Assert.Equal(1, bestBuy.count);
            Assert.Equal(5, bestBuy.items.Length);
        }
        
        [Fact]
        public void TestGetAtIndex()
        {
            Store<Product> bestBuy = new Store<Product>
            {
                new Product("PS4", Product.ProductType.GameConsole),
                new Product("PS4 Pro", Product.ProductType.GameConsole),
            };
            Product PS4Slim = new Product("PS4 Slim", Product.ProductType.GameConsole);
            bestBuy.Add(PS4Slim);
            Assert.Equal(2, bestBuy.GetAtIndex(PS4Slim));
        }
    }
}
