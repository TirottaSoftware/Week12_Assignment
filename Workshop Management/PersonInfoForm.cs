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
    public partial class PersonInfoForm : Form
    {
        public PersonInfoForm(Person person)
        {
            InitializeComponent();
            lblPCN.Text = person.PCN.ToString();
            lblRole.Text = person.GetType().Name;
            lblName.Text = $"{person.FirstName} {person.LastName}";

            foreach (var enrolment in person.Enrolments)
            {
                lbxEnrolments.Items.Add($"{enrolment.Key.Title} | {enrolment.Value}");
            }
        }
    }
}
