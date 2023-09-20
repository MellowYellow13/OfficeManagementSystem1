namespace OfficeManagementSystem
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuEMS = new System.Windows.Forms.MenuStrip();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tasksToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.venuesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resourcesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.eventDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventResourcesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.taskTrackingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messagingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamMessagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactMessagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.venuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.venueInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.venueSchedulingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.menuEMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // menuEMS
            // 
            this.menuEMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.eventsToolStripMenuItem,
            this.tasksToolStripMenuItem,
            this.messagingToolStripMenuItem,
            this.venuesToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.debugToolStripMenuItem});
            this.menuEMS.Location = new System.Drawing.Point(0, 0);
            this.menuEMS.Name = "menuEMS";
            this.menuEMS.Size = new System.Drawing.Size(824, 24);
            this.menuEMS.TabIndex = 0;
            this.menuEMS.Text = "menuEMSstrip";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userLoginToolStripMenuItem});
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.loginToolStripMenuItem.Text = "Login";
            // 
            // userLoginToolStripMenuItem
            // 
            this.userLoginToolStripMenuItem.Name = "userLoginToolStripMenuItem";
            this.userLoginToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.userLoginToolStripMenuItem.Text = "User Login";
            this.userLoginToolStripMenuItem.Click += new System.EventHandler(this.userLoginToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eventsToolStripMenuItem1,
            this.tasksToolStripMenuItem1,
            this.venuesToolStripMenuItem1,
            this.contactsToolStripMenuItem,
            this.resourcesToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // eventsToolStripMenuItem1
            // 
            this.eventsToolStripMenuItem1.Name = "eventsToolStripMenuItem1";
            this.eventsToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.eventsToolStripMenuItem1.Text = "Events";
            this.eventsToolStripMenuItem1.Click += new System.EventHandler(this.eventsToolStripMenuItem1_Click);
            // 
            // tasksToolStripMenuItem1
            // 
            this.tasksToolStripMenuItem1.Name = "tasksToolStripMenuItem1";
            this.tasksToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.tasksToolStripMenuItem1.Text = "Tasks";
            // 
            // venuesToolStripMenuItem1
            // 
            this.venuesToolStripMenuItem1.Name = "venuesToolStripMenuItem1";
            this.venuesToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.venuesToolStripMenuItem1.Text = "Venues";
            // 
            // contactsToolStripMenuItem
            // 
            this.contactsToolStripMenuItem.Name = "contactsToolStripMenuItem";
            this.contactsToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.contactsToolStripMenuItem.Text = "Contacts";
            // 
            // resourcesToolStripMenuItem
            // 
            this.resourcesToolStripMenuItem.Name = "resourcesToolStripMenuItem";
            this.resourcesToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.resourcesToolStripMenuItem.Text = "Resources";
            // 
            // eventsToolStripMenuItem
            // 
            this.eventsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createEventToolStripMenuItem,
            this.toolStripSeparator2,
            this.eventDetailsToolStripMenuItem,
            this.eventRegistrationToolStripMenuItem,
            this.eventResourcesToolStripMenuItem});
            this.eventsToolStripMenuItem.Name = "eventsToolStripMenuItem";
            this.eventsToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.eventsToolStripMenuItem.Text = "Events";
            // 
            // createEventToolStripMenuItem
            // 
            this.createEventToolStripMenuItem.Name = "createEventToolStripMenuItem";
            this.createEventToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.createEventToolStripMenuItem.Text = "Create Event";
            this.createEventToolStripMenuItem.Click += new System.EventHandler(this.createEventToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(166, 6);
            // 
            // eventDetailsToolStripMenuItem
            // 
            this.eventDetailsToolStripMenuItem.Name = "eventDetailsToolStripMenuItem";
            this.eventDetailsToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.eventDetailsToolStripMenuItem.Text = "Event Details";
            this.eventDetailsToolStripMenuItem.Click += new System.EventHandler(this.eventDetailsToolStripMenuItem_Click);
            // 
            // eventRegistrationToolStripMenuItem
            // 
            this.eventRegistrationToolStripMenuItem.Name = "eventRegistrationToolStripMenuItem";
            this.eventRegistrationToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.eventRegistrationToolStripMenuItem.Text = "Event Registration";
            // 
            // eventResourcesToolStripMenuItem
            // 
            this.eventResourcesToolStripMenuItem.Name = "eventResourcesToolStripMenuItem";
            this.eventResourcesToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.eventResourcesToolStripMenuItem.Text = "Event Resources";
            // 
            // tasksToolStripMenuItem
            // 
            this.tasksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createTaskToolStripMenuItem,
            this.toolStripSeparator1,
            this.taskTrackingToolStripMenuItem});
            this.tasksToolStripMenuItem.Name = "tasksToolStripMenuItem";
            this.tasksToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.tasksToolStripMenuItem.Text = "Tasks";
            this.tasksToolStripMenuItem.Click += new System.EventHandler(this.tasksToolStripMenuItem_Click);
            // 
            // createTaskToolStripMenuItem
            // 
            this.createTaskToolStripMenuItem.Name = "createTaskToolStripMenuItem";
            this.createTaskToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createTaskToolStripMenuItem.Text = "Create Task";
            this.createTaskToolStripMenuItem.Click += new System.EventHandler(this.createTaskToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // taskTrackingToolStripMenuItem
            // 
            this.taskTrackingToolStripMenuItem.Name = "taskTrackingToolStripMenuItem";
            this.taskTrackingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.taskTrackingToolStripMenuItem.Text = "Task Tracking";
            // 
            // messagingToolStripMenuItem
            // 
            this.messagingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teamMessagesToolStripMenuItem,
            this.contactMessagesToolStripMenuItem});
            this.messagingToolStripMenuItem.Name = "messagingToolStripMenuItem";
            this.messagingToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.messagingToolStripMenuItem.Text = "Messaging";
            // 
            // teamMessagesToolStripMenuItem
            // 
            this.teamMessagesToolStripMenuItem.Name = "teamMessagesToolStripMenuItem";
            this.teamMessagesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.teamMessagesToolStripMenuItem.Text = "Team Messages";
            this.teamMessagesToolStripMenuItem.Click += new System.EventHandler(this.teamMessagesToolStripMenuItem_Click);
            // 
            // contactMessagesToolStripMenuItem
            // 
            this.contactMessagesToolStripMenuItem.Name = "contactMessagesToolStripMenuItem";
            this.contactMessagesToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.contactMessagesToolStripMenuItem.Text = "Contact Messages";
            // 
            // venuesToolStripMenuItem
            // 
            this.venuesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.venueInformationToolStripMenuItem,
            this.venueSchedulingToolStripMenuItem});
            this.venuesToolStripMenuItem.Name = "venuesToolStripMenuItem";
            this.venuesToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.venuesToolStripMenuItem.Text = "Venues";
            // 
            // venueInformationToolStripMenuItem
            // 
            this.venueInformationToolStripMenuItem.Name = "venueInformationToolStripMenuItem";
            this.venueInformationToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.venueInformationToolStripMenuItem.Text = "Venue Information";
            // 
            // venueSchedulingToolStripMenuItem
            // 
            this.venueSchedulingToolStripMenuItem.Name = "venueSchedulingToolStripMenuItem";
            this.venueSchedulingToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.venueSchedulingToolStripMenuItem.Text = "Venue Scheduling";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateReportsToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // generateReportsToolStripMenuItem
            // 
            this.generateReportsToolStripMenuItem.Name = "generateReportsToolStripMenuItem";
            this.generateReportsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.generateReportsToolStripMenuItem.Text = "Generate Reports";
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.debugToolStripMenuItem.Text = "Debug";
            this.debugToolStripMenuItem.Visible = false;
            this.debugToolStripMenuItem.Click += new System.EventHandler(this.debugToolStripMenuItem_Click);
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.AllowUserToOrderColumns = true;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Location = new System.Drawing.Point(12, 149);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.Size = new System.Drawing.Size(800, 300);
            this.dgvMain.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 461);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.menuEMS);
            this.MainMenuStrip = this.menuEMS;
            this.Name = "MainForm";
            this.Text = "Event Managment System";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.menuEMS.ResumeLayout(false);
            this.menuEMS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuEMS;
        private System.Windows.Forms.ToolStripMenuItem eventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem eventDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventRegistrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventResourcesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem messagingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teamMessagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactMessagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem venuesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem venueInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.ToolStripMenuItem taskTrackingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem venueSchedulingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tasksToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem venuesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem contactsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resourcesToolStripMenuItem;
    }
}