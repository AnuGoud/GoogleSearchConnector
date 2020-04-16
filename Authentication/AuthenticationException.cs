

using System;
using Microsoft.Graph;

namespace GoogleDriveSearchConnector.Authentication
{
    public class AuthenticationException : Exception
    {
        public AuthenticationException(Error error, Exception innerException = null)
            :base(error?.ToString(), innerException)
        {
            this.Error = error;
        }

        public Error Error { get; private set; }
    }
}