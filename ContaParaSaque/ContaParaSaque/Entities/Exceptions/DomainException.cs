using System;

namespace ContaParaSaque.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base (message)
        {
        }
    }
}
