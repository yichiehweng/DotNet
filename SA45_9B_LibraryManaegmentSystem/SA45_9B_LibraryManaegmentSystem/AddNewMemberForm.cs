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
    public partial class AddNewMemberForm : Form
    {
        LibraryEntities context = new LibraryEntities();        
        public AddNewMemberForm()
        {
            InitializeComponent();
            string lastID = context.Members.AsEnumerable().Last().MemberID.ToString();
            newMemberID_label.Text = (Int32.Parse(lastID) + 1).ToString();
            category_comboBox.DataSource = context.Members.Select(x => x.MemberCategory).Distinct().ToList();
            category_comboBox.SelectedIndex = 0;
        }
        private void newMemberOK_button_Click(object sender, EventArgs e)
        {
            Member newMember = new Member();
            newMember.MemberID = newMemberID_label.Text;
            newMember.MemberName = memberName_textBox.Text;
            newMember.MemberCategory = category_comboBox.SelectedItem.ToString();
            newMember.PhoneNumber = phoneNumber_textBox.Text;
            newMember.PostAddress = address_textBox.Text;
            newMember.PostalCode = postalCode_textBox.Text;
            newMember.EmailAddress = emailAddress_textBox.Text;
            newMember.Notes = notes_textBox.Text;
       
            List<ValidationResult> theList= newMember.Validate(new ValidationContext(newMember)).ToList();
            if(theList.Count != 0)
            {
               toolStripStatusLabel1.Text= theList.First().ToString();
            }
            else
            {
                context.Members.Add(newMember);
                context.SaveChanges();
                MessageBox.Show("New Member has been created!");
                DialogResult = DialogResult.OK;
            }
            
        }
        private void newMemberCancel_button_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.Cancel;
        }

    }
}
