using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessResult : Result //result basedir.
    {
        public SuccessResult(string message) : base(false, message) //yapılan işlem başarılı dediği için true girdik ve mesaj da gönder.
        {

        }
        public SuccessResult() : base(false) //mesaj yazsın istemiyorsak
        {

        }

    }
}
