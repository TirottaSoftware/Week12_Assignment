using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_Management
{
    [Serializable]
    public class Student : Person
    {
        public Student(string firstName, string lastName, int pcn) : base(firstName, lastName, pcn)
        {
        }
    }
}
