using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewrinkles.HIBP.Client.Exceptions
{
    public class ForbiddenException : Exception
    {
        public string CustomParameter { get; set; }

        public ForbiddenException()
            : base()
        {
        }

        public ForbiddenException(string customParameter)
            : base()
        {
            CustomParameter = customParameter;
        }

        public override string ToString()
        {
            return $"Forbidden — no user agent has been specified in the request. {CustomParameter}";
        }
    }
}
