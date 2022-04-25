using System;
using System.Collections.Generic;
using System.Text;

namespace Task2aprel24.Enums
{
     class Product
    {
    private string _productType;
       private string _code;
       private string _name;
        public double Price;
        public double DiscountedPrice;
        public int Count;
        public string ProductType
        {
            get => _productType;
            set
            {
                while (CheckProductType(value))
                {
                    Console.WriteLine("Duzgun Product Daxil Et");
                    value = Console.ReadLine();
                }
                _productType = value;
            }
        }

        public Product(string productType, double price)
        {
            ProductType = productType;
            Price = price;
        }
        public static bool CheckProductType(string productType)
        {
            if (productType.Length == 4 && char.IsUpper(productType[0]) && int.TryParse(productType.Substring(1), out int no))
                return true;
            return false;
        }

        public int TotalCount()
        {
            if (Count > 0)
            {
                Count--;
                ProductType += _name;
                return Count;
            }
            Console.WriteLine($"Obyekt yaradilmadi Say: {Count}");
            return 0;
        }
    }
}
