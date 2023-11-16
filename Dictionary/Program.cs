using Dictionary;

MyDictionary<int, string> customers = new MyDictionary<int, string>();
customers.Add(1, "Ahmet");
customers.Add(2, "Ali");
customers.Add(3, "Akça");

foreach (var customer in customers._Id)
{
    Console.WriteLine("Keys(Id): " + customer);
}
foreach (var customer in customers._Customer)
{
    Console.WriteLine("Values(User): " + customer);
}