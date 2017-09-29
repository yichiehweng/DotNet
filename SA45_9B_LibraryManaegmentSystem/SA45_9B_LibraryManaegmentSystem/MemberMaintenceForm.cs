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
    public partial class MemberMaintenceForm : Form
    {     
        LibraryEntities context = new LibraryEntities();
       
        public MemberMaintenceForm()
        {
            InitializeComponent();
            category_comboBox.DataSource = context.Members.Select(x => x.MemberCategory).Distinct().ToList();
        }
        private void memberSearch_button_Click(object sender, EventArgs e)
        {
            MemberSearchForm memberSearchForm = new MemberSearchForm();            
            DialogResult r = memberSearchForm.ShowDialog();
            if (r == DialogResult.OK)
            {
                memberID_textBox.Text = memberSearchForm.MemberID;
                memberName_textBox.Text = memberSearchForm.MemberName;
                category_comboBox.SelectedIndex = memberSearchForm.MemberCategory;             
                address_textBox.Text = memberSearchForm.Address;
                postalCode_textBox.Text = memberSearchForm.PostalCode;
                phoneNumber_textBox.Text = memberSearchForm.PhoneNumber;
                emailAddress_textBox.Text = memberSearchForm.EmailAddress;
                notes_textBox.Text = memberSearchForm.Notes;                
            }
        }
        private void Update_button_Click(object sender, EventArgs e)
        {
            Member theMember = context.Members.Where(x => x.MemberID == memberID_textBox.Text).First();
            theMember.MemberName = memberName_textBox.Text;
            theMember.MemberCategory = category_comboBox.SelectedText;
            theMember.PhoneNumber = phoneNumber_textBox.Text;
            theMember.PostAddress = address_textBox.Text;
            theMember.PostalCode = postalCode_textBox.Text;
            theMember.EmailAddress = emailAddress_textBox.Text;
            theMember.Notes = notes_textBox.Text;
            List<ValidationResult> theList = theMember.Validate(new ValidationContext(theMember)).ToList();
            if (theList.Count != 0)
            {
                toolStripStatusLabel1.Text = theList.First().ToString();
            }
            else
            {
                context.SaveChanges();
                toolStripStatusLabel1.Text="the Member information has been updated!";
            }                       
        }
        private void delete_button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Delete Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) {
                Member theMember = context.Members.Where(x => x.MemberID == memberID_textBox.Text).First();
                theMember.IssueTrans.Clear();
                context.Members.Remove(theMember);
                context.SaveChanges();
                toolStripStatusLabel1.Text="the Member has been deleted!";
            }
            else
            {
                toolStripStatusLabel1.Text="Delete option terminated!";
            }           
        }
        private void Back_button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }       
    }
}
