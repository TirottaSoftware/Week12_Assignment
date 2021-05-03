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
    public partial class WorkshopInfoForm : Form
    {
        private Workshop workshop;
        public WorkshopInfoForm(Workshop ws)
        {
            this.workshop = ws;
            InitializeComponent();
            lblTitle.Text = ws.Title;
            rtbDescription.Text = ws.Description;
            lblCapacityValue.Text = ws.Capacity.ToString();
            lblWorkshopCode.Text = ws.WorkshopCode;
            lblParticipantsCount.Text = ws.GetParticipants().Count.ToString();
            if (ws.GetType().Name == nameof(OnlineWorkshop))
            {
                var onlineWs = (OnlineWorkshop)ws;
                lblURLValue.Text = onlineWs.URL;

                lblAddress.Visible = false;
                lblAddressValue.Visible = false;
                lblRoomNumber.Visible = false;
                lblRoomNumberValue.Visible = false;
            }
            else
            {
                var inBuildingWs = (InBuildingWorkshop)ws;
                lblAddressValue.Text = inBuildingWs.Address;
                lblRoomNumberValue.Text = inBuildingWs.RoomNumber.ToString();

                lblURL.Visible = false;
                lblURLValue.Visible = false;
            }
        }

        private void WorkshopInfoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnViewParticipants_Click(object sender, EventArgs e)
        {
            ViewParticipantsForm viewParticipantsForm = new ViewParticipantsForm(this.workshop);
            this.Hide();
            viewParticipantsForm.ShowDialog();
        }
    }
}
