using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamC_Sharp
{
    internal class Program
    {
        static List<Product> products = new List<Product>();
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("===== Create A Menu ===== ");
                Console.WriteLine("1. Add product records");
                Console.WriteLine("2. Display product records");
                Console.WriteLine("3. Delete product by Id");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddProduct();
                        break;
                    case 2:
                        DisplayProducts();
                        break;
                    case 3:
                        DeleteProduct();
                        break;
                    case 4:
                        exit = true;
                        Console.WriteLine("Exiting the program...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again!");
                        break;
                }
                Console.WriteLine();
            }
        }
        static void AddProduct()
        {
            Console.WriteLine("Enter Product details! ");
            Console.Write("Product ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Product Name: ");
            string name = Console.ReadLine();
            Console.Write("Price: ");
            double price = Convert.ToDouble(Console.ReadLine());

            Product product = new Product(id,name, price);
            products.Add(product);

            Console.WriteLine("Product added successfully!");

        }
        static void DisplayProducts()
        {
            if(products.Count == 0)
            {
                Console.WriteLine("No products found!");
            }
            else
            {
                Console.WriteLine("Product records! ");
                foreach (Product product in products)            
                {
                    Console.WriteLine($"Product ID: {product.ProductId}");
                    Console.WriteLine($"Name: {product.ProductName}");
                    Console.WriteLine($"Price: {product.Price}");
                    Console.WriteLine();
                }
            }
        }
        static void DeleteProduct()
        {
            Console.Write("Enter product ID to delete: ");
            int id = Convert.ToInt32(Console.ReadLine());

            bool found = false;

            for (int i = 0; i < products.Count; i++)
            {
                if(products[i].ProductId == id)
                {
                    products.RemoveAt(i);
                    found = true;
                    break;
                }
            }
            if( found )
            {
                Console.WriteLine("Product deleted successfully!");
            }
            else
            {
                Console.WriteLine("Peoduct not found!");
            }
        }
    }
}
