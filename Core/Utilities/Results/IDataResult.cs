using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
   public interface IDataResult<T>: IResult //HANGİ TİPİ DÖNDÜRÜCEZ ONU YAZDIK.(t) //ınterfaceler bu şekilde imlpemente edilir. IDataResult<T>:IResult
    {
        T Data { get; } //generic.
        
    }
}
