using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop_Management.Exceptions;

namespace Workshop_Management
{
    [Serializable]
    public abstract class Person
    {
        private string firstName;
        private string lastName;
        private int pcn;
        private Dictionary<Workshop, string> enrolments;

        public int PCN
        {
            get { return pcn; }
            set
            {
                if (value <= 0)
                {
                    throw new PersonArgumentException($"PCN cannot be zero or less");
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
                    throw new PersonArgumentException($"Last Name cannot be empty");
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
                    throw new PersonArgumentException($"First Name cannot be empty");
                }
                firstName = value;
            }
        }

        public Person(string firstName, string lastName, int pcn)
        {
            this.enrolments = new Dictionary<Workshop, string>();
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PCN = pcn;
        }
        public void Enroll(Workshop ws)
        {
            this.enrolments.Add(ws, ws.WorkshopCode);
        }
        public void Disenroll(Workshop ws)
        {
            if (this.enrolments.ContainsKey(ws))
            {
                this.enrolments.Remove(ws);
            }
            else
            {
                throw new WorkshopArgumentException($"Workshop not found.");
            }
        }
        public string GetEnrolmentsInfo()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var enrolment in this.enrolments)
            {
                sb.AppendLine($"{enrolment.Key.Title} - {enrolment.Value}");
            }
            return sb.ToString();
        }
        public override string ToString()
        {
            return $"{this.GetType().Name} | {this.FirstName} {this.LastName}";
        }
    }
}
