using System;
using System.Runtime.Serialization;

namespace SkiaSharp.Forms.Xaml.Exceptions
{
    public class InvalidDrawParameterException : ArgumentNullException
    {
        public InvalidDrawParameterException()
        {
        }

        public InvalidDrawParameterException(string paramName) : this($"Invalid draw value for '{paramName}'", paramName)
        {
        }
        public InvalidDrawParameterException(string paramName, string message) : base(paramName, message)
        {
        }

        public InvalidDrawParameterException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidDrawParameterException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
