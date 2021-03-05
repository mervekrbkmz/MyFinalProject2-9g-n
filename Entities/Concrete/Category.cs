
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    //çıplak class kalmasın.
    //concrete klasöründeki sınıflar bir veritabanı tablosuna karşılık gelir.
  public  class Category:IEntity// category bir veritabanı tablosudur.ıentity categorynin referansını tutar.
    {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }
    }
}
