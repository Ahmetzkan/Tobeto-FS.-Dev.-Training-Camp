using DataAccess.Concrete.InMemory;
using Entities.Concrete;

Brand newBrand =new();
newBrand.Name="Ford";

InMemoryBrandDal brandDal = new InMemoryBrandDal();
brandDal.Add(newBrand);

List<Brand> brands = brandDal.GetList();
foreach (Brand brand in brands)
{
    Console.WriteLine("Id: " +brand.Id );
    Console.WriteLine("Name: " +brand.Name );
}
