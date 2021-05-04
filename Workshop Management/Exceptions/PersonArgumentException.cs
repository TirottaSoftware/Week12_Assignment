using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_Management.Exceptions
{
    public class PersonArgumentException : Exception
    {
        private const string _message = "Invalid Person Argument";
        public PersonArgumentException() : base(_message)
        {
        }

        public PersonArgumentException(string message) : base(message)
        {
        }
    }
}
