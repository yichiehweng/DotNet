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
    public partial class ChangePasswordForm : Form
    {
        LibraryEntities context = new LibraryEntities();
        UserMaster theUser;
        public ChangePasswordForm(string employeeID)
        {
            InitializeComponent();
            theUser = context.UserMasters.Where(x => x.EmployeeID == employeeID).First();
            ID_label.Text = theUser.EmployeeID;
            name_label.Text = theUser.LoginName;
        }
        private void submit_button_Click(object sender, EventArgs e)
        {
            if (oldPassword_textBox.Text == theUser.UserPassWord && new1_textBox.Text == new2_textBox.Text)
            {
                theUser.UserPassWord = new1_textBox.Text;
                context.SaveChanges();
                MessageBox.Show("Password has been updated!");
                DialogResult = DialogResult.OK;
            }
            else if (new1_textBox.Text.Length<4)
            {
                toolStripStatusLabel1.Text = "The length of password cannot less than 4";
            }
            else
            {
                toolStripStatusLabel1.Text="Please try again!";
            }
        }
        private void cancel_button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
