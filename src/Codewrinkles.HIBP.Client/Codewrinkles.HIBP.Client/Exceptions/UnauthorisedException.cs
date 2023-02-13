using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewrinkles.HIBP.Client.Exceptions
{
    public class UnauthorisedException : Exception
    {
        public string CustomParameter { get; set; }

        public UnauthorisedException()
            : base()
        {
        }

        public UnauthorisedException(string customParameter)
            : base()
        {
            CustomParameter = customParameter;
        }

        public override string ToString()
        {
            return $"Unauthorised — either no API key was provided or it wasn't valid). {CustomParameter}";
        }
    }
}
