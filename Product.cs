using System;

namespace Online_shopping_demo
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Product Name : {Name}");
            Console.WriteLine($"Price        : ₹{Price}");
        }
    }

    // Derived class - Electronic Product
    internal class ElectronicProduct : Product
    {
        public string Brand { get; set; }
        public int WarrantyMonths { get; set; }

        public ElectronicProduct(string name, double price,
                                 string brand, int warrantyMonths)
            : base(name, price)
        {
            Brand = brand;
            WarrantyMonths = warrantyMonths;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Brand        : {Brand}");
            Console.WriteLine($"Warranty     : {WarrantyMonths} months");
        }
    }

    // Derived from ElectronicProduct - Smartphone
    internal class Smartphone : ElectronicProduct
    {
        public string OS { get; set; }
        public int StorageGB { get; set; }

        public Smartphone(string name, double price, string brand,
                          int warrantyMonths, string os, int storageGB)
            : base(name, price, brand, warrantyMonths)
        {
            OS = os;
            StorageGB = storageGB;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Operating System : {OS}");
            Console.WriteLine($"Storage Capacity : {StorageGB} GB");
        }
    }
}