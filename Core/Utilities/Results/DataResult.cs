using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class DataResult<T> : Result, IDataResult<T> //sen resultsın ayrıca t içinde IDataResult imleplementasyonusun.
        //DATARESULTIN BASE RESULTTIR.
    {
        public DataResult(T data,bool success,string message):base (success,message) //constroctur.diğer resulttn farkı datası var diğerinde data yok o void çünkü.
        {
            Data = data;//datayı set ettik.
        }
        public DataResult(T data,bool success):base(success) //mesaj göndermek istemezse.
        {
            Data = data;//datayı set ettik.
        }
        public T Data { get;}
    }
}
