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
    public partial class ViewParticipantsForm : Form
    {
        private Workshop workshop;
        private List<Workshop> workshops;
        public ViewParticipantsForm(Workshop ws)
        {
            this.workshops = Data.GetWorkshops();
            this.workshop = this.workshop = this.workshops.First(w => w.Title == ws.Title);
            InitializeComponent();
            RefreshList();
        }
        private void RefreshList()
        {
            cbxPeople.Items.Clear();
            lbxParticipants.Items.Clear();
            foreach (var person in Data.GetPeople())
            {
                cbxPeople.Items.Add(person);
            }
            foreach (var participant in this.workshop.GetParticipants())
            {
                lbxParticipants.Items.Add(participant);
            }

        }
        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            try
            {
                if (!workshop.IsAvailable)
                {
                    throw new Exception($"Workshop has already started");
                }
                Person selectedPerson = (Person)cbxPeople.SelectedItem;
                if (selectedPerson == null)
                {
                    throw new NullReferenceException();
                }
                if (this.workshop.GetParticipants().FirstOrDefault(p => p.PCN == selectedPerson.PCN) != null)
                {
                    throw new ArgumentException($"{selectedPerson.FirstName} {selectedPerson.LastName} already in the list");
                }
                this.workshop.AddParticipant(selectedPerson);
                Data.UpdateWorkshops(this.workshops);
                RefreshList();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please select a participant first");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void ViewParticipantsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lbxParticipants_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Person selectedPerson = (Person)lbxParticipants.SelectedItem;
                if (selectedPerson == null)
                {
                    throw new ArgumentException($"Please select a participant from the list.");
                }
                this.workshop.RemoveParticipant(selectedPerson);
                Data.UpdateWorkshops(this.workshops);
                RefreshList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void btnStartWorkshop_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.workshop.IsAvailable)
                {
                    throw new Exception($"Workshop has already started");
                }
                else
                {
                    this.workshop.IsAvailable = false;
                    Data.UpdateWorkshops(this.workshops);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard db = new Dashboard();
            db.ShowDialog();
        }
    }
}
