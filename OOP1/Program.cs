using OOP1;
using System.Xml;

Product product1 = new Product();
product1.Id = 1;
product1.CategoryId = 2; //Mobilya
product1.ProductName = "Table";
product1.UnitPrice = 500;
product1.UnitsInStock = 3;

Product product2 = new Product
{
    Id = 2,
    CategoryId = 5, //Kırtasiye
    UnitsInStock = 5,
    ProductName = "Pencil",
    UnitPrice = 35
};

//PascalCase   //camelCase
//case sensitive
ProductManager productManager = new ProductManager();
productManager.Add(product1);
Console.WriteLine(product1.ProductName);
productManager.Add(product2);

//int,double,bool... değer tip
//arrays,class,abstract class,interface referans tip
//ref out

productManager.Addition2(3,6);
int totalResult = productManager.Addition(3, 6);
Console.WriteLine(totalResult*2);