using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService //iş kodlarını yazıcaz implemente et.
    {
        //business veri erişimine bağlı.
        ICategoryDal _categoryDal; //sağ tık generic constructor yap.

        public CategoryManager(ICategoryDal categoryDal) //CATEGORYMANAGER DATACCESE BAĞLI MA ZAYIF BAĞLI O YÜZDEN İSTEDİĞİMİZ KODLARI KURALLARA BAĞLI OLRAK YAZABİLİRİZ
        {
            _categoryDal = categoryDal;
        }

        //bağımlılığı constractılar yapıyorum.minimie edicem bağımlılığı dha fazla yerde kullanmak için sadece entity değil mongodb vs vs.
        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }
       //select* from categories where categoryıd=3;ne verirsek ıdye.aşağıdaki kod bununla aynıdır.
        public Category GetById(int categoryId)
        {
            return _categoryDal.Get(c => c.CategoryId == categoryId);
        }
    }
}
