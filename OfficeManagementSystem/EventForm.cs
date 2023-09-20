using Microsoft.Extensions.Logging.Abstractions;
using OfficeManagementSystem.Data;
using OfficeManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OfficeManagementSystem.Essential;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OfficeManagementSystem
{
    public partial class EventForm : Form
    {
        OMScontext _OMScontext = new OMScontext();

        public EventForm()
        {
            InitializeComponent();
        }

        private void EventForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            IsValidData();
        }
        public void createEvent()
        {
            // Editing Title
            this.Text = "Create " + this.Text;

            // Transform some controls based on which function is called. 
            btnEdit.Visible = false;
            btnAddVenue.Visible = false;

            dtpStartDate.MinDate = DateTime.Today;
            dtpEndDate.MinDate = DateTime.Today;

            // Queries the database for Events based on a select equry.
            var query = from venueRecord in _OMScontext.Venues
                        select new
                        {
                            Name = venueRecord.Name,
                            Capacity = venueRecord.Capacity,
                            Address = venueRecord.Address,
                            Layout = venueRecord.LayoutDiagram
                        };

            // Load the query information into data variable and made into a list
            var data = query.ToList();
            // Link the data to the data source of the DataGridView.
            cbxVenueSelect.DataSource = data;
            cbxVenueSelect.DisplayMember = "Name";
            //cbxVenueSelect.ValueMember = "ID";

            // Queries the database for Events based on a select equry.
            var query2 = from eventCatRecord in _OMScontext.EventCategories
                        select new
                        {
                            Name = eventCatRecord.Name,
                        };

            // Load the query information into data variable and made into a list
            var data2 = query2.ToList();
            // Link the data to the data source of the DataGridView.
            cbxEventCat.DataSource = data2;
            cbxEventCat.DisplayMember = "Name";
            //cbxVenueSelect.ValueMember = "ID";


            // Need to insert a query on Venue usage. If an Event is going on in a certain Venue,
            // should not be able to pick a time that Venue is being used. 



            this.ShowDialog();

        }

        public void editEvent(Events editEvent)
        {
            // Editing Title
            this.Text = "Create " + this.Text;

            // Transform some controls based on which function is called. 
            btnEdit.Visible = true;
            btnCreate.Visible = false;
            btnAddVenue.Visible = false;

            var query = from eventRecord in _OMScontext.Events
                        join eventCatRecord in _OMScontext.EventCategories
                        on eventRecord.CategoryID equals eventCatRecord.ID
                        join venueRecord in _OMScontext.Venues
                        on eventRecord.VenueID equals venueRecord.ID
                        where  eventRecord.ID == editEvent.ID
                        select new
                        {
                            EventName = eventRecord.Name,
                            VenueName = venueRecord.Name,
                            EventDescription = eventRecord.Description,
                            VenueCapacity = venueRecord.Capacity,
                            Category = eventCatRecord.Name,
                            EventStartDate = eventRecord.StartDate,
                            EventEndDate = eventRecord.EndDate
                        };

            // MIGHT want to load a try catch here to catch errors
            // Load the query information into data variable and made into a list
            var data = query.ToList();

            tbxName.Text = query.ElementAt(0).EventName;
            tbxDescription.Text = query.ElementAt(0).EventDescription;

            dtpStartDate.Value = query.ElementAt(0).EventStartDate;
            dtpEndDate.Value = query.ElementAt(0).EventEndDate;

            // Iterate through the items in the ComboBox
            foreach (var item in cbxVenueSelect.Items)
            {
                // Check if the item's ValueMember (assuming it's a string) matches the target value
                if (item is DataRowView rowView && rowView.Row["ValueMemberColumnName"].ToString() == query.ElementAt(0).VenueName)
                {
                    // Set the SelectedValue property to the matched ValueMember
                    cbxVenueSelect.SelectedValue = rowView.Row["ValueMemberColumnName"];
                    break; // Exit the loop once a match is found
                }
            }
            

        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            // Could potential change it to keep consistent the amount of time between the two dates.
            // Not sure if this would be helpful to change, or to keep as is.

            // Moves the EndDate to be on the same day as the StartDate so there's not an EndDate before StartDate.
            dtpEndDate.Value = dtpStartDate.Value;
            dtpEndDate.MinDate = dtpStartDate.Value;
        }

        private bool IsValidData()
        {
            // Checking all relevant information to make sure it is present and validated
            // Event Name must be present and at least 10 characters
            // Venue Address must be present and within 30 characters
            // Venue Capacity must be present and between the int 5 and 1000
            // Event Description must be present and at least 10 characters
            // Start Date must be within 2 years from today.

            return
                Validator.IsPresent(tbxName) &&
                Validator.IsLength(tbxName, 20) &&
                Validator.IsPresent(tbxAddress) &&
                Validator.IsLength(tbxAddress, 120) &&
                Validator.IsPresent(tbxCapacity) &&
                Validator.IsWithinRange(tbxCapacity, 5,1000) &&
                Validator.IsPresent(tbxDescription) &&
                Validator.IsLength(tbxDescription, 500) &&
                Validator.IsWithinRange(dtpStartDate, DateTime.Today, (DateTime.Today.AddYears(2)));

        }

        private void cbxVenueSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Perform a database query or some action based on the selected item
            string selectedItem = cbxVenueSelect.SelectedItem.ToString();

            // Query the database or perform an action to get information
            Venues venueRecord = (Venues)GetInformationFromDatabase(selectedItem);

            // Display the information in the TextBox
            tbxCapacity.Text = venueRecord.Capacity.ToString();
            tbxAddress.Text = venueRecord.Address.ToString();
        }

        private Object GetInformationFromDatabase(string selectedItem)
        {
            // Use your DbContext to query the database and retrieve information
            using (_OMScontext)
            {
                Object result = _OMScontext.Venues
                    .Where(item => item.Name == selectedItem)
                    .FirstOrDefault();
                return result;
            }
        }
    }
}
