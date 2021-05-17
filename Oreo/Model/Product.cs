using System;
using Oreo.View;

namespace Oreo.Model
{
    class Product
    {
        private int _id;
        private string _name;
        private string _category;
        private int _price;
        private string _description;
        private int _quantity;

        public int Id
        {
            get { return _id; }
            set
            {
                if (value > 0 && value < 100000)
                {
                    _id = value;
                }
                else
                {
                    throw new ApplicationException("Invalid Product ID.");
                }
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (!string.IsNullOrEmpty(value) || !string.IsNullOrWhiteSpace(value))
                {
                    _name = value;
                }
                else
                {
                    throw new ApplicationException("Invalid Product Name");
                }
            }
        }

        public string Category
        {
            get { return _category; }
            set
            {
                if (!string.IsNullOrEmpty(value) || !string.IsNullOrWhiteSpace(value))
                {
                    _category = value;
                }
                else
                {
                    throw new ApplicationException("Invalid Product Category");
                }
            }
        }

        public int Price
        {
            get { return _price; }
            set
            {
                if (value > 0 && value < 10000000)
                {
                    _price = value;
                }
                else
                {
                    throw new ApplicationException("Invalid Product Price");
                }
            }
        }

        public string Description
        {
            get { return _description; }
            set
            {
                if (!string.IsNullOrEmpty(value) || !string.IsNullOrWhiteSpace(value))
                {
                    _description = value;
                }
                else
                {
                    throw new ApplicationException("Invalid Product Description");
                }
            }
        }

        public int Quantity
        {
            get { return _quantity; }
            set
            {
                if (value > 0 && value < 10000000)
                {
                    _quantity = value;
                }
                else
                {
                    throw new ApplicationException("Invalid Product Quantity");
                }
            }
        }

        public Product(int id, string name, string category, int price, string description, int quantity)
        {
            _id = id;
            _name = name;
            _category = category;
            _price = price;
            _description = description;
            _quantity = quantity;
        }

        public Product(int id, string name, int price, string description)
        {
            _id = id;
            _name = name;
            _price = price;
            _description = description;
        }

        public Product(){}

        public override string ToString()
        {
            return "Product Id= " + _id + ", Name= " + _name + ", Category= " + _category + ", Price= " + _price + ", Description= " + _description + ", Quantity= " + _quantity;
        }

        public string ToString2()
        {
            return "| Product Id = " + _id + " | Name = " + _name + " | Price = " + _price + " | Description = " + _description + "|";
        }

        public static Product GetAllInfo()
        {
            Product Product = new Product();
            Console.Write("\n\tProduct ID: ");
            Product.Id = int.Parse(Console.ReadLine());
            Console.Write("\tProduct Name: ");
            Product.Name = Console.ReadLine();
            Console.Write("\tProduct Category: ");
            Product.Category = Console.ReadLine();
            Console.Write("\tProduct Price: ");
            Product.Price = int.Parse(Console.ReadLine());
            Console.Write("\tProduct Description: ");
            Product.Description = Console.ReadLine();
            Console.Write("\tProduct Quantity: ");
            Product.Quantity = int.Parse(Console.ReadLine());
            return Product;
        }

        public static Product GetId()
        {
            Product Product = new Product();
            Console.Write("\n\tProduct id: ");
            try
            {
                Product.Id = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Alert.ShowAlert("Incorrect ID.", ConsoleColor.Red);
            }
            
            return Product;
        }
    }
}
