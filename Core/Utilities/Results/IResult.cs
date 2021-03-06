using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //temel voidler için başlangıç
   public interface IResult //sonuç
    {

        bool Success { get; } //boolla olur true mu false mu diye? yani başarılı mı başarısız mı?
        string Message { get; } //bilgilendirme mesajı mesela ürün eklendi gibi...
    }
}
