using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICategoryService
    {
        List<Category> GetAll();
        Category GetById(int categoryId); //categoryıd verdim sende bana ilgili ktegori ver. category olur ıd istedik bir tane kategori olur list olmaz.

    }
}
