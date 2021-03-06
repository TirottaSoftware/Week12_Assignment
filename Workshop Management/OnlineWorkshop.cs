using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_Management
{
    [Serializable]
    public class OnlineWorkshop : Workshop
    {
        private string url;

        public string URL
        {
            get { return url; }
            set {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException($"URL cannot be empty.");
                }
                url = value; }
        }

        public OnlineWorkshop(string title, string description, int capacity, string url) : base(title, description, capacity)
        {
            this.URL = url;
        }

        protected override string GenerateWorkshopCode()
        {
            Random rnd = new Random();
            string result = "OW-";
            result += this.Title[0];
            result += rnd.Next(1001, 9999);
            return result;
        }
    }
}
