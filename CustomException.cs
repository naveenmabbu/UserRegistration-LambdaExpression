using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration_LambdaExp
{
    public class CustomException : ApplicationException
    {
        public enum ExceptionType
        {
            INVALID_DETAILS
        }
        public readonly ExceptionType type;
        public CustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
