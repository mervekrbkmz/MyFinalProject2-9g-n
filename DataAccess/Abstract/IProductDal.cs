using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product> //çalışma tipin producttır.
    {
        //interface metodları default publictir.
        //veritabanında yapacağım productla ilgili operasyonları(ekle,sil,güncelle) yapacağım kısım.
        //add reference:entitise kullanıcam ama dataacces olarak entitese bağımlıyım.ben burda ekleme
        //yapıcam ürünü ürünler entities kısmında buyüzden referans eklemem gerekir.
        //kısaca başka katmanı kullanmak istersen referans kullanırız.
        //DATAACCESS SAĞ TIK add project reference de entity ekle.
        //ürün listele tüm ürünleri.
        //List<Product> GetAll();//tüm ürünleri getir. 
        //void Add(Product product);
        //void Update(Product product);
        //void Delete(Product product);
        //List<Product> GetAllByCategory(int categoryId);//ürünleri categoriye göre filtrele.
        //CODE REFACTORİNG:KODUN İYİLEŞTİRİLMESİ DEMEK.

        List<ProductDetailDto> GetProductDetails();


    }
}
