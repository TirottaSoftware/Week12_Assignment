using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_Management
{
    public class OnlineWorkshop : Workshop
    {
        private string url;

        public string URL
        {
            get { return url; }
            set { url = value; }
        }

        public OnlineWorkshop(string title, string description, string url) : base(title, description)
        {
            this.URL = url;
        }
    }
}
