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
    public partial class EditPersonForm : Form
    {
        private Person person;
        private List<Person> people;
        public EditPersonForm(Person person)
        {
            this.person = person;
            this.people = Data.GetPeople();
            InitializeComponent();
            tbxFirstName.Text = person.FirstName;
            tbxLastName.Text = person.LastName;
            tbxPCN.Text = person.PCN.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string firstName = String.Empty;
            string lastName = String.Empty;
            int pcn = 0;
            Person p = this.people.First(x => x.PCN == this.person.PCN);
            try
            {
                firstName = tbxFirstName.Text;
                lastName = tbxLastName.Text;
                pcn = int.Parse(tbxPCN.Text);

                if (String.IsNullOrEmpty(firstName) || String.IsNullOrEmpty(lastName) || pcn <= 0)
                {
                    throw new ArgumentException("Please fill all the required fields.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            p.FirstName = firstName;
            p.LastName = lastName;
            p.PCN = pcn;
            Data.UpdatePeople(this.people);
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.ShowDialog();
        }

        private void EditPersonForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
