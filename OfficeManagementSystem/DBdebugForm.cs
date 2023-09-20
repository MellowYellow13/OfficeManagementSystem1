using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.EntityFrameworkCore;
using OfficeManagementSystem.Data;
using OfficeManagementSystem.Models;

namespace OfficeManagementSystem
{
    public partial class DBdebugForm : Form
    {
        public DBdebugForm()
        {
            InitializeComponent();
        }

        private OMScontext _OMScontext = new OMScontext();
        private Type currentTableType;



        private void Form1_Load(object sender, EventArgs e)
        {
            cbxTable.Items.AddRange(new object[] { "Attendees", "BudgetItems", "Contacts", "EventCategories", "Events", "Messages", "Resources", "Tasks", "Users", "Venues" });

            //_OMScontext = new OMScontext();
            _OMScontext.Attendees.Load();

            // Loads into the binding source the attendees so the....
            //databaseBindingSource.DataSource = 
            //    _OMScontext.Attendees.Local.ToBindingList();


            // Resizing Experiment
            //originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Width, this.Height);
            //buttonOriginalRectangle = new Rectangle(button1.Location.X, button1.Location.Y, button1.Width, button1.Height);

        }

        private void SwitchTo(String tableName)
        {

            // There's a better way to do this. Can use the same lines of code, just the fact the
            // OMScontext needs the .*whatever* to access.
            switch(tableName)
            {
                case "Attendees":
                    _OMScontext.Attendees.Load();
                    databaseBindingSource.DataSource =
                        _OMScontext.Attendees.Local.ToBindingList();
                    databaseDataGridView.DataSource =
                        _OMScontext.Attendees.Local.ToBindingList();
                    currentTableType = typeof(Attendees);
                    break;
                case "BudgetItems":
                    _OMScontext.BudgetItems.Load();
                    databaseBindingSource.DataSource =
                        _OMScontext.BudgetItems.Local.ToBindingList();
                    databaseDataGridView.DataSource =
                        _OMScontext.BudgetItems.Local.ToBindingList();
                    currentTableType = typeof(BudgetItems);
                    break;
                case "Contacts":
                    _OMScontext.Contacts.Load();
                    databaseBindingSource.DataSource =
                        _OMScontext.Contacts.Local.ToBindingList();
                    databaseDataGridView.DataSource =
                       _OMScontext.Contacts.Local.ToBindingList();
                    currentTableType = typeof(Contacts);
                    break;
                case "EventCategories":
                    _OMScontext.EventCategories.Load();
                    databaseBindingSource.DataSource =
                        _OMScontext.EventCategories.Local.ToBindingList();
                    databaseDataGridView.DataSource =
                       _OMScontext.EventCategories.Local.ToBindingList();
                    currentTableType = typeof(EventCategories);
                    break;
                case "Events":
                    _OMScontext.Events.Load();
                    databaseBindingSource.DataSource =
                        _OMScontext.Events.Local.ToBindingList();
                    databaseDataGridView.DataSource =
                       _OMScontext.Events.Local.ToBindingList();
                    currentTableType = typeof(Events);
                    break;
                case "Messages":
                    _OMScontext.Messages.Load();
                    databaseBindingSource.DataSource =
                        _OMScontext.Messages.Local.ToBindingList();
                    databaseDataGridView.DataSource =
                       _OMScontext.Messages.Local.ToBindingList();
                    currentTableType = typeof(Messages);
                    break;
                case "Resources":
                    _OMScontext.Resources.Load();
                    databaseBindingSource.DataSource =
                        _OMScontext.Resources.Local.ToBindingList();
                    databaseDataGridView.DataSource =
                       _OMScontext.Resources.Local.ToBindingList();
                    currentTableType = typeof(Resources);
                    break;
                case "Tasks":
                    _OMScontext.Tasks.Load();
                    databaseBindingSource.DataSource =
                        _OMScontext.Tasks.Local.ToBindingList();
                    databaseDataGridView.DataSource =
                       _OMScontext.Tasks.Local.ToBindingList();
                    currentTableType = typeof(Tasks);
                    break;
                case "Users":
                    _OMScontext.Users.Load();
                    databaseBindingSource.DataSource =
                        _OMScontext.Users.Local.ToBindingList();
                    databaseDataGridView.DataSource =
                       _OMScontext.Users.Local.ToBindingList();
                    currentTableType = typeof(Users);
                    break;
                case "Venues":
                    _OMScontext.Venues.Load();
                    databaseBindingSource.DataSource =
                        _OMScontext.Venues.Local.ToBindingList();
                    databaseDataGridView.DataSource =
                       _OMScontext.Venues.Local.ToBindingList();
                    currentTableType = typeof(Venues);
                    break;            
            }

            // Clear existing columns
            databaseDataGridView.Columns.Clear();

            // Create columns for each property in the entity
            foreach (var property in currentTableType.GetProperties())
            {
                // Add a DataGridViewTextBoxColumn for each property
                var column = new DataGridViewTextBoxColumn
                {
                    HeaderText = property.Name,
                    DataPropertyName = property.Name
                };
                databaseDataGridView.Columns.Add(column);
            }

            // Set the DataSource to refresh the DataGridView
            // databaseDataGridView.DataSource = currentTable.ToList();


        }



        private void databaseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            databaseBindingSource.EndEdit();
            _OMScontext.SaveChanges();
        }

        private void cbxTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            SwitchTo(cbxTable.Text);
        }



        // Experimental
        /*
         * 
        private Rectangle tableOriginalRectangle;
        private Rectangle buttonOriginalRectangle;
        private Rectangle originalFormSize;
        private void Form1_Resize(object sender, EventArgs e)
        {
            // Resizing Experiment
            resizeControl(buttonOriginalRectangle, button1);
        }

        // Resizing Experiment
        private void resizeControl(Rectangle r, Control c)
        {
            float xRatio = (float)this.Width / (float)originalFormSize.Width;
            float yRatio = (float)this.Height / (float)originalFormSize.Height;

            int newX = (int)(r.Width * xRatio);
            int newY = (int)(r.Height * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
        }
        */
    }
}
