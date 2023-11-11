
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class BasketManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Congrats,added to basket!: " + product.Name);
        }
        public void Add2(string name, string description, double price, int stockQuantity)
        {
            Console.WriteLine("Congrats,added to basket!: " + name);
        }

        public void Update(Product product)
        {
            Console.WriteLine("Congrats,added to basket!: " + product.Name);
        }

        public void Delete(Product product)
        {
            Console.WriteLine("Congrats,deleted to basket!: " + product.Name);
        }
    }
}