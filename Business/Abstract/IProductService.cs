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
        //işkatmanında kullanacağımız servis operasyonları
        List<Product> GetAll();//referans ekledik data ve enititesi ekledik
        List<Product> GetAllByCategoryId(int id); //categoryıdsine göre getirir
        List<Product> GetByUnitPrice(decimal min, decimal max);
        List<ProductDetailDto> GetProductDetails();
        Product GetById(int productId);//tek başına bir ürün döndürür.
        IResult Add(Product product);



    };
}
 