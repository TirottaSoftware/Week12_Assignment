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
    public partial class AddWorkshopForm : Form
    {
        private List<Workshop> workshops;
        public AddWorkshopForm()
        {
            this.workshops = Data.GetWorkshops();
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //Get workshop data
            string title = tbxTitle.Text;
            string description = rtbDescription.Text;
            int capacity = (int)numCapacity.Value;
            //Create a new workshop

            try
            {
                Workshop ws = null;
                if (!String.IsNullOrEmpty(title) || !String.IsNullOrEmpty(description) || capacity > 0)
                {
                    if (rbInBuilding.Checked)
                    {
                        string address = tbxAddress.Text;
                        int roomNumber = (int)numRoomNumber.Value;
                        if (String.IsNullOrEmpty(address) || roomNumber <= 0)
                        {
                            throw new ArgumentException("Please provide valid address and room number values");
                        }
                        ws = new InBuildingWorkshop(title, description, capacity, address, roomNumber);
                    }
                    else if (rbOnline.Checked)
                    {
                        string url = tbxURL.Text;
                        if (String.IsNullOrEmpty(url))
                        {
                            throw new ArgumentException("URL cannot be null or empty");
                        }
                        ws = new OnlineWorkshop(title, description, capacity, url);
                    }
                    else
                    {
                        MessageBox.Show($"Please select a workshop type (Online/In Building)");
                        return;
                    }
                    //Add to list
                    this.workshops.Add(ws);
                    Data.UpdateWorkshops(this.workshops);
                    Dashboard dashboard = new Dashboard();
                    this.Hide();
                    dashboard.ShowDialog();
                }
                else
                {
                    MessageBox.Show($"Please fill all the required fields.");
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rbOnline_CheckedChanged(object sender, EventArgs e)
        {
            tbxAddress.Enabled = false;
            numRoomNumber.Enabled = false;
            tbxURL.Enabled = true;
        }

        private void rbInBuilding_CheckedChanged(object sender, EventArgs e)
        {
            tbxAddress.Enabled = true;
            numRoomNumber.Enabled = true;
            tbxURL.Enabled = false;
        }

        private void AddWorkshopForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
