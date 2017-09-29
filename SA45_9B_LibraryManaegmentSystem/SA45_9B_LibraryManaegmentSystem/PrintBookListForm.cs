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
    public partial class PrintBookListForm : Form
    {
        public PrintBookListForm()
        {
            InitializeComponent();
        }

        private void PrintBookListForm_Load(object sender, EventArgs e)
        {
            LibraryDataSet ds = new LibraryDataSet();
            LibraryDataSetTableAdapters.BookTableAdapter ts = new LibraryDataSetTableAdapters.BookTableAdapter();
            ts.Fill(ds.Book);
            CrystalReport1 cr = new CrystalReport1();
            cr.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cr;
            /*
            DataSet1 ds = new DataSet1();
            DataSet1TableAdapters.BookTableAdapter ts = new DataSet1TableAdapters.BookTableAdapter();
            ts.Fill(ds.Book);
            CrystalReport2 cr = new CrystalReport2();
            cr.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cr;
            */
        }
    }
}
