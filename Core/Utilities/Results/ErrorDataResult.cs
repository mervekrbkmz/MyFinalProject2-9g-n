using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<T> : DataResult<T>
    {

        public ErrorDataResult(T data, string message) : base(data, false, message)//base:dataresulta işlem datadır,işlem sonucu truedur  ve mesaj vardır.
        {

        }
        public ErrorDataResult(T data) : base(data, false)//mesaj boşsa.sadece data ver.
        {

        }
        public ErrorDataResult(string message) : base(default, false, message) //datayı default haliyel döndürmek istersek.
        {

        }
        public ErrorDataResult() : base(default, false) //bişey vermek istemiyorum.
        {

        }

    }
}
