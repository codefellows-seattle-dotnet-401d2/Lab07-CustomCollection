using System;

namespace CustomCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Product iPhoneX = new Product("iPhone X", Product.ProductType.SmartPhone);
            Product SurfaceBook2 = new Product("Surface Book 2", Product.ProductType.Laptop);
            Product Pixel2XL = new Product("Pixel 2 XL", Product.ProductType.SmartPhone);
            Product SurfacePro4 = new Product("Surface Pro 4", Product.ProductType.Tablet);
            Product Area51 = new Product("Area 51", Product.ProductType.Desktop);
            Store<Product> BestBuy = new Store<Product>
            {
                iPhoneX, SurfaceBook2, Pixel2XL, SurfacePro4, Area51
            };

            Product PS4Slim = new Product("PS4 Slim", Product.ProductType.GameConsole);
            Product PS4Pro = new Product("PS4 Pro", Product.ProductType.GameConsole);
            Product XBoxOne = new Product("XBox One", Product.ProductType.GameConsole);
            Product XBoxOneX = new Product("XBox One X", Product.ProductType.GameConsole);
            Product Switch = new Product("Switch", Product.ProductType.GameConsole);
            BestBuy.Add(PS4Slim);
            BestBuy.Add(PS4Pro);
            BestBuy.Add(XBoxOne);
            BestBuy.Add(XBoxOneX);
            BestBuy.Add(Switch);

            BestBuy.Remove(SurfacePro4);
            BestBuy.Remove(PS4Pro);
            BestBuy.Remove(Pixel2XL);
            BestBuy.Remove(XBoxOne);
            BestBuy.Remove(iPhoneX);
            BestBuy.Remove(PS4Slim);
            BestBuy.Remove(Area51);
            BestBuy.Remove(XBoxOneX);
            BestBuy.Remove(SurfaceBook2);

            Console.ReadLine();
        }
    }
}
