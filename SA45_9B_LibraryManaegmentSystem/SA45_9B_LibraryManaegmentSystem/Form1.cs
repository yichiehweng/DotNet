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
    public partial class MainForm : Form
    {
        LibraryEntities context = new LibraryEntities();
        LoginForm login;
        public MainForm(LoginForm login)
        {
            InitializeComponent();
            this.login = login;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            userName_label.Text = login.userName;
            time_toolStripStatusLabel.Text = DateTime.Now.ToString("yyyy-mm-dd hh:mm:ss");
            timer1.Interval = 1000;
            timer1.Start();
        }
        private void addNewMember_button_Click(object sender, EventArgs e)
        {
            AddNewMemberForm addNewMemberForm = new AddNewMemberForm();
            addNewMemberForm.ShowDialog();
        }
        private void MemberRecord_button_Click(object sender, EventArgs e)
        {
            MemberMaintenceForm memberMaintenceForm = new MemberMaintenceForm();
            memberMaintenceForm.ShowDialog();
        }
        private void addNewBook_button_Click(object sender, EventArgs e)
        {
            AddNewBookForm addNewBookForm = new AddNewBookForm();
            addNewBookForm.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            BookMaintenceForm bookMaintenceForm = new BookMaintenceForm();
            bookMaintenceForm.ShowDialog();
        }
        private void lengingBook_button_Click(object sender, EventArgs e)
        {
            LendingBookForm lendingBookForm = new LendingBookForm();
            lendingBookForm.ShowDialog();
        }
        private void logout_button_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            time_toolStripStatusLabel.Text = DateTime.Now.ToString("yyyy-mm-dd hh:mm:ss");
        }
        private void changeInfo_button_Click(object sender, EventArgs e)
        {
            Employee theEmployee = context.Employees.Where(x => x.EmployeeID == login.theEmployeeID).First();
            ChangeInfoForm changeInfoForm = new ChangeInfoForm(theEmployee.EmployeeID);
            changeInfoForm.ShowDialog();
            
        }
        private void changePassword_button_Click(object sender, EventArgs e)
        {
            UserMaster theUser = context.UserMasters.Where(x => x.EmployeeID == login.theEmployeeID).First();
            ChangePasswordForm changePasswordForm = new ChangePasswordForm(theUser.EmployeeID);
            changePasswordForm.ShowDialog();
        }
        //Mouse Event
        private void query_button_Click(object sender, EventArgs e)
        {
            BookSearchForm bookSearchForm = new BookSearchForm();
            bookSearchForm.ShowDialog();
        }
        private void changeInfo_button_MouseHover(object sender, EventArgs e)
        {
            login_toolStripStatusLabel.Text = "Change personal information";
        }
        private void changeInfo_button_MouseLeave(object sender, EventArgs e)
        {
            login_toolStripStatusLabel.Text = "Please select an option";
        }
        private void changPassWord_button_MouseHover(object sender, EventArgs e)
        {
            login_toolStripStatusLabel.Text = "Change password";
        }
        private void changPassWord_button_MouseLeave(object sender, EventArgs e)
        {
            login_toolStripStatusLabel.Text = "Please select an option";
        }
        private void logout_button_MouseHover(object sender, EventArgs e)
        {
            login_toolStripStatusLabel.Text = "Logout the system";
        }
        private void logout_button_MouseLeave(object sender, EventArgs e)
        {
            login_toolStripStatusLabel.Text = "Please select an option";
        }
        private void addNewMember_button_MouseHover(object sender, EventArgs e)
        {
            login_toolStripStatusLabel.Text = "Add a new member";
        }
        private void addNewMember_button_MouseLeave(object sender, EventArgs e)
        {
            login_toolStripStatusLabel.Text = "Please select an option";
        }
        private void MemberRecord_button_MouseHover(object sender, EventArgs e)
        {
            login_toolStripStatusLabel.Text = "Update or remove member record";
        }
        private void MemberRecord_button_MouseLeave(object sender, EventArgs e)
        {
            login_toolStripStatusLabel.Text = "Please select an option";
        }
        private void AddNewBook_button_MouseHover(object sender, EventArgs e)
        {
            login_toolStripStatusLabel.Text = "Add a new book";
        }
        private void AddNewBook_button_MouseLeave(object sender, EventArgs e)
        {
            login_toolStripStatusLabel.Text = "Please select an option";
        }
        private void button2_MouseHover(object sender, EventArgs e)
        {
            login_toolStripStatusLabel.Text = "Matain book records";
        }
        private void button2_MouseLeave(object sender, EventArgs e)
        {
            login_toolStripStatusLabel.Text = "Please select an option";
        }
        private void query_button_MouseHover(object sender, EventArgs e)
        {
            login_toolStripStatusLabel.Text = "Query for avalible dates of books";
        }
        private void query_button_MouseLeave(object sender, EventArgs e)
        {
            login_toolStripStatusLabel.Text = "Please select an option";
        }
        private void lendingbook_button_MouseHover(object sender, EventArgs e)
        {
            login_toolStripStatusLabel.Text = "Lending and return books";
        }
        private void lendingbook_button_MouseLeave(object sender, EventArgs e)
        {
            login_toolStripStatusLabel.Text = "Please select an option";
        }

    }
}
