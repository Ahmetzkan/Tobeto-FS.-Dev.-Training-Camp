using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    public class Model:Entity<int>
    {
        //Brand = Marka
        //public Guid Id { get; set; }
        //UyeId,SiparisId.. Yazılımlarda tanımlayıcı olarak kullanılan benzersiz bir referans numarasıdır.
        //Sürekli artan numaraları kontrol etmek amacıyla Guid id kullanılır.

        public string Name { get; set; }
        public int BrandId { get; set; } //Foreign Key
        public decimal DailyPrice { get; set; }

    }
}
