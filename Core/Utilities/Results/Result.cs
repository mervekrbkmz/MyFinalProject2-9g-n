using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult //ıresult implementesyonudur.
    {
         //CONSTRACTOR KISMI
        

        public Result(bool success, string message):this(success) //resultun constrocturuna tek parametreli olanı succesı yolla demek.
         //aşağıdaki kodla ve burdaki aynı anda çalışsın istiyoruz.this demek(bu demek bu class o da resulttır) resultun kendisidir
         //conctroctur 2 parametre istiyor.productmanager kısmında biz true,string değer girdik.
        {
            Message = message; //messageyi message olarak set et.
           // Success = success; burayı aşağıda set ettik.
            
        }
        public Result(bool success) //MESAJ BOŞ OLSUN.
        { 
            Success = success;

        }
        //------------------------------------- BURAYA KADAR CONSTRACTOR.
        public bool Success { get; }//buraya ne yazarsak return edicek.

        public string Message { get; }
    }
}
