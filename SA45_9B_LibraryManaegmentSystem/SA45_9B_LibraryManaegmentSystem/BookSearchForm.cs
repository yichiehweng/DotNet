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
    public partial class BookSearchForm : Form
    {
        LibraryEntities context = new LibraryEntities();
        public BookSearchForm()
        {
            InitializeComponent();
            Search_comboBox1.SelectedIndex = 0;
            Search_comboBox2.SelectedIndex = 0;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            List<Book> bookList=null;
            var query1 = context.Books.Where(x => x.ISBNNumber.Contains(ISBN_textBox.Text));
            var query2 = context.Books.Where(x => x.BookTitle.Contains(title_textBox.Text));
            var query3 = context.Books.Where(x => x.Author.Contains(author_textBox.Text));

            if (Search_comboBox1.SelectedIndex == 0 && Search_comboBox2.SelectedIndex==0)
            {
                bookList = query1.Intersect(query2).Intersect(query3).ToList();
            }
            if (Search_comboBox1.SelectedIndex == 0 && Search_comboBox2.SelectedIndex == 1)
            {
                bookList = query1.Intersect(query2).Union(query3).ToList();
            }
            if (Search_comboBox1.SelectedIndex == 0 && Search_comboBox2.SelectedIndex == 2)
            {
                bookList = query1.Intersect(query2).Except(query3).ToList();
            }
            if (Search_comboBox1.SelectedIndex == 1 && Search_comboBox2.SelectedIndex == 0)
            {
                bookList = query1.Union(query2).Intersect(query3).ToList();
            }
            if (Search_comboBox1.SelectedIndex == 1 && Search_comboBox2.SelectedIndex == 1)
            {
                bookList = query1.Union(query2).Union(query3).ToList();
            }
            if (Search_comboBox1.SelectedIndex == 1 && Search_comboBox2.SelectedIndex == 2)
            {
                bookList = query1.Union(query2).Except(query3).ToList();
            }
            if (Search_comboBox1.SelectedIndex == 2 && Search_comboBox2.SelectedIndex == 2)
            {
                bookList = query1.Except(query2).Except(query3).ToList();
            }
            search_dataGridView.DataSource = bookList;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            List<Book> bookList = context.Books.Where(x => x.BookTitle.Contains(basicSearch_textBox.Text) || x.Author.Contains(basicSearch_textBox.Text)).ToList();
            search_dataGridView.DataSource=bookList;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        public string BookID
        {
            get { return search_dataGridView.CurrentRow.Cells[10].Value.ToString(); }
        }
        public string ISBNNumber
        {
            get { return search_dataGridView.CurrentRow.Cells[1].Value.ToString(); }
        }
        public string BookTitle
        {
            get { return search_dataGridView.CurrentRow.Cells[2].Value.ToString(); }
        }
        public string Genre
        {
            get { return search_dataGridView.CurrentRow.Cells[3].Value.ToString(); }
        }
        public string Publisher
        {
            get { return search_dataGridView.CurrentRow.Cells[4].Value.ToString(); }
        }
        public string Authorr
        {
            get { return search_dataGridView.CurrentRow.Cells[5].Value.ToString(); }
        }
        public string Language
        {
            get { return search_dataGridView.CurrentRow.Cells[6].Value.ToString(); }
        }
        public string CallNumber
        {
            get { return search_dataGridView.CurrentRow.Cells[7].Value.ToString(); }
        }
        public string StockNumber
        {
            get { return search_dataGridView.CurrentRow.Cells[8].Value.ToString(); }
        }
        public string RentedNumber
        {
            get { return search_dataGridView.CurrentRow.Cells[9].Value.ToString(); }
        }
        public string BookCategory
        {
            get { return search_dataGridView.CurrentRow.Cells[11].Value.ToString(); }
        }
        public string Edition
        {
            get { return search_dataGridView.CurrentRow.Cells[12].Value.ToString(); }
        }
        public string PublishDate
        {
            get { return search_dataGridView.CurrentRow.Cells[13].Value.ToString(); }
        }

        private void show_button_Click(object sender, EventArgs e)
        {
        }
        private void search_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string theBookISBN = search_dataGridView.CurrentRow.Cells[1].Value.ToString();
            Book theBook = context.Books.Where(x => x.ISBNNumber == theBookISBN).First();
            QueryForm queryForm = new QueryForm(theBook);
            queryForm.ShowDialog();

        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PrintBookListForm printBookListForm = new PrintBookListForm();
            printBookListForm.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AnalysisForm analysisForm = new AnalysisForm();
            analysisForm.ShowDialog();
        }
    }
}
