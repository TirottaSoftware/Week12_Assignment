using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_Management
{
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

        public InBuildingWorkshop(string title, string description, string address, int roomNumber) : base(title, description)
        {
            this.Address = address;
            this.RoomNumber = roomNumber;
        }
    }
}
