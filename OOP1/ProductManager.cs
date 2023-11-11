using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class ProductManager
    {
        //encapsulation
        public void Add(Product product) 
        {
            Console.WriteLine(product.ProductName + " added.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " updated.");

        }

        public void Delete(Product product)
        {
            Console.WriteLine(product.ProductName + " deleted.");

        }
    
        public int Addition(int number1,int number2)
        {
            return number1 + number2;
        }

        public void Addition2(int number1, int number2)
        {
            Console.WriteLine(number1+number2);
        }
       
    }
}
