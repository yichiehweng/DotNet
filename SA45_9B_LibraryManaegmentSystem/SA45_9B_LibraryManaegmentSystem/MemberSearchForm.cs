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
    public partial class MemberSearchForm : Form
    {
        LibraryEntities context = new LibraryEntities();
        public MemberSearchForm()
        {
            InitializeComponent();
        }
        private void search_button_Click(object sender, EventArgs e)
        {
            List<Member> theMembers;
            if (memberID_textBox.Text != "")
            {
                theMembers = context.Members.Where(x => x.MemberID.Contains(memberID_textBox.Text)).ToList();
            }
            else if (memberName_textBox.Text != "")
            {
                theMembers = context.Members.Where(x => x.MemberName.Contains(memberName_textBox.Text)).ToList();
            }else if(phoneNumber_textBox.Text != "")
            {
                theMembers = context.Members.Where(x => x.PhoneNumber.Contains(phoneNumber_textBox.Text)).ToList();
            }
            else
            {
                theMembers = context.Members.ToList();
            }
            search_dataGridView.DataSource = theMembers;
        }
        private void select_button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
        private void cancel_button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        public string MemberID
        { 
            get { return search_dataGridView.CurrentRow.Cells[0].Value.ToString(); }
        }
        public string MemberName
        {
            get { return search_dataGridView.CurrentRow.Cells[1].Value.ToString(); }
        }
        public int MemberCategory
        {
            get
            {
                string cat= search_dataGridView.CurrentRow.Cells[2].Value.ToString();
                if (cat == "A") { return 0; }
                else if (cat == "B") { return 1; }
                else { return 2; }
            }
        }
        public string PhoneNumber
        {
            get { return search_dataGridView.CurrentRow.Cells[3].Value.ToString(); }
        }
        public string Address
        {
            get { return search_dataGridView.CurrentRow.Cells[4].Value.ToString(); }
        }
        public string PostalCode
        {
            get { return search_dataGridView.CurrentRow.Cells[5].Value.ToString(); }
        }
        public string EmailAddress
        {
            get { return search_dataGridView.CurrentRow.Cells[6].Value.ToString(); }
        }
        public string Notes
        {
            get { return search_dataGridView.CurrentRow.Cells[7].Value.ToString();
            }
           
        }
    }
}
