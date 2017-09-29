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
    public partial class AnalysisForm : Form
    {
        public AnalysisForm()
        {
            InitializeComponent();
        }

        private void AnalysisForm_Load(object sender, EventArgs e)
        {
            LibraryDataSet ds = new LibraryDataSet();
            LibraryDataSetTableAdapters.BookTableAdapter ts = new LibraryDataSetTableAdapters.BookTableAdapter();
            ts.Fill(ds.Book);
            CrystalReport2 cr = new CrystalReport2();
            cr.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cr;
        }
    }
}
