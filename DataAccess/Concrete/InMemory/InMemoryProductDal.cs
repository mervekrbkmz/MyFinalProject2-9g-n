using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        // ınmemoryproductdal:bellekte ürünle ilgili veri erişim kodlarının yazılacağı yer.entityframework yazınca
        //entityframworkle çalışıcaz demek olur.
        //not:list products kısmını metoların dışında classın içinde tnımlarsak global olur,
        //bu yüzden _ çizgi ile tanımlarız.
        List<Product> _products;
        //değişken oluşturduk.
        //ürün listesi oluşturma
        public InMemoryProductDal() //ctor: controctur: bellekte referans aldığı zaman çalışacak olan bloktur.
        {
            //List<Product>:içinde ürünleri barındran liste demek.
            _products = new List<Product> {
           //yeni ürün ekledik.
             new Product{ProductId=1,CategoryId=1,ProductName="Bardak",UnitPrice=15,UnitsInStock=15},
             new Product{ProductId=2,CategoryId=1,ProductName="Kamera",UnitPrice=500,UnitsInStock=3},
             new Product{ProductId=3,CategoryId=2,ProductName="Telefon",UnitPrice=1500,UnitsInStock=2},
             new Product{ProductId=4,CategoryId=2,ProductName="Klavye",UnitPrice=150,UnitsInStock=65},
             new Product{ProductId=5,CategoryId=2,ProductName="Fare",UnitPrice=85,UnitsInStock=1}

            }; // uygulama çalıştığı anda yani newlendiğinde.

        }
        public void Add(Product product)
        {
            _products.Add(product);//yeni ürün ekle.
        }

        public void Delete(Product product) //referasnı silmek.
        {
         Product productToDelete =  _products.SingleOrDefault(p=> p.ProductId==product.ProductId);
            //p=>:lambda p burada tek tek dolaşırken verdiğimiz takma isim.
            //pnin productısi==benim gönderdiğim productıd ye eşit mi?)
            //SingleOrDefault tek bi eleman bulmaya yarar.ürünleri tek tek dolaşır foreache gerek kalmaz.foreach gibidir.
            //oradaki p takma isimdir froeachteki gibi.
            //firsofdefault,firstte da olur.


            _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()//veritabanındaki datayı businese ver.businnes ürün listesi istedi.
        {

            return _products; //tüm ürünleri olduğu gibi döndürdük.
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();//içindeki şarta uyan tüm elemenları yeni bir liste haline getirip döndürür.
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product) //referansları güncellemek
        {
            //gönderdiğim ürün ıdsine sahip olan listedeki ürünü bul güncelle.
            Product productToUpdate= _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;//güncelleyeceğim ürünün categoryıdsi 
            //ve gönderim ürünüm categoryıdsi yapabilirsin.güncellemek demek diğerleri içinde aynı.
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
      
    }
}
