using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IProductService //interfaceleri genellikle servic oalrak yazarız.
    {
        //result :void.
        //IDataresult:hem işlem sonucu mesajı içeren hem döndüreceği şeyi içeren yapıdır.İÇERSİNE DATA KOYALIM.
        //işkatmanında kullanacağımız servis operasyonları
        //List<Product> GetAll();//referans ekledik data ve enititesi ekledik
        IDataResult<List<Product>> GetAll();
        IDataResult<List<Product>>GetAllByCategoryId(int id); //categoryıdsine göre getirir
        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<List<ProductDetailDto> >GetProductDetails();
        IDataResult<Product> GetById(int productId);//tek başına bir ürün döndürür.
        IResult Add(Product product);



    };
}
 