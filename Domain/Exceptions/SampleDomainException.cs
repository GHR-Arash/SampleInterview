using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Domain.Exceptions
{
    public class SampleDomainException : Exception
    {
        public SampleDomainException()
        {

        }
        public SampleDomainException(string message) :base(message)
        {
        }

        public SampleDomainException(string message,Exception innnerException):base(message, innnerException) { }
    }
}
