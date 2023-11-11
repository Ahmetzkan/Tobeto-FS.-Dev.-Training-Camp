
using Methods;

Product product1 = new Product();
product1.Id = 1;
product1.Name = "Apple";
product1.Price = 15;
product1.Description = "Apple";

Product product2 = new Product()
{
    Id = 2,
    Name = "Watermelon",
    Price = 20,
    Description = "Watermelon"
};


Product[] products = new Product[] { product1, product2 };


// Buradaki product, type safety anlamına gelir.
foreach (Product product in products)
{
    Console.WriteLine(product.Id);
    Console.WriteLine(product.Name);
    Console.WriteLine(product.Price);
    Console.WriteLine(product.Description);
    Console.WriteLine("----------------------------");
}

Console.WriteLine("----------Methods----------");

//Instance--Örnek
//Encapsulation
BasketManager basketManager = new BasketManager();
basketManager.Add(product1);
basketManager.Update(product2);
basketManager.Delete(product1);

basketManager.Add2("Pear", "Pear", 12, 1);