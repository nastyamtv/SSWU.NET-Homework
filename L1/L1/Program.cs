using System;

namespace L1
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
                return Product.Price*Quantity;
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
            return String.Format("{0} Quantity: {1} Total Price: {2} Total Weight {3}",Product , Quantity, TotalPrice,TotalWeight);
        }

    }

    class Check
    {
        public static void PrintOnDesktop(Buy p) {
            Console.WriteLine(p);
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();
            Console.WriteLine(p);
            Buy b = new Buy("Milk",30,10,7);
            Console.WriteLine(b);

            //Check.PrintOnDesktop(tom);
        }
    }
}
