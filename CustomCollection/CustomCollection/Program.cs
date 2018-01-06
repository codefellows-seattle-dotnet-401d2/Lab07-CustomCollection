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

            Console.WriteLine("Instatiating Store with 5 products.");
            Store<Product> bestBuy = new Store<Product>
            {
                iPhoneX, SurfaceBook2, Pixel2XL, SurfacePro4, Area51
            };

            Product PS4Slim = new Product("PS4 Slim", Product.ProductType.GameConsole);
            Product PS4Pro = new Product("PS4 Pro", Product.ProductType.GameConsole);
            Product XBoxOne = new Product("XBox One", Product.ProductType.GameConsole);
            Product XBoxOneX = new Product("XBox One X", Product.ProductType.GameConsole);
            Product Switch = new Product("Switch", Product.ProductType.GameConsole);

            Console.WriteLine("Called Add() on 5 products");
            bestBuy.Add(PS4Slim);
            bestBuy.Add(PS4Pro);
            bestBuy.Add(XBoxOne);
            bestBuy.Add(XBoxOneX);
            bestBuy.Add(Switch);

            Console.WriteLine("Called GetAtIndex(Pixel2XL)");
            Console.WriteLine("Index of Pixel 2 XL: " + bestBuy.GetAtIndex(Pixel2XL));

            Console.WriteLine("Called ViewAll");
            ViewAll(bestBuy.items);

            Console.WriteLine("Calling Remove() on 9 items. Switch will be the only one left.");
            bestBuy.Remove(SurfacePro4);
            bestBuy.Remove(PS4Pro);
            bestBuy.Remove(Pixel2XL);
            bestBuy.Remove(XBoxOne);
            bestBuy.Remove(iPhoneX);
            bestBuy.Remove(PS4Slim);
            bestBuy.Remove(Area51);
            bestBuy.Remove(XBoxOneX);
            bestBuy.Remove(SurfaceBook2);

            Console.ReadLine();
        }

        /// <summary>
        /// Used to print all items in the collection to the screen.
        /// </summary>
        /// <param name="items">The collection of items to print</param>
        public static void ViewAll(Product[] items)
        {
           /* If I want to implement as a non-static method attached to Store class:
            * 
            * PropertyInfo property = typeof(T).GetProperty("Name");
            * Console.WriteLine(property.GetValue(items[i]));
           */

            Console.WriteLine("\nAll items currently in the collection: ");
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == null) break;
                Console.WriteLine(items[i].Name);
            }
            Console.WriteLine("");
        }
    }
}
