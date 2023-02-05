using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewrinkles.HIBP.Client.Exceptions
{
    public class TooManyRequestsException : Exception
    {
        public string CustomParameter { get; set; }

        public TooManyRequestsException()
            : base()
        {
        }

        public TooManyRequestsException(string customParameter)
            : base()
        {
            CustomParameter = customParameter;
        }

        public override string ToString()
        {
            return $"Too many requests — the rate limit has been exceeded. {CustomParameter}";
        }
    }
}
