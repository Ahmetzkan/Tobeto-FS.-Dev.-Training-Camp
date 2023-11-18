using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    //Dal => DataAccessLayer
    public class InMemoryBrandDal :IBrandDal
    {
        //Burada tanımladığımız _brands nin set özelliğini kapatarak başka yerlerde tanımlanması engelleniyor.
        
        private readonly  List<Brand> _brands = new();

        public List<Brand> GetList()
        {
            return _brands;
        }

        public Brand? GetById(int id)
        {
            //FirstOrDefault = Koşulu sağlayan ilk öğeyi getir ya da varsayılan değeri döndürür.
            //brand listesinde brandId,Brand? metodundaki int id ile aynı mı diye kontrol ediyoruz.

            Brand? brand = _brands.FirstOrDefault(brandToCompare => brandToCompare.Id ==id); 
            return brand;
        }

        public Brand Add(Brand brand)
        {
            brand.Id = (_brands.MaxBy(brandToSelectKey => brandToSelectKey.Id)?.Id ?? 0) + 1;

            brand.CreatedAt = DateTime.UtcNow;

            _brands.Add(brand);
            return brand;
        } 
    }
}
