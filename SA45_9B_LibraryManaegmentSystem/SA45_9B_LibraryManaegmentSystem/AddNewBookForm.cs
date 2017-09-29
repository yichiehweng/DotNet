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
    public partial class AddNewBookForm : Form
    {
        LibraryEntities context = new LibraryEntities();
        public AddNewBookForm()
        {
            InitializeComponent();
            int? newBookID=context.Books.AsEnumerable().Last().BookID+1;
            newBookID_label.Text = newBookID.ToString();
            category_comboBox.DataSource = context.Books.Select(x => x.Category).Distinct().ToList();
            genre_comboBox.DataSource = context.Books.Select(x => x.Genre).Distinct().ToList();
        }
        private void submit_button_Click(object sender, EventArgs e)
        {
            Book newBook = new Book();
            newBook.BookID = short.Parse(newBookID_label.Text);
            newBook.ISBNNumber = isbn_textBox.Text;
            newBook.BookTitle = bookTitle_textBox.Text;
            newBook.Genre = genre_comboBox.SelectedText;
            newBook.Publisher = publisher_textBox.Text;
            newBook.Author = author_textBox.Text;
            newBook.BookLanguage = language_textBox.Text;
            newBook.CallNumber = callNumber_textBox.Text;
            newBook.Category = category_comboBox.SelectedText;
            newBook.Edition = edition_textBox.Text;
            newBook.PublicationDate = publishDate_dateTimePicker.Value.Date;
            newBook.stockNumber = short.Parse(stockNumber_textBox.Text);
            newBook.RantedNumber = 0;
            List<ValidationResult> theList = newBook.Validate(new ValidationContext(newBook)).ToList();
            if (theList.Count != 0)
            {
                toolStripStatusLabel1.Text = theList.First().ToString();
            }
            else
            {
                context.Books.Add(newBook);
                context.SaveChanges();
                toolStripStatusLabel1.Text = "New book has been added!";
                DialogResult = DialogResult.OK;
            }
        }
        private void cancel_button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
