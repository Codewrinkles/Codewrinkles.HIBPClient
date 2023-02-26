using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewrinkles.HIBP.Client.Exceptions
{
    public class ApiKeyException : Exception
    {
        public ApiKeyException(string message) : base(message)
        {
        }
    }
}
