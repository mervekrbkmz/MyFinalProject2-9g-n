using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

//nuget
namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    //efentityrepositorybase yazdık çünkü onun içinde operasyonlar mevcut burda implemente edip operasyonlarla ilgili işlem yapmamıza gerek kalmadı bu kısmı yazarak.
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            //joın yazıcaz.
            using (NorthwindContext context = new NorthwindContext())//entity kullnıcağım için bunu yazdık
            {
                var result = from p in context.Products //contexteki(tablon)ürünlerle kategorileri joın et demek.
                             join c in context.Categories
                              on p.CategoryId equals c.CategoryId //neye göre pdeki category ıd ile c deki category ıd ye göre.
                             select new ProductDetailDto { ProductId = p.ProductId, ProductName = p.ProductName, CategoryName = c.CategoryName, UnitsInStock = p.UnitsInStock };
                return result.ToList();
            }
        }
    }
}
