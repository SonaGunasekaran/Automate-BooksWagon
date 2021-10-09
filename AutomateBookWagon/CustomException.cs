using System;
using System.Collections.Generic;
using System.Text;

namespace AutomateBookWagon
{
    public class CustomException : Exception
    {
        ExceptionType type;
        public enum ExceptionType
        {

            NO_SUCH_ELEMENT, INVALID_SELECTOR, FILE_NOT_FOUND
        }
        public CustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }

}
