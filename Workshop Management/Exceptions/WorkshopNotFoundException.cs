using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_Management.Exceptions
{
    public class WorkshopNotFoundException : Exception
    {
        private const string _message = "Workshop not found.";
        public WorkshopNotFoundException() : base(_message)
        {
        }

        public WorkshopNotFoundException(string message) : base(message)
        {
        }
    }
}
