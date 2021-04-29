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
    public partial class Dashboard : Form
    {
        private List<Person> people;
        private List<Workshop> workshops;

        public Dashboard()
        {
            this.people = Data.GetPeople();
            InitializeComponent();
            UpdatePeopleList();
        }
        private void UpdatePeopleList()
        {
            lbxPeople.Items.Clear();
            foreach (var p in this.people)
            {
                if (p != null)
                {
                    lbxPeople.Items.Add(p);
                }
            }
        }
        private void RemovePerson(Person person)
        {
            if (this.people.Contains(person))
            {
                this.people.Remove(person);
                Data.UpdatePeople(this.people);
                UpdatePeopleList();
            }
            else
            {
                throw new ArgumentException($"{person.FirstName} {person.LastName} not found.");
            }
        }
        private void EditPerson(Person person)
        {
            //TODO: Create and Implement EditPersonForm
            //Create an EditForm obj and pass the current person
            //Show EditForm
        }
        private void GetPersonInfo(Person person)
        {
            //TODO: Create & Implement PersonInfoForm
            //Pass person and open PersonInfoForm
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
                AddPersonForm addPersonForm = new AddPersonForm();
                this.Hide();
                addPersonForm.ShowDialog();
        }

        private void btnRemovePerson_Click(object sender, EventArgs e)
        {
            try
            {
                Person p = (Person)lbxPeople.SelectedItem;
                this.RemovePerson(p);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {

            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.people = new List<Person>();
            Data.UpdatePeople(this.people);
        }
    }
}
