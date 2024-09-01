using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Application.CustomExceptions
{
    public class HttpException:Exception
    {
        public HttpException(string Message):base(Message)
        {
            
        }
        public HttpException(string Message,Exception InnerException):base(Message, InnerException) 
        {
            
        }
    }
}
