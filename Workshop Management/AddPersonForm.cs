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
    public partial class AddPersonForm : Form
    {
        private List<Person> people;
        public AddPersonForm()
        {
            people = Data.GetPeople();
            InitializeComponent();
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            string firstName = string.Empty;
            string lastName = string.Empty;
            int pcn = 0;

            try
            {
                firstName = tbxFirstName.Text;
                lastName = tbxLastName.Text;
                pcn = int.Parse(tbxPCN.Text);
            }
            catch (Exception)
            {
                MessageBox.Show($"Please fill all the required fields.");
                return;
            }
            Person person = null;

            if (this.people.FirstOrDefault(p => p.PCN == pcn) != null)
            {
                MessageBox.Show($"Person with that PCN already exists");
                return;
            }
            
            if (!String.IsNullOrEmpty(firstName) && !String.IsNullOrEmpty(lastName) && pcn > 0)
            {
                if (rbStudent.Checked)
                {
                    person = new Student(firstName, lastName, pcn);
                }
                else if (rbTeacher.Checked)
                {
                    person = new Teacher(firstName, lastName, pcn);
                }
                else
                {
                    MessageBox.Show($"Please select a role (Student/Teacher)");
                    return;
                }

                this.people.Add(person);
                Data.UpdatePeople(this.people);
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

        private void AddPersonForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
