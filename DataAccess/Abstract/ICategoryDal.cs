using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
  public  interface ICategoryDal:IEntityRepository<Category> // bu kısmı ientityrepositoryden aldık class ve newleme kısmı.
    { //bu yazıklarımıza gerek yok yorum satırı yaptığımız. IENTİTYREPOSİTORYDE yaptık buraya onu yazıcaz aynı işlemleri yapmış olacaktır

        //List<Category> GetAll();//tüm ürünleri getir. 
        //void Add(Category category);
        //void Update(Category category);
        //void Delete(Category category);
        //List<Category> GetAllByCategory(int categoryId);//ürünleri categoriye göre filtrele.
    }
}
