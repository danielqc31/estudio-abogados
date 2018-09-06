using System;

namespace Dqc
{
    public class DqcException : Exception
    {
        public DqcException()
        {

        }

        public DqcException(string message) : base(message)
        {

        }

        public DqcException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
