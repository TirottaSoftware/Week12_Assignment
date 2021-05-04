using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_Management.Exceptions
{
    public class WorkshopArgumentException : Exception
    {
        private const string _message = "Invalid Workshop Argument";
        public WorkshopArgumentException():base(_message)
        {
        }

        public WorkshopArgumentException(string message) : base(message)
        {
        }
    }
}
