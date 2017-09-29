using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;

namespace SA45_9B_LibraryManaegmentSystem
{
    public partial class LendingBookForm : Form
    {
        LibraryEntities context = new LibraryEntities();
        IssueTran theTran;
        List<IssueTran> theList=new List<IssueTran>();
        public LendingBookForm()
        {
            InitializeComponent();
        }
        private void LendingBookForm_Load(object sender, EventArgs e)
        {
            issueDate_dateTimePicker.Value = DateTime.Today;
            dueDate_dateTimePicker.Value = DateTime.Today.Add(new System.TimeSpan(7, 0, 0, 0, 0));
        }
        private void memberSearch_button_Click(object sender, EventArgs e)
        {
            MemberSearchForm memberSearchForm = new MemberSearchForm();
            DialogResult r = memberSearchForm.ShowDialog();
            if (r == DialogResult.OK)
            {
                memberID_textBox.Text = memberSearchForm.MemberID;
                memberName_textBox.Text = memberSearchForm.MemberName;                
                phoneNumber_textBox.Text = memberSearchForm.PhoneNumber;               
            }
        }
        private void bookSearch_button_Click(object sender, EventArgs e)
        {
            BookSearchForm bookSearchForm = new BookSearchForm();
            DialogResult r = bookSearchForm.ShowDialog();
            if (r == DialogResult.OK)
            {
                bookID_textBox.Text = bookSearchForm.BookID;
                isbn_textBox.Text = bookSearchForm.ISBNNumber;
                bookTitle_textBox.Text = bookSearchForm.BookTitle;                
            }
        }
        private void lending_button_Click(object sender, EventArgs e)
        {
            using (TransactionScope ts=new TransactionScope())
            {
                theTran = new IssueTran();
                int number=context.IssueTrans.Count();
                theTran.TransactionID = (short)(number + 1);
                theTran.MemberID = memberID_textBox.Text;
                theTran.ISBNNumber = isbn_textBox.Text;
                theTran.EmployeeID = "1000";
                theTran.DateIssue = issueDate_dateTimePicker.Value.Date;
                theTran.DateDue = dueDate_dateTimePicker.Value.Date;
                theTran.RentalStatus = "out";
                theTran.Remarks = remark_textBox.Text;
                theTran.Member = theTran.Member;
                theTran.Employee = context.Employees.Where(x => x.EmployeeID == "1000").First();
                theTran.DateActualReturn = DateTime.Now.AddDays(7);

                List<ValidationResult> theList = theTran.Validate(new ValidationContext(theTran)).ToList();
                if (theList.Count != 0)
                {
                    toolStripStatusLabel1.Text = theList.First().ToString();
                }
                else
                {
                    Book rentedbook = context.Books.Where(x => x.ISBNNumber == isbn_textBox.Text).First();
                    rentedbook.stockNumber--;
                    rentedbook.RantedNumber++;
                    if(rentedbook.stockNumber<0)
                    {
                        toolStripStatusLabel1.Text = "StockNumber cannot less  than 0";
                    }
                    else
                    {
                        context.IssueTrans.Add(theTran);
                        context.SaveChanges();
                        ts.Complete();
                        toolStripStatusLabel1.Text = "Transaction Sucessfully";
                    }                    
                }
            }
        }
        private void return_button_Click(object sender, EventArgs e)
        {
            theTran = context.IssueTrans.Where(x => x.MemberID == memberID_textBox.Text).
                                                   Where(y => y.ISBNNumber == isbn_textBox.Text).Last();
            theTran.DateActualReturn = DateTime.Today;
            Book returnedbook = context.Books.Where(x => x.ISBNNumber == isbn_textBox.Text).First();
            returnedbook.stockNumber++;
            returnedbook.RantedNumber--;
            context.SaveChanges();
            toolStripStatusLabel1.Text = "Return Sucessfully";
        }
        private void Back_button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void extend_button_Click(object sender, EventArgs e)
        {
            theTran = context.IssueTrans.Where(x => x.MemberID == memberID_textBox.Text).
                                                   Where(y => y.ISBNNumber == isbn_textBox.Text).Last();
            theTran.DateDue= DateTime.Today.AddDays(7);
            context.SaveChanges();
            toolStripStatusLabel1.Text = "Extend Sucessfully";
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (theTran==null||theTran.MemberID==""||theTran.ISBNNumber=="")
            {
                toolStripStatusLabel1.Text = "Please complete member info and book info";
            }
            else
            {
                //theList.Add(theTran);
                ReceiptForm receiptForm = new ReceiptForm();
                receiptForm.ShowDialog();
            }
            
        }
    }
}
