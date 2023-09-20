using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Microsoft.EntityFrameworkCore;
using OfficeManagementSystem.Data;
using OfficeManagementSystem.Models;


namespace OfficeManagementSystem
{
    public partial class MainForm : Form
    {

        // Local Variables
        Users localUser = null; // Holds the current user for the system so we can send it around to other forms
        String pageTitle = "Event Management System"; // Holder for dynamic page title
        bool debug = true; // Allows us access to the Database so I can store and change items.
        
        OMScontext _OMScontext = new OMScontext();


        public MainForm()
        {
            InitializeComponent();

        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            // How do I have this activate after the form has been loaded?
            // UpdateUser();

            UpdateForm();

            UpdateDataGrid();
        }

        private void userLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateUser();

            UpdateForm();
        }

        private void UpdateForm()
        {
            debugToolStripMenuItem.Visible = debug;


            if (localUser != null)
            {
                // Should flip the first and last names. Make sure to change this after implementing database.
                this.Text = pageTitle + " [" + localUser.LastName + ", " + localUser.FirstName + "]";
            }
            else
            {
                this.Text = pageTitle;
            }
        }

        private void UpdateDataGrid()
        {
            // I could make this more adaptable by making the queries be passed in, also
            // I could overload this function and create more dataGrids based on how many?

            // Clear existing columns
            dgvMain.Columns.Clear();

            // Queries the database for Events based on a select equry.
            // ADDITIONAL: Will have to also join on Venue for the name of the venue
            var query = from taskRecord in _OMScontext.Tasks
                        join eventRecord in _OMScontext.Events
                        on taskRecord.EventsID equals eventRecord.ID
                        select new
                        {
                            Priority = taskRecord.Priority,
                            Status = taskRecord.Status,
                            DueDate = taskRecord.DueDate,
                            Description = taskRecord.Description,
                            Name = eventRecord.Name
                        };

            // Load the query information into data variable and made into a list
            var data = query.ToList();
            // Link the data to the data source of the DataGridView.
            dgvMain.DataSource = data;
        }

        public void UpdateUser()
        {
            // Create another box, dialog box?
            // Request a name and and password and pass it back to the original form. 
            // Catch this, store inside localUser, set the text at the top of the screen.
            // Thoughts: Store this information, including the password, sending it back
            // and forth in order to verify each change without prompting the user again?

            // Create a method for changing the Title Text
            // Create a method for verifying the User.
            // Have a checkbox to keep the user signed in? Security issues*, maybe just the username?

            LoginForm newLogin = new LoginForm();

            localUser = newLogin.LoginUser(localUser);
            if (localUser != null)
                Debug.WriteLine(localUser.ToString());

            DialogResult inDialogResult = newLogin.DialogResult;
        }

        private void debugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBdebugForm debugForm = new DBdebugForm();
            debugForm.Show();
        }

        private void eventDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EventForm editEventForm = new EventForm();

            // Need to verify if an event is selected.
            editEventForm.editEvent(null);

        }

        private void eventsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Clear existing columns
            dgvMain.Columns.Clear();

            // Queries the database for Events based on a select equry.
            // ADDITIONAL: Will have to join on Venue to get the Name of the Venue, and maybe address?????
            var query = from eventRecord in _OMScontext.Events
                        join eventCatRecord in _OMScontext.EventCategories
                        on eventRecord.CategoryID equals eventCatRecord.ID
                        select new
                        {
                            Name = eventRecord.Name,
                            Category = eventCatRecord.Name
                        };

            // Load the query information into data variable and made into a list
            var data = query.ToList();
            // Link the data to the data source of the DataGridView.
            dgvMain.DataSource = data;
        }

        private void createEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EventForm createEventForm = new EventForm();
            createEventForm.createEvent();

        }

        private void tasksToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void createTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaskForm createTaskForm = new TaskForm();
            createTaskForm.createTask();
        }

        private void teamMessagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessagingForm createMessagingForm = new MessagingForm();
            createMessagingForm.createMessaging()
        }
    }
}
