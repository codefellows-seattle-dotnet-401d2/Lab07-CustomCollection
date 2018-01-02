using System;
using System.Collections.Generic;

// TODO: Add Tests 

namespace Collections
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Cheese Store!");
            Console.WriteLine("Press Enter to view a list of our products: ");
            Console.WriteLine();
            
            ViewAll();
            
            Console.ReadLine();
            Console.Clear();

            int x = (int)Cheddar.Sharp;
            int y = (int)Cheddar.Mild;
            int z = (int)Cheddar.Hard;
            Console.WriteLine("Our Cheddar options include: ");
            Console.WriteLine("Sharp = {0}", x);
            Console.WriteLine("Mild = {0}", y);
            Console.WriteLine("Hard = {0}", z);

            Console.ReadLine();
        }

        /// <summary>
        /// List of Products added and removed
        /// </summary>
        public static string Products()
        {
            // Create List of 10 Products w/ collection intializer
            List<string> cheeseProducts = new List<string>
            { "Brie", "Gouda", "Blue", "Swiss", "Cheddar",
              "Goat", "Feta", "Ricotta", "Parmesan", "Kraft" };

            // Add items using add method 
            cheeseProducts.Add("Gruyere");
            cheeseProducts.Add("Muenster");

            // Remove items using remove method
            cheeseProducts.Remove("Kraft");

            // Iterate through the list and output to the console 
            foreach (string i in cheeseProducts)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Press Enter to view Cheddar options: ");
            string readList = Console.ReadLine();
            return readList;
        }

        /// <summary>
        /// Enumerated int values of Cheddar options
        /// </summary>
        public enum Cheddar : int
        {
            Sharp,
            Mild,
            Hard,
        }

        /// <summary>
        /// Allows you to view the entire list
        /// </summary>
        /// <returns>String of product list</returns>
        public static string ViewAll()
        {
            Console.ReadLine();
            string view = Products();
            return view;
        }

    public static string TestingTest()
        {
            return "1";
        }
    }
}
