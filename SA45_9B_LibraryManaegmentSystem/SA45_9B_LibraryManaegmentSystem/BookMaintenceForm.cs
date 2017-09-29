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
    public partial class BookMaintenceForm : Form
    {
        LibraryEntities context = new LibraryEntities();
        public BookMaintenceForm()
        {
            InitializeComponent();
        }
        private void BookMaintenceForm_Load(object sender, EventArgs e)
        {
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
                category_textBox.Text = bookSearchForm.BookCategory;


                genre_textBox.Text = bookSearchForm.Genre;
                publisher_textBox.Text = bookSearchForm.Publisher;
                author_textBox.Text = bookSearchForm.Authorr;
                language_textBox.Text = bookSearchForm.Language;
                callNumber_textBox.Text = bookSearchForm.CallNumber;
                edition_textBox.Text = bookSearchForm.Edition;
                publishDate_textBox.Text = bookSearchForm.PublishDate;
                stockNumber_textBox.Text = bookSearchForm.StockNumber;
                rentedNumber_textBox.Text = bookSearchForm.RentedNumber;
            }
        }
        private void Update_button_Click(object sender, EventArgs e)
        {
            Book theBook = context.Books.Where(x => x.ISBNNumber == isbn_textBox.Text).First();
            theBook.BookID=short.Parse(bookID_textBox.Text);
            theBook.ISBNNumber=isbn_textBox.Text ;
            theBook.BookTitle=bookTitle_textBox.Text ;
            theBook.Category=category_textBox.Text;
            theBook.Genre=genre_textBox.Text ;
            theBook.Publisher=publisher_textBox.Text ;
            theBook.Author=author_textBox.Text ;
            theBook.BookLanguage=language_textBox.Text ;
            theBook.CallNumber=callNumber_textBox.Text ;
            theBook.Edition=edition_textBox.Text ;
            theBook.PublicationDate= DateTime.Parse(publishDate_textBox.Text);
            theBook.stockNumber=short.Parse(stockNumber_textBox.Text);
            theBook.RantedNumber = short.Parse(rentedNumber_textBox.Text);

            List<ValidationResult> theList = theBook.Validate(new ValidationContext(theBook)).ToList();
            if (theList.Count != 0)
            {
                toolStripStatusLabel1.Text = theList.First().ToString();
            }
            else
            {
                context.SaveChanges();

                toolStripStatusLabel1.Text = "the Book information has been updated!";
            }
              
        }
        private void delete_button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to remove this book?", "Delete Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Book theBook = context.Books.Where(x => x.ISBNNumber == isbn_textBox.Text).First();
                context.Books.Remove(theBook);
                context.SaveChanges();
                toolStripStatusLabel1.Text = "the book has been deleted!";
            }
            else
            {
                toolStripStatusLabel1.Text = "Delete option terminated!";
            }
        }
        private void Back_button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }     
    }
}
