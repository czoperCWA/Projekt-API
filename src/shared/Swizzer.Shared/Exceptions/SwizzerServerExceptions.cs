using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Swizzer.Shared.Exceptions
{
    public class SwizzerServerException : Exception
    {
        public string ErrorCode { get; }
        public SwizzerServerException(string errorCode)
        {
            ErrorCode = errorCode;
        }

        public SwizzerServerException(string errorCode, string message) : base(message)
        {
            ErrorCode = errorCode;
        }

        public SwizzerServerException(string errorCode,string message, Exception innerException) : base(message, innerException)
        {
            ErrorCode = errorCode;
        }

        protected SwizzerServerException(string errorCode, SerializationInfo info, StreamingContext context) : base(info, context)
        {
            ErrorCode = errorCode;
        }
    }
}
