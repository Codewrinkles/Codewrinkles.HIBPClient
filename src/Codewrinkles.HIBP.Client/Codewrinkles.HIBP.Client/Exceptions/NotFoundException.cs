using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewrinkles.HIBP.Client.Exceptions
{
    public class NotFoundException : Exception
    {
        public string CustomParameter { get; set; }

        public NotFoundException()
            : base()
        {
        }

        public NotFoundException(string customParameter)
            : base()
        {
            CustomParameter = customParameter;
        }

        public override string ToString()
        {
            return $"Not found — the account could not be found and has therefore not been pwned. {CustomParameter}";
        }
    }
}
