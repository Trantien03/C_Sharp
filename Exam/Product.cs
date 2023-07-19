using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamC_Sharp
{
    internal class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }

        public Product(int id, string name, double price)
        {
            ProductId = id;
            ProductName = name;
            Price = price;
        }
    }
}
