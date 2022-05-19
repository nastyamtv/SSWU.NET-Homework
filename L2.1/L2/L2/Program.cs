using System;

namespace L2
{

    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double Weight { get; set; }

        public Product()
        {
            Name = "Good";
            Price = 37;
            Weight = 30;
        }

        public Product(Product p)
        {
            Name = p.Name;
            Price = p.Price;
            Weight = p.Weight;
        }
        public Product(string name, double price, double weight)
        {
            Name = name;
            Price = price;
            Weight = weight;
        }
        public override string ToString()
        {
            return String.Format("Name: {0} Price: {1} Weight: {2}", Name, Price, Weight);
        }

        public virtual void changePrice(double rate) 
        {
            Price = Price * rate/100;
        }
    }

    class Buy
    {
        Product Product { get; set; }
        int Quantity { get; set; }
        public Buy()
        {
            Quantity = 5;
        }
        public Buy(Buy p)
        {
            Product = p.Product;
            Quantity = p.Quantity;
        }
        public Buy(string name, double price, double weight, int quantity)
        {
            Product = new Product(name, price, weight);
            Quantity = quantity;
        }
        public double TotalPrice
        {
            get
            {
                return Product.Price * Quantity;
            }

        }
        public double TotalWeight
        {
            get
            {
                return Product.Weight * Quantity;
            }

        }

        public override string ToString()
        {
            return String.Format("{0} Quantity: {1} Total Price: {2} Total Weight {3}", Product, Quantity, TotalPrice, TotalWeight);
        }

    }

    class Check
    {
        public static void PrintOnDesktop(Buy p)
        {
            Console.WriteLine(p);
        }


    }
    public enum Category
    {
        first,
        second
    }

    public enum Type
    {
        mutton,
        chicken,
        veal,
        pork
    }
    class Meat : Product
    {
        Category Category;
        Type Type;
        public const double MuttonRate = 50.0;
        public const double ChickenRate = 20.0;
        public const double VealRate = 10.0;
        public const double PorkRate = 70.0;

        public override void changePrice(double rate) {
            if (Type == Type.mutton)
            {
                Price = (Price * rate + Price * MuttonRate) / 100;
            }
            if (Type == Type.chicken) 
            {
                Price = (Price * rate + Price * ChickenRate) / 100;
            }
            if (Type == Type.veal)
            {
                Price = (Price * (100-rate) * Price * (100-VealRate)) / 100;
            }
            if (Type == Type.pork)
            {
                Price = (Price * (100-rate)* (100-PorkRate)) / 100;
            }
        }
    }

    class Dairy_products : Product
    {
        int term;
        public const double r1 = 10.0;
        public const double r2 = 20.0;
        public override void changePrice(double rate)
        {
            if (term < 10) 
            {
                Price = Price * (100-rate)*(100-r1) / 10000;
            }
            if (term > 10)
            {
                Price = Price * (100 - rate) * (100 - r2) / 10000;
            }
        }
    }

    class Storage 
    { 
    }
    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();
            Console.WriteLine(p);
            Buy b = new Buy("Milk", 30, 10, 7);
            Console.WriteLine(b);

            //Check.PrintOnDesktop(tom);
        }
    }
}
