using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    //DTO:DATA TRANSFORMATİON OBJECT.
    class Program
    {
        static void Main(string[] args)
        {
            //CONSOLEUI:net core kısmından açıcaz.
            //console uı hariç her yere abstract ve concrete klasörü açtık.
            //abstract: soyut nesneleri koyucaz.İnterfaceleri ve abstract nesneleri ve base classları koyucaz.Abstractların içine referans 
            // tutucuları koyucaz.Uygulamalar arası bağımlılıkları minimiz edicez.
            //concrete:somutları koyucaz.gerçek işi yapanları koyucaz.
            //projectreference yapıp hepsini ekledik.
            //
              ProductTest();
            // CategoryTest();

        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest() //kodu metodun içine koyduk
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            var result = productManager.GetProductDetails();
            if (result.Success==true) //eğer başarılıysa foreachle resultın datasını gez
            {
                foreach (var product in result.Data) 
                    Console.WriteLine(product.ProductName+"/"+product.CategoryName);
                
            }
            else //değilse
            {
                Console.WriteLine(result.Message);
            }
            //foreach (var product in productManager.GetProductDetails().Data)
            //    Console.WriteLine(product.ProductName+"/"+product.CategoryName);
            }
        }
    }
    //private static void ProductTest() //kodu metodun içine koyduk
    //{
    //    ProductManager productManager = new ProductManager(new EfProductDal());//entityframework çalışıcam demek.
    //     // entityframwork KISMIDNAKİ VERİLERİ ÇAĞIRDIK.
    //    foreach (var product in productManager.GetByUnitPrice(50, 100))//min 50 max 100 ürünleri getir.
    //    {
    //        Console.WriteLine(product.ProductName);
    //    }
    //}


     
    

