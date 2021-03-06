using Business.Abstract;
using Core.Utilities.Results;
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

        public IResult Add(Product product)
        {
            //businnes kodlar.kurallar varsa kodları buraya yazarız geçerliyse ekleriz değilse eklenmez.

            //false kısmı//hata sonucu.
            if (product.ProductName.Length<2) //üürünün ismi minimum 2 karakter olmalı.
            {
                return new ErrorResult("Ürün ismi min 2 karakter olmalıdır.");
            }


            _productDal.Add(product);
            // return new SuccessResult(true);//sağ tık consrtructor filed ekle. mesaj yazsın istiyorsak bu
            // return new SuccessResult();//mesaj boş olsun diyorsak bunu yazarız.
            return new SuccessResult("Ürün Eklendi");
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

        public Product GetById(int productId)
        {
            return _productDal.Get(p => p.ProductId == productId);//tek bir ürün döndüreceği için get dedik.
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
