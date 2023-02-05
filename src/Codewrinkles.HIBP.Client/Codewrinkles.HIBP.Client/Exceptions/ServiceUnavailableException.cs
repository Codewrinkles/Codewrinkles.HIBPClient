using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewrinkles.HIBP.Client.Exceptions
{
    public class ServiceUnavailableException : Exception
    {
        public string CustomParameter { get; set; }

        public ServiceUnavailableException()
            : base()
        {
        }

        public ServiceUnavailableException(string customParameter)
            : base()
        {
            CustomParameter = customParameter;
        }

        public override string ToString()
        {
            return $"Service unavailable — usually returned by Cloudflare if the underlying service is not available. {CustomParameter}";
        }
    }
}
