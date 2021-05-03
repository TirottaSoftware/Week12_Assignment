using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workshop_Management
{
    public partial class EditWorkshopForm : Form
    {
        private List<Workshop> workshops;
        private Workshop ws;
        public EditWorkshopForm(Workshop workshop)
        {
            this.workshops = Data.GetWorkshops();
            InitializeComponent();
            //  Enable/Disable fields according to the workshop type
            tbxTitle.Text = workshop.Title;
            rtbDescription.Text = workshop.Description;
            if (workshop.GetType().Name == nameof(OnlineWorkshop))
            {
                tbxAddress.Enabled = false;
                numRoomNumber.Enabled = false;
                tbxURL.Enabled = true;
                //Setting Default Values
                var onlineWs = (OnlineWorkshop)workshop;
                tbxURL.Text = onlineWs.URL;
            }
            else if (workshop.GetType().Name == nameof(InBuildingWorkshop))
            {
                tbxAddress.Enabled = true;
                numRoomNumber.Enabled = true;
                tbxURL.Enabled = false;
                //Setting Default Values
                var inBuildingWs = (InBuildingWorkshop)workshop;
                tbxAddress.Text = inBuildingWs.Address;
                numRoomNumber.Value = inBuildingWs.RoomNumber;
            }
            ws = this.workshops.First(w => w.Title == workshop.Title);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Find the Workshop in the workshops list
            string title = String.Empty;
            string address = String.Empty;
            int roomNumber = 0;
            string url = String.Empty;

            //Catch Exceptions
            try
            {
                title = tbxTitle.Text;
                if (ws.GetType().Name == nameof(OnlineWorkshop))
                {
                    url = tbxURL.Text;
                }
                else
                {
                    address = tbxAddress.Text;
                    roomNumber = (int)numRoomNumber.Value;
                }

                //Update entity -> Update List
                ws.Title = title;



                if (ws.GetType().Name == nameof(OnlineWorkshop))
                {
                    int index = this.workshops.IndexOf(ws);
                    var onlineWs = (OnlineWorkshop)ws;
                    if (String.IsNullOrEmpty(url))
                    {
                        throw new ArgumentException($"URL cannot be null or empty");
                    }
                    onlineWs.URL = url;
                    this.workshops.RemoveAt(index);
                    this.workshops.Insert(index, onlineWs);
                }
                else
                {
                    var inBuildingWs = (InBuildingWorkshop)ws;
                    if (String.IsNullOrEmpty(address) || roomNumber <= 0)
                    {
                        throw new ArgumentException($"Please enter a valid address and room number.");
                    }
                    inBuildingWs.Address = address;
                    inBuildingWs.RoomNumber = roomNumber;
                    int index = this.workshops.IndexOf(ws);
                    this.workshops.RemoveAt(index);
                    this.workshops.Insert(index, inBuildingWs);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            Data.UpdateWorkshops(this.workshops);
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.ShowDialog();
        }

        private void EditWorkshopForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
