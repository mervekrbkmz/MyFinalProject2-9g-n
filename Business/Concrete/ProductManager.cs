using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService //iş katmanının somut sınıfıdır.
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;

        }


        public List<Product> GetAll()
        {
            //işkodları varsa
            //işşleri geçerse veri erişimi çağırmmaız lazım
            //iş sınıfları başka sınıfları newlemez.
            return _productDal.GetAll();//kurallardan geçtim bana ürünleri ver demek.
 

        }

        public List<Product> GetAllByCategoryId(int id)
        {
            return _productDal.GetAll(p => p.CategoryId == id);//ctegoryıd benim gönderdiğim id ye eşitse onları filtrele demek.
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {

            return _productDal.GetAll(p => p.UnitPrice >= min&& p.UnitPrice<=max);//2 fiyata aralığındakileri getir.
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            return _productDal.GetProductDetails();

        }
    }
}
