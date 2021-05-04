﻿using System;
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
            this.workshops = Data.GetWorkshops();
            InitializeComponent();
            UpdatePeopleList();
            UpdateWorkshopsList();
        }
        private void UpdatePeopleList(string sortOption)
        {
            lbxPeople.Items.Clear();
            if (sortOption == "Alphabetically")
            {
                foreach (var p in this.people.OrderBy(p => p.FirstName).ThenBy(p => p.LastName))
                {
                    if (p != null)
                    {
                        lbxPeople.Items.Add(p);
                    }
                }
            }
            else if (sortOption == "Students Only")
            {
                foreach (var p in this.people.Where(p => p.GetType().Name == nameof(Student)))
                {
                    if (p != null)
                    {
                        lbxPeople.Items.Add(p);
                    }
                }
            }
            else if (sortOption == "Teachers Only")
            {
                foreach (var p in this.people.Where(p => p.GetType().Name == nameof(Teacher)))
                {
                    if (p != null)
                    {
                        lbxPeople.Items.Add(p);
                    }
                }
            }
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
        private void UpdateWorkshopsList()
        {
            lbxWorkshops.Items.Clear();
            foreach (var w in this.workshops)
            {
                if (w != null)
                {
                    lbxWorkshops.Items.Add(w);
                }
            }
        }
        private void UpdateWorkshopsList(string sortOption)
        {
            lbxWorkshops.Items.Clear();
            if (sortOption == "In Building")
            {
                foreach (var w in this.workshops.Where(x => x.GetType().Name == nameof(InBuildingWorkshop)))
                {
                    lbxWorkshops.Items.Add(w);
                }
            }
            else if (sortOption == "Online")
            {
                foreach (var w in this.workshops.Where(x => x.GetType().Name == nameof(OnlineWorkshop)))
                {
                    lbxWorkshops.Items.Add(w);
                }
            }
            else
            {
                foreach (var w in this.workshops.OrderBy(x => x.Title))
                {
                    lbxWorkshops.Items.Add(w);
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
        private void RemoveWorkshop(Workshop ws)
        {
            if (this.workshops.Contains(ws))
            {
                this.workshops.Remove(ws);
                Data.UpdateWorkshops(this.workshops);
                UpdateWorkshopsList();
            }
            else
            {
                throw new ArgumentException($"{ws.Title} not found.");
            }
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

        private void lbxPeople_DoubleClick(object sender, EventArgs e)
        {
            Person p = (Person)lbxPeople.SelectedItem;
            MessageBox.Show($"{p.GetType().Name} \n{p.FirstName} {p.LastName} \nPCN: {p.PCN} \n{p.GetEnrolmentsInfo()}");
        }

        private void btnAddWorkshop_Click(object sender, EventArgs e)
        {
            AddWorkshopForm addWorkshopForm = new AddWorkshopForm();
            this.Hide();
            addWorkshopForm.ShowDialog();
        }

        private void btnRemoveWorkshop_Click(object sender, EventArgs e)
        {
            try
            {
                Workshop ws = (Workshop)lbxWorkshops.SelectedItem;
                this.RemoveWorkshop(ws);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditPerson_Click(object sender, EventArgs e)
        {
            Person p = (Person)lbxPeople.SelectedItem;
            EditPersonForm editPersonForm = new EditPersonForm(p);
            editPersonForm.ShowDialog();
            this.Hide();
        }

        private void btnEditWorkshop_Click(object sender, EventArgs e)
        {
            Workshop ws = (Workshop)lbxWorkshops.SelectedItem;
            EditWorkshopForm editWorkshopForm = new EditWorkshopForm(ws);
            this.Hide();
            editWorkshopForm.ShowDialog();

        }

        private void lbxWorkshops_DoubleClick(object sender, EventArgs e)
        {
            Workshop selectedWorkshop = (Workshop)lbxWorkshops.SelectedItem;
            WorkshopInfoForm workshopInfoForm = new WorkshopInfoForm(selectedWorkshop);
            this.Hide();
            workshopInfoForm.ShowDialog();
        }

        private void cbxSortPeople_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOption = cbxSortPeople.SelectedItem.ToString();
            UpdatePeopleList(selectedOption);
        }

        private void cbxSortWorkshops_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOption = cbxSortWorkshops.SelectedItem.ToString();
            UpdateWorkshopsList(selectedOption);
        }
    }
}
