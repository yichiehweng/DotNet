using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA45_9B_LibraryManaegmentSystem
{
    public partial class NewUserForm : Form
    {
        LibraryEntities context = new LibraryEntities();
        public NewUserForm()
        {
            InitializeComponent();
        }
        private void submit_button_Click(object sender, EventArgs e)
        {
            UserMaster theUser = new UserMaster();
            theUser.EmployeeID = employeeID_textBox.Text;
            theUser.LoginName = loginName_textBox.Text;
            theUser.UserPassWord = password_textBox.Text;          
            try
            {
                validate(theUser);
                theUser.UserPhoneNumber = context.Employees.Where(x => x.EmployeeID == employeeID_textBox.Text).First().EmployeePhoneNumber;
                context.UserMasters.Add(theUser);
                context.SaveChanges();
                toolStripStatusLabel1.Text = "New User has been created: " + theUser.LoginName;
                DialogResult = DialogResult.OK;

            }
            catch(Exception exection)
            {
                toolStripStatusLabel1.Text = exection.Message;
            }        
        }
        private void validate(UserMaster theUser)
        {
            List<string> employeeIDList = context.Employees.AsEnumerable().Select(x => x.EmployeeID).ToList();
            if (employeeIDList.Any(theUser.EmployeeID.Contains)==false)
            {
                throw new Exception("Please Enter a correct employeeID");
            }
            if (theUser.LoginName.Length<4)
            {
                throw new Exception("Login name must greater than 4");
            }
            if (theUser.UserPassWord.Length < 4)
            {
                throw new Exception("The length of password must greater than 4");
            }
            if (theUser.UserPassWord != password_textBox.Text)
            {
                throw new Exception("Please confirm your password");
            }
        }
        private void Cancel_button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
