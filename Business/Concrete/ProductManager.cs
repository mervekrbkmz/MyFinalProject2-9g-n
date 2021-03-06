using Business.Abstract;
using Business.Constants;
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
            if (product.ProductName.Length < 2) //üürünün ismi minimum 2 karakter olmalı.
            {
                //MAGİC STRİNGS:STRİNGLERİ AYRI AYRI YAZMAK.
                return new ErrorResult(Messages.ProductAdded);
            }


            _productDal.Add(product);
            // return new SuccessResult(true);//sağ tık consrtructor filed ekle. mesaj yazsın istiyorsak bu
            // return new SuccessResult();//mesaj boş olsun diyorsak bunu yazarız.
            return new SuccessResult("Ürün Eklendi");
        }

        public IDataResult<List<Product>> GetAll()
        {
            //22:00dan 22:59 kadar bakımda olucak.
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);//MaintenanceTime:bakım zamanı.
            }
            //işkodları varsa
            //işşleri geçerse veri erişimi çağırmmaız lazım
            //iş sınıfları başka sınıfları newlemez.
            //return new SuccessDataResult<List<Product>>( _productDal.GetAll(),true,"ürünler listelendi");//kurallardan geçtim bana ürünleri ver demek.
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(), Messages.ProductsListed);//dataresult için

        }

        public IDataResult<List<Product>> GetAllByCategoryId(int id)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.CategoryId == id));//ctegoryıd benim gönderdiğim id ye eşitse onları filtrele demek.
        }

        public IDataResult<Product> GetById(int productId)
        {
            return new SuccessDataResult<Product>(_productDal.Get(p => p.ProductId == productId));//tek bir ürün döndüreceği için get dedik.
        }

        public IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max)
        {

            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max));//2 fiyata aralığındakileri getir.
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetails()
        {
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductDetails());

        }
        //SİSTEM BAKIMDA DİCEK.
        //    public IDataResult<List<ProductDetailDto>> GetProductDetails()
        //    {
        //        if (DateTime.Now.Hour == 23)
        //        {
        //            return new ErrorDataResult<List<ProductDetailDto>>(Messages.MaintenanceTime);//MaintenanceTime:bakım zamanı.
        //        }
        //        return new ErrorDataResult<List<ProductDetailDto>>(_productDal.GetProductDetails());

        //    }
        //}
    }
} }
