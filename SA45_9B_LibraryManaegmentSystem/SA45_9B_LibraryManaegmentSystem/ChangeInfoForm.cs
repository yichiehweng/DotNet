using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;


namespace SA45_9B_LibraryManaegmentSystem
{
    public partial class ChangeInfoForm : Form
    {
        LibraryEntities context = new LibraryEntities();
        Employee theEmployee;
        public ChangeInfoForm(string employeeID)
        {
            InitializeComponent();
            theEmployee = context.Employees.Where(x => x.EmployeeID == employeeID).First();
            ID_label.Text = theEmployee.EmployeeID;
            name2_label.Text = theEmployee.EmployeeName;
            phone_textBox.Text = theEmployee.EmployeePhoneNumber;
            address_textBox.Text = theEmployee.EmployeeAddress;
        }
        private void update_button_Click(object sender, EventArgs e)
        {
            theEmployee.EmployeePhoneNumber= phone_textBox.Text;
            theEmployee.UserMaster.UserPhoneNumber= phone_textBox.Text;
            theEmployee.EmployeeAddress = address_textBox.Text;
            List<ValidationResult> theList = theEmployee.Validate(new ValidationContext(theEmployee)).ToList();                       
            if (theList.Count != 0)
            {
                toolStripStatusLabel1.Text = theList.First().ToString();
            }
            else
            {
                context.SaveChanges();
                MessageBox.Show("The information has been updated!");
                DialogResult = DialogResult.OK;
            }
        }
        private void cancel_button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }


    }
}
