using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop_Management.Exceptions;

namespace Workshop_Management
{
    [Serializable]
    public abstract class Workshop
    {
        private string title;
        private List<Person> participants;
        private int capacity;
        private Person presenter;

        public Person Presenter
        {
            get
            {
                return presenter;
            }
            set
            {
                if (value.GetType().Name != nameof(Teacher))
                {
                    throw new WorkshopArgumentException($"Presenter must be a Teacher");
                }
                presenter = value;
            }
        }

        public string WorkshopCode
        {
            get;
        }

        public string Title
        {
            get { return title; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new WorkshopArgumentException($"Title cannot be empty");
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
                    throw new WorkshopArgumentException($"Capacity cannot be 0 or less");
                }
                capacity = value;
            }
        }
        private bool isAvailable;
        public bool IsAvailable {
            get
            {
                if (this.participants.Count == this.capacity)
                {
                    return false;
                }
                return this.isAvailable;
            }
            set
            {
                this.isAvailable = value;
            }
        }

        public Workshop(string title, string description, int capacity)
        {
            this.participants = new List<Person>();
            this.IsAvailable = true;
            this.Title = title;
            this.Description = description;
            this.Capacity = capacity;
            this.WorkshopCode = GenerateWorkshopCode();
        }
        public void AddParticipant(Person person)
        {
            if (this.participants.Contains(person))
            {
                throw new WorkshopArgumentException($"{person.FirstName} {person.LastName} is already in the workshop");
            }
            if (!this.IsAvailable)
            {
                throw new WorkshopArgumentException($"Workshop is full");
            }
            this.participants.Add(person);
        }
        public void RemoveParticipant(Person person)
        {
            if (this.participants.FirstOrDefault(p=>p.PCN == person.PCN) == null)
            {
                throw new WorkshopArgumentException($"person not found.");
            }
            this.participants.Remove(person);
        }
        public override string ToString()
        {
            return $"{this.Title} | Participants: {this.participants.Count} \n {this.Description}";
        }
        public List<Person> GetParticipants() => this.participants.ToList();
        protected abstract string GenerateWorkshopCode();
    }
}
