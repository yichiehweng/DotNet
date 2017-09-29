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
    public partial class QueryForm : Form
    {
        LibraryEntities context = new LibraryEntities();
        Book theBook;
        public QueryForm(Book theBook)
        {
            InitializeComponent();
            this.theBook = theBook;        
        }

        private void QueryForm_Load(object sender, EventArgs e)
        {
            List<IssueTran> its = context.IssueTrans.Where(x => x.ISBNNumber == theBook.ISBNNumber).Where(x=>x.RentalStatus=="out").ToList();

            query_dataGridView.DataSource = its.Select(x => new { x.Book.BookID, x.Book.ISBNNumber, x.Book.BookTitle, x.Book.stockNumber, x.DateDue, }).ToList();
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
