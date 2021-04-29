using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_Management
{
    [Serializable]
    public abstract class Workshop
    {
        private string title;
        private List<Person> participants;
        private int capacity;

        public string Title
        {
            get { return title; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException($"Title cannot be empty");
                }
                title = value;
            }
        }
        public string Description { get; set; }
        public int Capacity
        {
            get { return capacity; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"Capacity cannot be 0 or less");
                }
                capacity = value;
            }
        }
        public bool IsAvailable => this.participants.Count < this.Capacity;
        public Workshop(string title, string description, int capacity)
        {
            this.participants = new List<Person>();
            this.Title = title;
            this.Description = description;
            this.Capacity = capacity;
        }
        public void AddParticipant(Person person)
        {
            if (this.participants.Contains(person))
            {
                throw new ArgumentException($"{person.FirstName} {person.LastName} is already in the workshop");
            }
            this.participants.Add(person);
        }
        public void RemoveParticipant(Person person)
        {
            if (!this.participants.Contains(person))
            {
                throw new ArgumentException($"{person.FirstName} {person.LastName} not found.");
            }
            this.participants.Remove(person);
        }
        public override string ToString()
        {
            return $"{this.Title} | Participants: {this.participants.Count} \n {this.Description}";
        }
        public List<Person> GetParticipants => this.participants.ToList();
        public abstract string GenerateWorkshopCode();
    }
}
