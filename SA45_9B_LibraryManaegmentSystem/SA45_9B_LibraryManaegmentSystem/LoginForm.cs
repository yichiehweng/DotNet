using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;

namespace SA45_9B_LibraryManaegmentSystem
{
    public partial class LoginForm : Form
    {
        LibraryEntities context = new LibraryEntities();
        UserMaster theUser;
        public LoginForm()
        {
            InitializeComponent();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            //set timer
            time_toolStripStatusLabel.Text = DateTime.Now.ToString("yyyy-mm-dd hh:mm:ss");
            timer1.Interval = 1000;
            timer1.Start();
        }       
        private void login_button_Click(object sender, EventArgs e)
        {
            if (isValid(userName_textBox.Text, password_textBox.Text))
            {
                theUser = context.UserMasters.Where(x => x.LoginName == userName_textBox.Text && x.UserPassWord == password_textBox.Text).First();
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                login_toolStripStatusLabel.Text = "Login failed! Please enter the correct name and password ";
            }

        }
        private void newUser_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewUserForm newUserForm = new NewUserForm();
            newUserForm.ShowDialog();
        }        
        private void exit_button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
           time_toolStripStatusLabel.Text = DateTime.Now.ToString("yyyy-mm-dd hh:mm:ss");
        }
        private bool isValid(string userName, string password)
        {
            var query = context.UserMasters.Where(x => x.LoginName == userName && x.UserPassWord == password);
            if (query.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string userName
        {
            get { return theUser.Employee.Title+theUser.Employee.EmployeeName; }
        }
        public string theEmployeeID
        {
            get { return theUser.EmployeeID; }
        }
    }
}
