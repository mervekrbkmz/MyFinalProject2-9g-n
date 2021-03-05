
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Product:IEntity
    {
        //public:Bu katmana diğer katmanlarda ulaşsın demek.
        //internal:bir classın default.Sadece entities erişir demek. Hangi katmanda yazdıysak o erişir.
        //özellikler kısmı
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; } //intin küçüğü short.
        public decimal UnitPrice { get; set; }
    }
}

