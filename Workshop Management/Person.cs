using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_Management
{
    [Serializable]
    public abstract class Person
    {
        private string firstName;
        private string lastName;
        private int pcn;
        private Dictionary<Workshop, string> workshops;

        public int PCN
        {
            get { return pcn; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"PCN cannot be zero or less");
                }
                pcn = value;
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException($"Last Name cannot be empty");
                }
                lastName = value;
            }
        }

        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException($"First Name cannot be empty");
                }
                firstName = value;
            }
        }

        public Person(string firstName, string lastName, int pcn)
        {
            this.workshops = new Dictionary<Workshop, string>();
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PCN = pcn;
        }
        public override string ToString()
        {
            return $"{this.GetType().Name} | {this.FirstName} {this.LastName}";
        }
    }
}
