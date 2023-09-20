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
using Microsoft.EntityFrameworkCore;
using OfficeManagementSystem.Data;
using OfficeManagementSystem.Essential;
using OfficeManagementSystem.Models;

namespace OfficeManagementSystem
{
    public partial class LoginForm : Form
    {
        OMScontext _OMScontext = new OMScontext();
        string userName = null;
        Users loginUser = null;
        Boolean reset = false;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            UpdateForm();
        }


        //**************************************************************************************************************
        //
        //  Buttons
        //
        //**************************************************************************************************************
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                // Check to see if there is actually something in the textboxes.
                // Can modify Validator to check for certain characters if need be.
                if (IsValidData())
                {
                    byte[] encryptPassword = Encoding.ASCII.GetBytes(tbxPassword.Text);
                    if (!reset)
                    {
                        var userToLogin = _OMScontext.Users.Where(i => i.Username == tbxUsername.Text && i.Password == encryptPassword);
                        // If data is Valid, check username and password
                            if (userToLogin.ToArray().Length != 0)
                        {
                            // Send to database to check to see if Username and Password match
                            // If they do, create dialog result and send back the User.
                            MessageBox.Show("Successfully logged in as " + tbxUsername.Text);
                            loginUser = userToLogin.First();
                            Debug.Write(loginUser.ToString());


                            this.DialogResult = DialogResult.None;
                            this.Close();
                        }
                        else
                        {
                            // If not, stay on login screen and display reason why. Change lblInfo.
                            lblInfo.Text = "Incorrect Username and/or Password, please try again.";
                            this.UpdateForm();
                            lblInfo.ForeColor = Color.Red;

                        }
                    }
                    else
                    {
                        var userToLogin = _OMScontext.Users.Where(i => i.Username == userName);
                        userToLogin.First().Password = encryptPassword;
                        _OMScontext.SaveChanges();
                        MessageBox.Show(userName + "'s password has been updated.");
                        this.DialogResult = DialogResult.None;
                        this.Close();
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
        }

        //**************************************************************************************************************
        //
        //  Utility Functions
        //
        //**************************************************************************************************************
        public Boolean IsValidData()
        {
            if(!reset)
            {
                return
                    Validator.IsPresent(tbxUsername) &&
                    Validator.IsPresent(tbxPassword);
            }
            else
            {
                return
                    Validator.IsPresent(tbxUsername) &&
                    Validator.IsPresent(tbxPassword) &&
                    tbxPassword.Text == tbxUsername.Text;
            }

        }
        private void UpdateForm()
        {
            lblInfo.Location = new Point(((this.Size.Width - lblInfo.Size.Width) / 2), lblInfo.Location.Y);
        }


        //**************************************************************************************************************
        //
        //  Call Service(?) Functions
        //
        //**************************************************************************************************************
        public Users LoginUser(Users localUser)
        {
            loginUser = localUser;
            if(localUser != null)
            {
                tbxUsername.Text = loginUser.Username;
            }

            this.ShowDialog();

            return loginUser;
        }

        public void ResetPassword(string username)
        {
            reset = true;
            this.Text = "Reseting Password for: [" + username + "]";
            this.lblInfo.Text = "Please enter a new password:";
            this.lblUsername.Text = "New Password:";
            this.lblPassword.Text = "Reenter Password:";
            this.HelpButton = false;
            userName = username;

            this.ShowDialog();


        }

        private void LoginForm_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            LoginForm resetPass = new LoginForm();
            var userToLogin = _OMScontext.Users.Where(i => i.Username == tbxUsername.Text);
            Debug.Write(userToLogin.ToArray().Length);
            if (Validator.IsPresent(tbxUsername) && userToLogin.ToArray().Length != 0)
                resetPass.ResetPassword(tbxUsername.Text);
            // Reset Password Here


        }
    }
}
