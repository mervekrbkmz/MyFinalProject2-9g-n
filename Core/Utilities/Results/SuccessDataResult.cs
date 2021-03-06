using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
  public class SuccessDataResult<T>:DataResult<T>
    {
  

        public SuccessDataResult(T data,string message):base(data,true,message)//base:dataresulta işlem datadır,işlem sonucu truedur  ve mesaj vardır.
        {

        }
        public SuccessDataResult(T data):base(data,true)//mesaj boşsa.sadece data ver.
        {

        }
        public SuccessDataResult(string message):base(default,true,message) //datayı default haliyel döndürmek istersek.
        {
                
        }
        public SuccessDataResult():base(default,true) //bişey vermek istemiyorum.
        {

        }

    }
}
