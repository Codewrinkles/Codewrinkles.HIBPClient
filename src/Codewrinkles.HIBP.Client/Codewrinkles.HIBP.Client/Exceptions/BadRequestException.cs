using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewrinkles.HIBP.Client.Exceptions
{
    public class BadRequestException : Exception
    {
        public string CustomParameter { get; set; }

        public BadRequestException()
            : base()
        {
        }

        public BadRequestException(string customParameter)
            : base()
        {
            CustomParameter = customParameter;
        }

        public override string ToString()
        {
            return $"Bad Request — the account does not comply with an acceptable format (i.e. it's an empty string). {CustomParameter}";
        }
    }
}
