using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_Management
{
    [Serializable]
    public class InBuildingWorkshop : Workshop
    {
        private int roomNumber;
        private string address;

        public int RoomNumber
        {
            get { return roomNumber; }
            set { roomNumber = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public InBuildingWorkshop(string title, string description,int capacity, string address, int roomNumber) : base(title, description, capacity)
        {
            this.Address = address;
            this.RoomNumber = roomNumber;
        }

        protected override string GenerateWorkshopCode()
        {
            Random rnd = new Random();
            string result = "IBW-";
            result += this.Title[0];
            result += rnd.Next(101, 999);
            return result;
        }
    }
}
