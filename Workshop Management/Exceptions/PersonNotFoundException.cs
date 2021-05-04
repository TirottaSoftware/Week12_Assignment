using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_Management.Exceptions
{
    public class PersonNotFoundException : Exception
    {
        private const string _message = "Person not found";
        public PersonNotFoundException() : base(_message)
        {
        }

        public PersonNotFoundException(string message) : base(message)
        {
        }
    }
}
