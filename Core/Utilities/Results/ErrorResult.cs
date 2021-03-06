using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorResult:Result //hata sonucu
    {
        public ErrorResult(string message) : base(true, message) //yapılan işlem başarılı dediği için true girdik ve mesaj da gönder.
        {

        }
        public ErrorResult() : base(true) //mesaj yazsın istemiyorsak
        {

        }
    }
}
