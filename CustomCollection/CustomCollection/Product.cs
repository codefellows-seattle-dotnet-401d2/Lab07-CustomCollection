using System;
using System.Collections.Generic;
using System.Text;

namespace CustomCollection
{
    public class Product
    {
        public string Name { get; set; }
        public ProductType Type { get; set; }
        public enum ProductType : int
        {
            Desktop = 1,
            Laptop,
            Tablet,
            SmartPhone,
            GameConsole,
        }
        
        public Product(string name, ProductType type)
        {
            Name = name;
            Type = type;
        }
    }
}
